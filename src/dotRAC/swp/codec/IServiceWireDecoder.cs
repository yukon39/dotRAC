/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotNetty.Buffers;
using dotRAC.swp.endpoints;

namespace dotRAC.swp.codec
{
    public interface IServiceWireDecoder
    {
        bool DecodeBoolean(IByteBuffer buffer);
        byte DecodeByte(IByteBuffer buffer);
        short DecodeUnsignedByte(IByteBuffer buffer);
        char DecodeChar(IByteBuffer buffer);
        short DecodeShort(IByteBuffer buffer);
        int DecodeUnsignedShort(IByteBuffer buffer);
        int DecodeInt(IByteBuffer buffer);
        long DecodeUnsignedInt(IByteBuffer buffer);
        long DecodeLong(IByteBuffer buffer);
        float DecodeFloat(IByteBuffer buffer);
        double DecodeDouble(IByteBuffer buffer);
        int DecodeSize(IByteBuffer buffer);
        int DecodeNullableSize(IByteBuffer buffer);
        string DecodeString(IByteBuffer buffer);
        Guid DecodeUuid(IByteBuffer buffer);
        ServiceWireType DecodeType(IByteBuffer buffer);
        EndpointId DecodeEndpointId(IByteBuffer buffer);
        byte[] DecodeByteArray(IByteBuffer buffer);
    }
}
