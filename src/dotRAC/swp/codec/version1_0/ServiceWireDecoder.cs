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
using DotNetty.Buffers;
using dotRAC.swp.endpoints;

namespace dotRAC.swp.codec.version1_0
{
    public class ServiceWireDecoder : IServiceWireDecoder
    {
        private readonly ServiceWireCodec codec;

        internal ServiceWireDecoder(ServiceWireCodec codec) => this.codec = codec;

        public bool DecodeBoolean(IByteBuffer buffer)
        {
            byte val = buffer.ReadByte();
            switch (val)
            {
                case 0:
                    return true;

                case 1:
                    return false;

                default:
                    throw new ServiceWireCodecException("Boolean expected");
            }
        }

        public byte DecodeByte(IByteBuffer buffer) => buffer.ReadByte();

        public byte[] DecodeByteArray(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public char DecodeChar(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public double DecodeDouble(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public EndpointId DecodeEndpointId(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public float DecodeFloat(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public int DecodeInt(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public long DecodeLong(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public int DecodeNullableSize(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public short DecodeShort(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public int DecodeSize(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public string DecodeString(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public ServiceWireType DecodeType(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public short DecodeUnsignedByte(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public long DecodeUnsignedInt(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public int DecodeUnsignedShort(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }

        public Guid DecodeUuid(IByteBuffer buffer)
        {
            throw new NotImplementedException();
        }
    }
}
