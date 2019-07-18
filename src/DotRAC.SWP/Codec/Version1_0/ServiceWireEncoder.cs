/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotNetty.Buffers;
using DotRAC.SWP.Endpoints;

namespace DotRAC.SWP.Codec.Version1_0
{
    public class ServiceWireEncoder : IServiceWireEncoder
    {
        private readonly ServiceWireCodec codec;

        internal ServiceWireEncoder(ServiceWireCodec codec) => this.codec = codec;

        public void EncodeBoolean(IByteBuffer buffer, bool val) => buffer.WriteByte(val ? 1 : 0);

        public void EncodeByte(IByteBuffer buffer, byte val) => buffer.WriteByte(val);

        public void EncodeByteArray(IByteBuffer buffer, byte[] paramArrayOfByte)
        {
            throw new NotImplementedException();
        }

        public void EncodeChar(IByteBuffer buffer, int paramInt)
        {
            throw new NotImplementedException();
        }

        public void EncodeDouble(IByteBuffer buffer, double paramDouble)
        {
            throw new NotImplementedException();
        }

        public void EncodeEndpointId(IByteBuffer buffer, EndpointId paramEndpointId)
        {
            throw new NotImplementedException();
        }

        public void EncodeFloat(IByteBuffer buffer, float paramFloat)
        {
            throw new NotImplementedException();
        }

        public void EncodeInt(IByteBuffer buffer, int paramInt)
        {
            throw new NotImplementedException();
        }

        public void EncodeLong(IByteBuffer buffer, long paramLong)
        {
            throw new NotImplementedException();
        }

        public void EncodeNullableSize(IByteBuffer buffer, int paramInteger)
        {
            throw new NotImplementedException();
        }

        public void EncodeShort(IByteBuffer buffer, int paramInt)
        {
            throw new NotImplementedException();
        }

        public void EncodeSize(IByteBuffer buffer, int paramInt)
        {
            throw new NotImplementedException();
        }

        public void EncodeString(IByteBuffer buffer, string val)
        {


        }

        public void EncodeType(IByteBuffer buffer, ServiceWireType paramServiceWireType)
        {
            throw new NotImplementedException();
        }

        public void EncodeUuid(IByteBuffer buffer, Guid paramUUID)
        {
            throw new NotImplementedException();
        }
    }
}
