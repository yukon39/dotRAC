/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis.admin
{
    public interface IAgentAdminConnection
    {
        void AuthenticateAgent(string paramString1, string paramString2);
        void Authenticate(Guid paramUUID, string paramString1, string paramString2);
        void AddAuthentication(Guid paramUUID, string paramString1, string paramString2);
    }
}
