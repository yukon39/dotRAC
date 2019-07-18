/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace DotRAC.SWP.Compression
{
    public class CompressionSupport : ICompressionSupport
    {
        private readonly IChannelBufferDeflater deflater;
        private readonly IChannelBufferInflater inflater;

        internal CompressionSupport(IChannelBufferDeflater deflater, IChannelBufferInflater inflater)
        {
            this.deflater = deflater;
            this.inflater = inflater;
        }

        public IChannelBufferDeflater Deflater => deflater;

        public IChannelBufferInflater Inflater => inflater;
    }
}
