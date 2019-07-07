/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net;
using dotRAC.ibis.client;
using dotRAC.ibis.transport;
using dotRAC.swp;
using log4net;

namespace dotRAC.ibis.swp
{
    public class V8Connection : AbstractV8Lifecycle<IV8ConnectionContext>, IV8Connection
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(V8Connection));
        //private static readonly IServiceWireEndpointFormatFactory ENDPOINT_FORMAT_FACTORY = new EndpointFormatFactory();
        private static readonly string SUPPORTED_HINT_PREFIX = " supported=";
        private readonly IServiceWireConnector connector;
        private IServiceWireConnection connection;

        public V8Connection(IServiceWireConnector _connector)
        {
            Contract.Requires(_connector != default);
            connector = _connector;
        }

        public new void Start(IV8ConnectionContext context)
        {
            Contract.Requires(connection == default);

            log.Debug(string.Format("Connecting to: ''{0}''", context.HostName));

            try
            {
                IPHostEntry hostNameEntry = Dns.GetHostEntry(context.HostName);
            }
            catch (Exception e)
            {
                log.Error("Connection error", e);
                throw new V8ConnectionException("Connection error", e);
            }

            log.Debug("Connection established");
        }

        public new void Stop()
        {
            Contract.Requires(connection != default);

            IServiceWireFuture f = connection.Close();

            connection = null;

            f.AwaitUninterruptibly();
            if (f.Failed)
            {
                V8ConnectionException cause = ProcessException(f.InnerException);
                NotifyOnException(cause);
                throw cause;
            }
        }

        public bool IsSame(IV8Connection paramIV8Connection)
        {
            throw new NotImplementedException();
        }

        public IV8Transport StartService(string paramString1, List<string> paramList, string paramString2, IV8MessageFormatFactory paramIV8MessageFormatFactory)
        {
            throw new NotImplementedException();
        }

        private V8ConnectionException ProcessException(Exception cause)
        {
            Contract.Requires(cause != default);

            Exception exc = cause;
            if (exc is ServiceWireConnectionException)
            {
                exc = exc.InnerException;
            }

            return new V8ConnectionException("Process exception", exc);
        }
    }
}
