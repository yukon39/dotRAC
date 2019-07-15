/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using DotNetty.Buffers;

namespace dotRAC.swp.endpoints
{
    public interface IServiceWireEndpointFormat
    {
        IByteBuffer FormatMessage(IServiceWireEndpointMessage paramIServiceWireEndpointMessage);

        IServiceWireEndpointMessage ParseMessage(IByteBuffer buffer);
    }
}
