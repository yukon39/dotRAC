/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.swp
{
    public interface IServiceWireFormatFactory
    {
        short GetDefaultVersion();
        IServiceWireFormat CreateFormat();
        IServiceWireFormat CreateFormat(short paramShort1, short paramShort2);
    }
}
