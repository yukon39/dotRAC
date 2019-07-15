/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using DotNetty.Buffers;
using dotRAC.core;
using dotRAC.swp.codec;
using dotRAC.swp.messages;

namespace dotRAC.swp.format
{
    public interface IServiceWireFormat
    {
        ServiceWireFormatVersion Version { get; }

        ServiceWireCodecVersion CodecVersion { get; }

        IExceptionResolver ExceptionResolver { get; }

        IServiceWireCodec CreateCodec();

        void EncodeType(IByteBuffer buffer, IServiceWireEncoder paramIServiceWireEncoder, MessageType paramMessageType);

        MessageType DecodeType(IByteBuffer buffer, IServiceWireDecoder paramIServiceWireDecoder);

        void FormatMessage(IByteBuffer buffer, IServiceWireEncoder paramIServiceWireEncoder, IServiceWireMessage paramIServiceWireMessage);

        IServiceWireMessage ParseMessage(IByteBuffer buffer, IServiceWireDecoder paramIServiceWireDecoder, MessageType paramMessageType);
    }
}
