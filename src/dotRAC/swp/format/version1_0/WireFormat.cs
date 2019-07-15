/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotNetty.Buffers;
using dotRAC.core;
using dotRAC.swp.codec;
using dotRAC.swp.messages;

namespace dotRAC.swp.format.version1_0
{
    public class ServiceWireFormat : IServiceWireFormat
    {
        private static readonly IExceptionResolver DefaultExceptionResolver = new ExceptionResolverChain(
                new ServiceWireExceptionResolver(), new DefaultExceptionResolver());

        private static readonly IServiceWireMessageFormat CONNECT_FORMAT = new ConnectMessageFormat();
        private static readonly IServiceWireMessageFormat CONNECT_ACK_FORMAT = new ConnectAckMessageFormat();
        //private static readonly IServiceWireMessageFormat START_TLS_FORMAT = new StartTlsMessageFormat();
        //private static readonly IServiceWireMessageFormat DISCONNECT_FORMAT = new DisconnectMessageFormat(DefaultExceptionResolver);
        //private static readonly IServiceWireMessageFormat SASL_NEGOTIATE_FORMAT = new SaslNegotiateMessageFormat();
        //private static readonly IServiceWireMessageFormat SASL_AUTH_FORMAT = new SaslAuthMessageFormat();
        //private static readonly IServiceWireMessageFormat SASL_CHALLENGE_FORMAT = new SaslChallengeMessageFormat();
        //private static readonly IServiceWireMessageFormat SASL_SUCCESS_FORMAT = new SaslSuccessMessageFormat();
        //private static readonly IServiceWireMessageFormat SASL_FAILURE_FORMAT = new SaslFailureMessageFormat(DefaultExceptionResolver);
        //private static readonly IServiceWireMessageFormat SASL_ABORT_FORMAT = new SaslAbortMessageFormat();
        //private static readonly IServiceWireMessageFormat ENDPOINT_OPEN_FORMAT = new EndpointOpenMessageFormat();
        //private static readonly IServiceWireMessageFormat ENDPOINT_OPEN_ACK_FORMAT = new EndpointOpenAckMessageFormat();
        //private static readonly IServiceWireMessageFormat ENDPOINT_CLOSE_FORMAT = new EndpointCloseMessageFormat();
        //private static readonly IServiceWireMessageFormat KEEP_ALIVE_FORMAT = new KeepAliveMessageFormat();

        private readonly IServiceWireCodecFactory codecFactory;
        private readonly ServiceWireCodecVersion codecVersion;
        private readonly IExceptionResolver exceptionResolver;
        private readonly IServiceWireMessageFormat endpointFailureFormat;

        public ServiceWireFormatVersion Version => ServiceWireFormatVersion.Version1_0;

        public ServiceWireCodecVersion CodecVersion => codecVersion;

        public IExceptionResolver ExceptionResolver => exceptionResolver;

        public ServiceWireFormat(
            IServiceWireCodecFactory codecFactory, ServiceWireCodecVersion codecVersion, IExceptionResolver exceptionResolver)
        {
            this.codecFactory = codecFactory;
            this.codecVersion = codecVersion;

            if (exceptionResolver == null || exceptionResolver is ServiceWireExceptionResolver)
            {
                this.exceptionResolver = DefaultExceptionResolver;
                //this.endpointFailureFormat = new EndpointFailureMessageFormat(DefaultExceptionResolver);
            }
            else
            {
                this.exceptionResolver = exceptionResolver;
                //this.endpointFailureFormat = new EndpointFailureMessageFormat(new ExceptionResolverChain(exceptionResolver, DefaultExceptionResolver));
            }
        }


        public IServiceWireCodec CreateCodec() => codecFactory.CreateCodec(codecVersion);

        public void EncodeType(IByteBuffer buffer, IServiceWireEncoder encoder, MessageType type) => encoder.EncodeByte(buffer, (byte)type);

        public MessageType DecodeType(IByteBuffer buffer, IServiceWireDecoder decoder)
        {
            byte code = decoder.DecodeByte(buffer);

            if (Enum.IsDefined(typeof(MessageType), code))
            {
                return (MessageType)code;
            }
            else
            {
                throw new ServiceWireCodecException("Message type expected!");
            }
        }

        public void FormatMessage(IByteBuffer buffer, IServiceWireEncoder encoder, IServiceWireMessage msg)
        {
            IServiceWireMessageFormat messageFormat = GetFormat(msg.Type);

            try
            {
                messageFormat.FormatMessage(buffer, encoder, msg);
            }
            catch (ServiceWireCodecException e)
            {

                throw new ServiceWireFormatException("Message format error", e);
            }
        }

        public IServiceWireMessage ParseMessage(IByteBuffer buffer, IServiceWireDecoder decoder, MessageType messageType)
        {
            IServiceWireMessageFormat messageFormat = GetFormat(messageType);

            try
            {
                return messageFormat.ParseMessage(buffer, decoder);
            }
            catch (ServiceWireCodecException e)
            {

                throw new ServiceWireFormatException("Message format error", e);
            }
        }

        private IServiceWireMessageFormat GetFormat(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.CONNECT:
                    return CONNECT_FORMAT;

                case MessageType.CONNECT_ACK:
                    return CONNECT_ACK_FORMAT;

                //case MessageType.START_TLS:
                //    return START_TLS_FORMAT;

                //case MessageType.DISCONNECT:
                //    return DISCONNECT_FORMAT;

                //case MessageType.SASL_NEGOTIATE:
                //    return SASL_NEGOTIATE_FORMAT;

                //case MessageType.SASL_AUTH:
                //    return SASL_AUTH_FORMAT;

                //case MessageType.SASL_CHALLENGE:
                //    return SASL_CHALLENGE_FORMAT;

                //case MessageType.SASL_SUCCESS:
                //    return SASL_SUCCESS_FORMAT;

                //case MessageType.SASL_FAILURE:
                //    return SASL_FAILURE_FORMAT;

                //case MessageType.SASL_ABORT:
                //    return SASL_ABORT_FORMAT;

                //case MessageType.ENDPOINT_OPEN:
                //    return ENDPOINT_OPEN_FORMAT;

                //case MessageType.ENDPOINT_OPEN_ACK:
                //    return ENDPOINT_OPEN_ACK_FORMAT;

                //case MessageType.ENDPOINT_CLOSE:
                //    return ENDPOINT_CLOSE_FORMAT;

                //case MessageType.ENDPOINT_FAILURE:
                //    return endpointFailureFormat;

                //case MessageType.KEEP_ALIVE:
                //    return KEEP_ALIVE_FORMAT;

                default:
                    throw new InvalidOperationException("Unknown message type!");
            }
        }
    }
}
