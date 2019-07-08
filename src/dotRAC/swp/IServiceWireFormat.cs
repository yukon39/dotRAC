/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotRAC.core;
using dotRAC.swp.codec;
using dotRAC.swp.messages;

namespace dotRAC.swp
{
    public interface IServiceWireFormat
    {
        short Version { get; }

        short CodecVersion { get; }

        IExceptionResolver ExceptionResolver { get; }

        IServiceWireCodec CreateCodec();
        
        //void EncodeType(ChannelBuffer paramChannelBuffer, IServiceWireEncoder paramIServiceWireEncoder, MessageType paramMessageType);

        //MessageType DecodeType(ChannelBuffer paramChannelBuffer, IServiceWireDecoder paramIServiceWireDecoder);

        //void FormatMessage(ChannelBuffer paramChannelBuffer, IServiceWireEncoder paramIServiceWireEncoder, IServiceWireMessage paramIServiceWireMessage);

        //IServiceWireMessage ParseMessage(ChannelBuffer paramChannelBuffer, IServiceWireDecoder paramIServiceWireDecoder, MessageType paramMessageType);
    }
}
