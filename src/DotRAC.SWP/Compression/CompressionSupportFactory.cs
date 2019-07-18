/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotRAC.SWP.Compression.Internal;

namespace DotRAC.SWP.Compression
{
    public class CompressionSupportFactory : ICompressionSupportFactory
    {
        public const string DEFLATE = "deflate";

        public ICompressionSupport CreateCompression(string encoding)
        {
            if (DEFLATE.Equals(encoding, StringComparison.OrdinalIgnoreCase))
            {
                return new CompressionSupport(new ZlibChannelBufferDeflater(), new ZlibChannelBufferInflater());
            }

            return default;
        }
    }
}
