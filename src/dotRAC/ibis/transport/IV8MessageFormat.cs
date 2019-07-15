/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotNetty.Buffers;

namespace dotRAC.ibis.transport
{
    public interface IV8MessageFormat
    {
        IByteBuffer FormatMessage(IV8Message paramIV8Message);

        IV8Message ParseMessage(IByteBuffer paramChannelBuffer);

        IByteBuffer FormatThrowable(Exception paramThrowable);

        Exception ParseThrowable(IByteBuffer paramChannelBuffer);
    }
}
