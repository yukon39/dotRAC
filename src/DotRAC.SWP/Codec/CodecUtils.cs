/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Linq;
using DotNetty.Buffers;
using DotRAC.SWP.Endpoints;

namespace DotRAC.SWP.Codec
{
    public static class CodecUtils
    {
        public static void EncodeStringArray(IByteBuffer buffer, IServiceWireEncoder encoder, string[] array)
        {
            encoder.EncodeSize(buffer, array.Count());
            Array.ForEach(array, x => encoder.EncodeString(buffer, x));
        }

        public static string[] DecodeStringArray(IByteBuffer buffer, IServiceWireDecoder decoder)
        {
            long length = decoder.DecodeSize(buffer);
            string[] array = new string[(int)length];
            for (int idx = 0; idx < length; idx++)
            {
                array[idx] = decoder.DecodeString(buffer);
            }

            return array;
        }

        public static void EncodeTypedValue(IByteBuffer buffer, IServiceWireEncoder encoder, object val)
        {
            if (val == null)
            {
                encoder.EncodeType(buffer, default);
            }
            else
            {
                ServiceWireType type = DetectType(val.GetType());
                if (type == default)
                {
                    throw new InvalidOperationException("Unsupported type for encoding");
                }

                encoder.EncodeType(buffer, type);

                switch (type)
                {
                    case ServiceWireType.BOOLEAN:
                        encoder.EncodeBoolean(buffer, (bool)val);
                        return;

                    case ServiceWireType.BYTE:
                        encoder.EncodeByte(buffer, (byte)val);
                        return;

                    case ServiceWireType.SHORT:
                        encoder.EncodeShort(buffer, (short)val);
                        return;

                    case ServiceWireType.INT:
                        encoder.EncodeInt(buffer, (int)val);
                        return;

                    case ServiceWireType.LONG:
                        encoder.EncodeLong(buffer, (long)val);
                        return;

                    case ServiceWireType.STRING:
                        encoder.EncodeString(buffer, (string)val);
                        return;

                    case ServiceWireType.TYPE:
                        encoder.EncodeType(buffer, (ServiceWireType)val);
                        return;

                    case ServiceWireType.ENDPOINT_ID:
                        encoder.EncodeEndpointId(buffer, (EndpointId)val);
                        return;

                    default:
                        throw new InvalidOperationException("Unsupported type for encoding");
                }
            }
        }

        public static object DecodeTypedValue(IByteBuffer buffer, IServiceWireDecoder decoder)
        {
            ServiceWireType type = decoder.DecodeType(buffer);
            if (type == default)
            {
                return null;
            }

            switch (type)
            {
                case ServiceWireType.BOOLEAN:
                    return decoder.DecodeBoolean(buffer);

                case ServiceWireType.BYTE:
                    return decoder.DecodeByte(buffer);

                case ServiceWireType.SHORT:
                    return decoder.DecodeShort(buffer);

                case ServiceWireType.INT:
                    return decoder.DecodeInt(buffer);

                case ServiceWireType.LONG:
                    return decoder.DecodeLong(buffer);

                case ServiceWireType.STRING:
                    return decoder.DecodeString(buffer);

                case ServiceWireType.TYPE:
                    return decoder.DecodeType(buffer);

                case ServiceWireType.ENDPOINT_ID:
                    return decoder.DecodeEndpointId(buffer);

                default:
                    throw new ServiceWireCodecException("Unexpected data type");
            }
        }

        public static ServiceWireType DetectType(Type type)
        {
            if (type == typeof(bool))
            {
                return ServiceWireType.BOOLEAN;
            }
            else if (type == typeof(byte))
            {
                return ServiceWireType.BYTE;
            }
            else if (type == typeof(short))
            {
                return ServiceWireType.SHORT;
            }
            else if (type == typeof(int))
            {
                return ServiceWireType.INT;
            }
            else if (type == typeof(long))
            {
                return ServiceWireType.LONG;
            }
            else if (type == typeof(string))
            {
                return ServiceWireType.STRING;
            }
            else if (type == typeof(ServiceWireType))
            {
                return ServiceWireType.TYPE;
            }
            else if (type == typeof(EndpointId))
            {
                return ServiceWireType.ENDPOINT_ID;
            }
            else
            {
                return default;
            }
        }
    }
}
