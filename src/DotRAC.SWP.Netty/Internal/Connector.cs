/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using DotNetty.Common.Concurrency;
using DotNetty.Common.Utilities;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels.Groups;
using DotRAC.SWP.Format;
using log4net;

namespace DotRAC.SWP.Netty.Internal
{
    public sealed class Connector : IServiceWireConnector
    {
        private static readonly ILog LOGGER = LogManager.GetLogger(typeof(Connector));

        private readonly Bootstrap bootstrap;
        private readonly NameValueCollection properties;
        private readonly IChannelGroup channels;
        private readonly ITimer idleTimer;

        public Connector(IExecutor executor, ITimer timer, IServiceWireFormatFactory formatFactory, NameValueCollection properties)
        {
            Contract.Requires(timer is ITimer);
            Contract.Requires(executor is IExecutor);
            Contract.Requires(formatFactory is IServiceWireFormatFactory);
            Contract.Requires(properties is NameValueCollection);

            idleTimer = timer;
            //channels = new DefaultChannelGroup(executor);
            //new NioClientSocketChannelFactory(executor, executor)
            bootstrap = new Bootstrap();
            this.properties = properties;

            Utils.SetupBootstrapProperties(bootstrap, this.properties);

            //int.Parse(properties.getProperty(
            //    ProtocolConstants.getProtocolParameterName("connect.timeout"),
            //    Integer.toString(2000)));

            // bootstrap.SetOption("connectTimeoutMillis", connectTimeout);
            Dictionary<string, object> parameters = ProtocolUtils.GetConnectionParameters(properties);
            // bootstrap.SetPipelineFactory(new ClientChannelPipelineFactory(idleTimer, formatFactory, new CompressionSupportFactory(), parameters));
        }


        public IServiceWireFuture Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
