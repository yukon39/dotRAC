/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Diagnostics.Contracts;
using dotRAC.core;
using dotRAC.ibis.client;
using dotRAC.ibis.server;
using dotRAC.swp;

namespace dotRAC.ibis.swp
{
    public class V8Integration : IV8Integration
    {
        public static IExceptionResolver DefaultExceptionResolver = new V8ExceptionResolver();
        public static uint DefaultConnectTimeout = 2000;

        private readonly IServiceWireServerFactory serverFactory;
        private readonly IServiceWireConnectorFactory connectorFactory;

        public V8Integration()
        {



        }

        public IV8Server CreateServer(IV8ServerContext context)
        {
            Contract.Requires(serverFactory != default);

            V8Server server = new V8Server(serverFactory);
            server.Start(context);

            return server;
        }

        public IV8ConnectionFactory CreateConnectionFactory()
        {
            Contract.Requires(connectorFactory != default);
            return new V8ConnectionFactory(connectorFactory);
        }
    }
}
