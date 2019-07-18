/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace DotRAC.SWP.Codec
{
    internal class ServiceWireCodecFactory : IServiceWireCodecFactory
    {
        public ServiceWireCodecVersion DefaultVersion => ServiceWireCodecVersion.Version1_0;

        public IServiceWireCodec CreateCodec() => CreateCodec(DefaultVersion);

        public IServiceWireCodec CreateCodec(ServiceWireCodecVersion version)
        {
            switch (version)
            {
                case ServiceWireCodecVersion.Version1_0:
                    return new Version1_0.ServiceWireCodec();

                default:
                    throw new ServiceWireCodecException("Unsupported codec version");
            }
        }
    }
}
