/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotNetty.Buffers;
using dotRAC.swp.codec;
using dotRAC.swp.endpoints;
using dotRAC.swp.format;

namespace dotRAC.ibis.swp.Internal
{
    internal class EndpointFormat : IServiceWireEndpointFormat
    {
        private const byte VOID_MESSAGE = 0x00;
        private const byte MESSAGE = 0x01;
        private const byte EXCEPTION = 0xFF;
        private readonly IServiceWireCodec codec;

        internal EndpointFormat(IServiceWireCodec codec) { this.codec = codec; }

        public IByteBuffer FormatMessage(IServiceWireEndpointMessage msg)
        {
            if (msg is VoidMessage)
            {
                IByteBuffer header = Unpooled.Buffer(1);

                codec.Encoder.EncodeByte(header, VOID_MESSAGE);

                return header;
            }
            else if (msg is EndpointMessage endpointMessage)
            {
                IByteBuffer header = Unpooled.Buffer(1);

                codec.Encoder.EncodeByte(header, MESSAGE);

                return Unpooled.WrappedBuffer(new IByteBuffer[] { header, endpointMessage.Message });
            }
            else if (msg is ExceptionMessage message)
            {

                IByteBuffer header = Unpooled.Buffer(1);

                codec.Encoder.EncodeByte(header, EXCEPTION);

                return Unpooled.WrappedBuffer(new IByteBuffer[] { header, message.Cause });
            }
            else
            {
                throw new ArgumentException("Unsupported message");
            }
        }

        public IServiceWireEndpointMessage ParseMessage(IByteBuffer buffer)
        {
            byte type = codec.Decoder.DecodeByte(buffer);
            switch (type)
            {

                case VOID_MESSAGE:
                    return new VoidMessage();

                case MESSAGE:
                    return new EndpointMessage(buffer.Slice());

                case EXCEPTION:
                    return new ExceptionMessage(buffer.Slice());

                default:
                    throw new ServiceWireFormatException("Unsupported message");
            }
        }
    }
}
