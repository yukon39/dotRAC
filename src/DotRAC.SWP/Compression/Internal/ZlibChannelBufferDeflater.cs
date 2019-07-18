/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Diagnostics.Contracts;
using DotNetty.Buffers;
using DotNetty.Codecs.Compression;

namespace DotRAC.SWP.Compression.Internal
{
    public class ZlibChannelBufferDeflater : IChannelBufferDeflater
    {
        private const uint BUFFER_SIZE = 32768;
        private readonly int level;

        public ZlibChannelBufferDeflater() => level = 6;

        public ZlibChannelBufferDeflater(int level) => this.level = level;


        public IByteBuffer DeflateBuffer(IByteBuffer buffer)
        {
            Contract.Requires(buffer is IByteBuffer);

            if (!buffer.IsReadable())
            {
                return Unpooled.Empty;
            }

            JZlibEncoder compressor = new JZlibEncoder(level);
            IByteBuffer result = Unpooled.CompositeBuffer(); //.dynamicBuffer();

            if (buffer.HasArray)
            {
                //byte[] source = buffer.Array;
                //compressor.SetInput(source,
                //        buffer.arrayOffset(),
                //        source.length - buffer.arrayOffset());

            }

            return default;
        }
    }
}
