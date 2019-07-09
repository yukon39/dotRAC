/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using dotRAC.core;
using dotRAC.swp.codec;

namespace dotRAC.swp.format
{
    internal class ServiceWireFormatFactory : IServiceWireFormatFactory
    {
        private readonly IServiceWireCodecFactory codecFactory;
        private readonly IExceptionResolver exceptionResolver;

        public ServiceWireFormatVersion DefaultVersion => ServiceWireFormatVersion.Version1_0;

        public ServiceWireFormatFactory(IServiceWireCodecFactory codecFactory, IExceptionResolver exceptionResolver)
        {
            this.codecFactory = codecFactory;
            this.exceptionResolver = exceptionResolver;
        }


        public IServiceWireFormat CreateFormat() => CreateFormat(DefaultVersion, codecFactory.DefaultVersion);

        public IServiceWireFormat CreateFormat(ServiceWireFormatVersion protocolVersion, ServiceWireCodecVersion codecVersion)
        {
            switch (protocolVersion)
            {
                case ServiceWireFormatVersion.Version1_0:
                    return new version1_0.ServiceWireFormat(codecFactory, codecVersion, exceptionResolver);

                default:
                    throw new ServiceWireFormatException("Unsupported wire format");
            }
        }
    }
}
