/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotNetty.Buffers;
using DotRAC.SWP.Endpoints;

namespace DotRAC.SWP.Codec
{
    public interface IServiceWireEncoder
    {
        void EncodeBoolean(IByteBuffer buffer, bool paramBoolean);
        void EncodeByte(IByteBuffer buffer, byte paramInt);
        void EncodeChar(IByteBuffer buffer, int paramInt);
        void EncodeShort(IByteBuffer buffer, int paramInt);
        void EncodeInt(IByteBuffer buffer, int paramInt);
        void EncodeLong(IByteBuffer buffer, long paramLong);
        void EncodeFloat(IByteBuffer buffer, float paramFloat);
        void EncodeDouble(IByteBuffer buffer, double paramDouble);
        void EncodeSize(IByteBuffer buffer, int paramInt);
        void EncodeNullableSize(IByteBuffer buffer, int paramInteger);
        void EncodeString(IByteBuffer buffer, string paramString);
        void EncodeUuid(IByteBuffer buffer, Guid paramUUID);
        void EncodeType(IByteBuffer buffer, ServiceWireType paramServiceWireType);
        void EncodeEndpointId(IByteBuffer buffer, EndpointId paramEndpointId);
        void EncodeByteArray(IByteBuffer buffer, byte[] paramArrayOfByte);
    }
}
