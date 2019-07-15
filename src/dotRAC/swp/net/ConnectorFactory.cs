/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Diagnostics.Contracts;
using dotRAC.core;
using dotRAC.swp.codec;
using dotRAC.swp.format;

namespace dotRAC.swp.netty
{
    public class ConnectorFactory : IServiceWireConnectorFactory
    {
        private readonly IServiceWireFormatFactory formatFactory;

        public ConnectorFactory(IServiceWireCodecFactory codecFactory, IExceptionResolver throwableResolver)
        {
            Contract.Requires(codecFactory != default);

            formatFactory = new ServiceWireFormatFactory(codecFactory, throwableResolver);
        }

        public IServiceWireConnector CreateConnector()
        {
            throw new NotImplementedException();
        }
    }
}
