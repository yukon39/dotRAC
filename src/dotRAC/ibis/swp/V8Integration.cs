/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Diagnostics.Contracts;
using System.Timers;
using dotRAC.core;
using dotRAC.ibis.client;
using dotRAC.ibis.host;
using dotRAC.ibis.server;
using dotRAC.ibis.swp.Internal;
using dotRAC.swp;
using dotRAC.swp.codec;
using dotRAC.swp.netty;

namespace dotRAC.ibis.swp
{
    public class V8Integration : IV8Integration
    {
        public static ExceptionResolverChain DefaultExceptionResolver = new ExceptionResolverChain(new V8ExceptionResolver(), new DefaultExceptionResolver());
        public static uint DefaultConnectTimeout = 2000;

        private readonly IServiceWireConnectorFactory connectorFactory;
        private readonly IServiceWireServerFactory serverFactory;

        public V8Integration(IExceptionResolver exceptionResolver)
        {
            ServiceWireCodecFactory codecFactory = new ServiceWireCodecFactory();

            ExceptionResolverChain exceptionResolverChain = default;
            if (exceptionResolver == default || exceptionResolver is V8ExceptionResolver)
            {
                exceptionResolverChain = DefaultExceptionResolver;
            }
            else
            {
                exceptionResolverChain = new ExceptionResolverChain(DefaultExceptionResolver, exceptionResolver);
            }

            connectorFactory = new ConnectorFactory(codecFactory, exceptionResolverChain);
        }

        public V8Integration(IV8ServerHostProviderFactory hostProviderFactory, IExceptionResolver exceptionResolver)
        {
            ServiceWireCodecFactory codecFactory = new ServiceWireCodecFactory();

            ExceptionResolverChain exceptionResolverChain1 = default;
            ExceptionResolverChain exceptionResolverChain2 = default;

            if (exceptionResolver == null || exceptionResolver is V8ExceptionResolver)
            {
                exceptionResolverChain1 = DefaultExceptionResolver;
                exceptionResolverChain2 = DefaultExceptionResolver;
            }
            else
            {
                exceptionResolverChain1 = new ExceptionResolverChain(DefaultExceptionResolver, exceptionResolver);
                exceptionResolverChain2 = new ExceptionResolverChain(exceptionResolver, DefaultExceptionResolver);
            }

            connectorFactory = new ConnectorFactory(codecFactory, exceptionResolverChain1);

            EndpointHandlerRegistryFactory registryFactory = new EndpointHandlerRegistryFactory(hostProviderFactory);

            serverFactory = new ServerFactory(codecFactory, exceptionResolverChain2, registryFactory);

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

        public IV8ConnectionFactory CreateConnectionFactory(Timer paramTimer, long paramLong)
        {
            throw new System.NotImplementedException();
        }
    }
}
