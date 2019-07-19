/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotNetty.Buffers;
using dotRAC.ibis.transport;
using DotRAC.Core;
using DotRAC.SWP.Codec;

namespace dotRAC.ibis.admin.Internal
{
    internal class ServiceMessageFormat : IV8MessageFormat
    {

        internal ServiceMessageFormat(IServiceWireCodec codec, IExceptionResolver throwableResolver, int version)
        {
            //this.codec = codec;
            //this.throwableResolver = throwableResolver;
            //this.version = version;
        }

        public IByteBuffer FormatMessage(IV8Message paramIV8Message)
        {
            throw new NotImplementedException();
        }

        public IByteBuffer FormatThrowable(Exception paramThrowable)
        {
            throw new NotImplementedException();
        }

        public IV8Message ParseMessage(IByteBuffer paramChannelBuffer)
        {
            throw new NotImplementedException();
        }

        public Exception ParseThrowable(IByteBuffer paramChannelBuffer)
        {
            throw new NotImplementedException();
        }
    }
}
