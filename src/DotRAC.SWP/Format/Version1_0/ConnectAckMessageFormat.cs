/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Collections.Generic;
using System.Diagnostics.Contracts;
using DotNetty.Buffers;
using DotRAC.SWP.Codec;
using DotRAC.SWP.Messages;

namespace DotRAC.SWP.Format.Version1_0
{
    internal class ConnectAckMessageFormat : IServiceWireMessageFormat
    {
        public void FormatMessage(IByteBuffer buffer, IServiceWireEncoder encoder, IServiceWireMessage msg)
        {
            Contract.Requires(msg is ConnectAckMessage);

            ConnectAckMessage message = (ConnectAckMessage)msg;
            WireFormatUtils.FormatParameters(buffer, encoder, message.Parameters);
        }

        public IServiceWireMessage ParseMessage(IByteBuffer buffer, IServiceWireDecoder decoder)
        {
            IDictionary<string, object> parameters = WireFormatUtils.ParseParameters(buffer, decoder);
            return new ConnectAckMessage(parameters);
        }
    }
}
