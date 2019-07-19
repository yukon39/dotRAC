/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Timers;
using DotNetty.Common.Concurrency;
using DotNetty.Common.Utilities;
using dotRAC.swp.netty.Internal;
using DotRAC.Core;
using DotRAC.SWP;
using DotRAC.SWP.Codec;
using DotRAC.SWP.Format;

namespace dotRAC.swp.netty
{
    public class ConnectorFactory : IServiceWireConnectorFactory
    {
        private readonly IServiceWireFormatFactory formatFactory;

        public ConnectorFactory(IServiceWireCodecFactory codecFactory, IExceptionResolver exceptionResolver)
        {
            Contract.Requires(codecFactory != default);

            formatFactory = new ServiceWireFormatFactory(codecFactory, exceptionResolver);
        }

        public IServiceWireConnector CreateConnector(IExecutor executor, Timer timer, NameValueCollection properties)
        {
            ITimer swpTimer = (timer != default) ? (ITimer)new SwpTimer(timer) : new HashedWheelTimer();

            return new Connector(executor, swpTimer, formatFactory, properties);
        }
    }
}
