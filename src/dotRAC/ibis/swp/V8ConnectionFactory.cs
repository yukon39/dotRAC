/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Timers;
using DotNetty.Common.Concurrency;
using dotRAC.ibis.client;
using DotRAC.SWP;

namespace dotRAC.ibis.swp
{
    public class V8ConnectionFactory : IV8ConnectionFactory
    {
        private readonly IServiceWireConnector connector;


        public V8ConnectionFactory(IServiceWireConnectorFactory connectorFactory, Timer timer, IExecutor executor, long connectTimeout)
        {
            Contract.Requires<InvalidOperationException>(connectorFactory != default, "connectorFactory");

            NameValueCollection properties = new NameValueCollection
            {
                { ProtocolConstants.GetProtocolParameterName("connect.timeout"), connectTimeout.ToString() }
            };

            connector = connectorFactory.CreateConnector(executor, timer, properties);
        }

        public IV8Connection CreateConnection()
        {
            Contract.Requires(connector != default);
            return new V8Connection(connector);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
