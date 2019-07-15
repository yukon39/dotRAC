/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Text;

namespace dotRAC.swp.codec.version1_0
{
    internal class ServiceWireCodec : IServiceWireCodec
    {
        private const ServiceWireCodecVersion version = ServiceWireCodecVersion.Version1_0;

        internal static Encoding encoding = Encoding.UTF8;

        private readonly IServiceWireEncoder encoder;
        private readonly IServiceWireDecoder decoder;

        public ServiceWireCodecVersion Version => version;

        public IServiceWireEncoder Encoder => encoder;

        public IServiceWireDecoder Decoder => decoder;

        public ServiceWireCodec()
        {
            encoder = new ServiceWireEncoder(this);
            decoder = new ServiceWireDecoder(this);

            //encoding.GetByteCount();
        }

    }
}
