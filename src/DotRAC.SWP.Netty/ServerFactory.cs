/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Diagnostics.Contracts;
using DotRAC.Core;
using DotRAC.SWP.Codec;
using DotRAC.SWP.Endpoints;

namespace DotRAC.SWP.Netty
{
    public class ServerFactory : IServiceWireServerFactory
    {
        private readonly IServiceWireCodecFactory codecFactory;
        private readonly IExceptionResolver exceptionResolver;
        private readonly IServiceWireHandlerRegistryFactory handlerRegistryFactory;
        public ServerFactory(IServiceWireCodecFactory codecFactory, IExceptionResolver exceptionResolver, IServiceWireHandlerRegistryFactory handlerRegistryFactory)
        {
            Contract.Requires(codecFactory != default);
            Contract.Requires(handlerRegistryFactory != default);

            this.codecFactory = codecFactory;
            this.exceptionResolver = exceptionResolver;
            this.handlerRegistryFactory = handlerRegistryFactory;
        }

        //public IServiceWireServer CreateServer(Executor executor, Timer timer, SaslProperties saslProperties, ISslContextFactory sslContextFactory, Properties properties)
        //{
        //    ServiceWireFormatFactory formatFactory = new ServiceWireFormatFactory(codecFactory, exceptionResolver);

        //    //JavaTimer javaTimer = (timer != null) ? new JavaTimer(timer) : new HashedWheelTimer();

        //    return new Server(executor, javaTimer, formatFactory, handlerRegistryFactory, saslProperties, sslContextFactory, properties);
        //}

    }
}
