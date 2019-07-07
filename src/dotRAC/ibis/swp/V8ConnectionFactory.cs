/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Diagnostics.Contracts;
using dotRAC.ibis.client;
using dotRAC.swp;

namespace dotRAC.ibis.swp
{
    public class V8ConnectionFactory : IV8ConnectionFactory
    {
        private readonly IServiceWireConnector connector;


        public V8ConnectionFactory(IServiceWireConnectorFactory connectorFactory)
        {
            Contract.Requires(connectorFactory != default);

            connector = connectorFactory.CreateConnector();
        }

        public IV8Connection CreateConnection()
        {
            Contract.Requires(connector != default);
            return new V8Connection(connector);
        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
