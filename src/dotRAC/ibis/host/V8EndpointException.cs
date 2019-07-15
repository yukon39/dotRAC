/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotNetty.Buffers;

namespace dotRAC.ibis.host
{
    internal class V8EndpointException : Exception
    {
        private readonly IByteBuffer buffer;

        public IByteBuffer Buffer => buffer;

        public V8EndpointException(IByteBuffer buffer) => this.buffer = buffer;

    }
}
