/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Collections.Generic;
using dotRAC.ibis.transport;

namespace dotRAC.ibis.client
{
    public interface IV8Connection : IV8Lifecycle<IV8ConnectionContext>
    {
        IV8Transport StartService(string paramString1, List<string> paramList, string paramString2, IV8MessageFormatFactory paramIV8MessageFormatFactory);

        bool IsSame(IV8Connection paramIV8Connection);

        void Start(IV8ConnectionContext context);
    }
}
