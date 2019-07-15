/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using DotNetty.Buffers;
using dotRAC.core;
using dotRAC.swp.codec;
using dotRAC.swp.endpoints;

namespace dotRAC.swp.format
{
    public static class WireFormatUtils
    {
        public static void FormatServiceId(IByteBuffer buffer, IServiceWireEncoder encoder, ServiceId serviceId)
        {
            if (serviceId == null)
            {
                encoder.EncodeString(buffer, null);
            }
            else
            {
                encoder.EncodeString(buffer, serviceId.Name);
                encoder.EncodeString(buffer, serviceId.Version);
            }
        }

        public static ServiceId ParseServiceId(IByteBuffer buffer, IServiceWireDecoder decoder)
        {
            string name = decoder.DecodeString(buffer);
            if (string.IsNullOrEmpty(name))
            {
                return default;
            }
            else
            {
                string version = decoder.DecodeString(buffer);
                return new ServiceId(name, version);
            }
        }

        public static void FormatException(IByteBuffer buffer, IServiceWireEncoder encoder, IExceptionResolver resolver, Exception exception)
        {
            if (exception == default)
            {
                encoder.EncodeString(buffer, null);
            }
            else
            {

                string className = resolver.ResolveName(exception);
                if (string.IsNullOrEmpty(className))
                {
                    throw new InvalidOperationException("Unresoved exception name");
                }

                encoder.EncodeString(buffer, className);
                encoder.EncodeString(buffer, exception.Message);

                //StackTraceElement[] stackTrace = exception.getStackTrace();

                encoder.EncodeSize(buffer, 0);
                //encoder.EncodeSize(buffer, stackTrace.length);
                //for (StackTraceElement element : stackTrace)
                //{
                //    encoder.encodeString(buffer, element.getClassName());
                //    encoder.encodeString(buffer, element.getMethodName());
                //    encoder.encodeString(buffer, element.getFileName());
                //    encoder.encodeInt(buffer, element.getLineNumber());
                //}
                FormatException(buffer, encoder, resolver, exception.InnerException);
            }
        }

        public static Exception ParseException(IByteBuffer buffer, IServiceWireDecoder decoder, IExceptionResolver resolver)
        {
            string className = decoder.DecodeString(buffer);
            if (string.IsNullOrEmpty(className))
            {
                return default;
            }

            string message = decoder.DecodeString(buffer);

            long size = decoder.DecodeSize(buffer);

            //StackTraceElement[] trace = new StackTraceElement[(int)size];

            for (int i = 0; i < size; i++)
            {
                string clazz = decoder.DecodeString(buffer);
                string method = decoder.DecodeString(buffer);
                string fileName = decoder.DecodeString(buffer);
                int line = decoder.DecodeInt(buffer);

                //trace[i] = new StackTraceElement(clazz, method, fileName, line);
            }

            Exception cause = ParseException(buffer, decoder, resolver);

            Exception resolvedException = resolver.ResolveException(className, message);

            ServiceWireUnknownException serviceWireUnknownException = default;
            if (resolvedException is ServiceWireUnknownException resolvedServiceWireExceprtion)
            {
                serviceWireUnknownException = resolvedServiceWireExceprtion;
            }
            else
            {
                serviceWireUnknownException = new ServiceWireUnknownException(className, message, cause);
            }

            //serviceWireUnknownException.setStackTrace(trace);

            return serviceWireUnknownException;
        }

        public static void FormatParameters(IByteBuffer buffer, IServiceWireEncoder encoder, IDictionary<string, object> parameters)
        {
            if (parameters == default)
            {
                encoder.EncodeNullableSize(buffer, 0);
            }
            else
            {
                encoder.EncodeNullableSize(buffer, parameters.Count);

                foreach (KeyValuePair<string, object> pair in parameters)
                {
                    encoder.EncodeString(buffer, pair.Key);
                    CodecUtils.EncodeTypedValue(buffer, encoder, pair.Value);
                }
            }
        }

        public static IDictionary<string, object> ParseParameters(IByteBuffer buffer, IServiceWireDecoder decoder)
        {
            int count = decoder.DecodeNullableSize(buffer);
            if (count == default)
            {
                return default;
            }

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            for (int i = 0; i < count; i++)
            {
                string key = decoder.DecodeString(buffer);
                object value = CodecUtils.DecodeTypedValue(buffer, decoder);
                parameters.Add(key, value);
            }

            return parameters;
        }
    }
}
