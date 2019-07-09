/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using dotRAC.core;
using dotRAC.swp.codec;

namespace dotRAC.swp.format.version1_0
{
    public class ServiceWireFormat : IServiceWireFormat
    {
        private static readonly IExceptionResolver DefaultExceptionResolver = new ExceptionResolverChain(
                new ServiceWireExceptionResolver(), new DefaultExceptionResolver());

        private readonly IServiceWireCodecFactory codecFactory;
        private readonly ServiceWireCodecVersion codecVersion;
        private readonly IExceptionResolver exceptionResolver;
        private readonly IServiceWireMessageFormat endpointFailureFormat;

        public ServiceWireFormatVersion Version => ServiceWireFormatVersion.Version1_0;

        public ServiceWireCodecVersion CodecVersion => codecVersion;

        public IExceptionResolver ExceptionResolver => exceptionResolver;

        public ServiceWireFormat(
            IServiceWireCodecFactory codecFactory, ServiceWireCodecVersion codecVersion, IExceptionResolver exceptionResolver)
        {
            this.codecFactory = codecFactory;
            this.codecVersion = codecVersion;

            if (exceptionResolver == null || exceptionResolver is ServiceWireExceptionResolver) {
                this.exceptionResolver = DefaultExceptionResolver;
                //this.endpointFailureFormat = new EndpointFailureMessageFormat(DefaultExceptionResolver);
            }
            else
            {
                this.exceptionResolver = exceptionResolver;
                //this.endpointFailureFormat = new EndpointFailureMessageFormat(new ExceptionResolverChain(exceptionResolver, DefaultExceptionResolver));
            }
        }


        public IServiceWireCodec CreateCodec()
        {
            throw new NotImplementedException();
        }
    }
}
