/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Diagnostics.Contracts;
using DotNetty.Buffers;
using DotRAC.SWP.Endpoints;

namespace dotRAC.ibis.swp.Internal
{
    internal class EndpointMessage : IServiceWireEndpointMessage
    {
        private readonly IByteBuffer message;

        public IByteBuffer Message => message;

        public EndpointMessage(IByteBuffer message)
        {
            Contract.Requires(message != default);
            this.message = message;
        }

        public override string ToString() => string.Format("EndpointMessage [size={0}]", message.ReadableBytes);
    }
}
