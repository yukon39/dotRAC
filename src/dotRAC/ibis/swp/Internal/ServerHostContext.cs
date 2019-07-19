/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using DotRAC.SWP.Codec;

namespace dotRAC.ibis.swp.Internal
{
    internal class ServerHostContext : ISwpV8ServerHostContext
    {
        private const int HASH_PRIME = 31;
        private readonly ServiceWireCodecVersion codecVersion;

        public ServiceWireCodecVersion CodecVersion => codecVersion;

        public ServerHostContext(ServiceWireCodecVersion codecVersion) => this.codecVersion = codecVersion;

        public override int GetHashCode() => HASH_PRIME + (int)codecVersion;

        public override bool Equals(object obj) => obj is ServerHostContext context ? codecVersion == context.codecVersion : false;
    }
}
