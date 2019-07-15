/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Diagnostics.Contracts;
using DotNetty.Buffers;
using dotRAC.ibis.host;
using dotRAC.swp.codec;
using dotRAC.swp.endpoints;
using log4net;

namespace dotRAC.ibis.swp.Internal
{
    public class EndpointHandler : IServiceWireHandlerLifecycle
    {
        private static readonly ILog LOGGER = LogManager.GetLogger(typeof(EndpointHandler));
        private readonly string name;
        private readonly string version;

        private readonly IV8ServerHostProvider hostProvider;
        private readonly IServiceWireEndpointFormat format;
        private readonly ServiceWireCodecVersion codecVersion;
        private IV8ServerHost host;
        private Guid serviceId;

        internal EndpointHandler(string name, string version, IV8ServerHostProvider hostProvider,
            IServiceWireEndpointFormat format, ServiceWireCodecVersion codecVersion)
        {
            this.name = name;
            this.version = version;
            this.hostProvider = hostProvider;
            this.format = format;
            this.codecVersion = codecVersion;
        }

        public IServiceWireEndpointFormat Format => format;

        public IServiceWireEndpointMessage HandleMessage(IServiceWireEndpointMessage msg)
        {
            Contract.Requires(host != default);
            Contract.Requires(msg is EndpointMessage);

            EndpointMessage message = (EndpointMessage)msg;

            try
            {
                IByteBuffer response = host.ProcessMessage(serviceId, message.Message);
                if (response != null)
                {
                    return new EndpointMessage(response);
                }
                else
                {
                    return new VoidMessage();
                }
            }
            catch (V8EndpointException e)
            {
                return new ExceptionMessage(e.Buffer);
            }
        }

        public void OnOpenEndpoint()
        {
            Contract.Requires(this.host == default);

            Guid serviceId = default;
            IV8ServerHost host = default;

            try
            {
                ServerHostContext serverHostContext = new ServerHostContext(codecVersion);

                host = hostProvider.AcquireHost(serverHostContext);
                if (host == default)
                {
                    throw new InvalidOperationException();
                }
                serviceId = host.StartService(name, version);
            }
            catch (Exception e)
            {

                hostProvider.ReleaseHost(host);
                throw new ServiceWireEndpointException("Service not started", e);
            }

            this.host = host;
            this.serviceId = serviceId;
        }

        public void OnCloseEndpoint()
        {
            Contract.Requires(host != default);

            try
            {
                host.StopService(serviceId);
            }
            catch (Exception e)
            {
                LOGGER.Error(string.Format("Close endpoint {0} of service {1}:{2} - failed.", serviceId, name, version), e);
            }
            finally
            {
                hostProvider.ReleaseHost(host);
            }

            host = default;
            serviceId = default;
        }
    }
}
