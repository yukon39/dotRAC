/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin
{
    public interface IRegUserInfo
    {
        string Name { get; set; }
        string Desc { get; set; }
        string Password { get; set; }
        bool PasswordAuthAllowed { get; set; }
        bool SysAuthAllowed { get; set; }
        string SysUserName { get; set; }
    }
}
