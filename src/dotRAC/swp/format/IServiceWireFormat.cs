/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using dotRAC.core;
using dotRAC.swp.codec;

namespace dotRAC.swp.format
{
    public interface IServiceWireFormat
    {
        ServiceWireFormatVersion Version { get; }

        ServiceWireCodecVersion CodecVersion { get; }

        IExceptionResolver ExceptionResolver { get; }

        IServiceWireCodec CreateCodec();

        //void EncodeType(ChannelBuffer paramChannelBuffer, IServiceWireEncoder paramIServiceWireEncoder, MessageType paramMessageType);

        //MessageType DecodeType(ChannelBuffer paramChannelBuffer, IServiceWireDecoder paramIServiceWireDecoder);

        //void FormatMessage(ChannelBuffer paramChannelBuffer, IServiceWireEncoder paramIServiceWireEncoder, IServiceWireMessage paramIServiceWireMessage);

        //IServiceWireMessage ParseMessage(ChannelBuffer paramChannelBuffer, IServiceWireDecoder paramIServiceWireDecoder, MessageType paramMessageType);
    }
}
