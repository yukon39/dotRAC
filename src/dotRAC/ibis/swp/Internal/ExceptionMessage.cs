/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Diagnostics.Contracts;
using DotNetty.Buffers;
using dotRAC.swp.endpoints;

namespace dotRAC.ibis.swp.Internal
{
    internal class ExceptionMessage : IServiceWireEndpointMessage
    {
        private readonly IByteBuffer cause;

        public IByteBuffer Cause => cause;

        public ExceptionMessage(IByteBuffer cause)
        {
            Contract.Requires(cause != default);
            this.cause = cause;
        }

        public override string ToString() => string.Format("ExceptionMessage [size={0}]", cause.ReadableBytes);
    }
}
