/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotNetty.Buffers;

namespace dotRAC.ibis.host
{
    public interface IV8ServerHost : IV8Lifecycle<IV8ServerHostContext>
    {
        Guid StartService(string paramString1, string paramString2);

        void StopService(Guid paramUUID);

        IByteBuffer ProcessMessage(Guid paramUUID, IByteBuffer paramChannelBuffer);
    }
}
