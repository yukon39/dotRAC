﻿/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.host
{
    public interface IV8ServerHostProvider
    {
        IV8ServerHost AcquireHost(IV8ServerHostContext paramIV8ServerHostContext);

        void ReleaseHost(IV8ServerHost paramIV8ServerHost);
    }
}
