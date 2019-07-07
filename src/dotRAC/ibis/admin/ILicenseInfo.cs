/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin
{
    public interface ILicenseInfo
    {
        string FullName { get; }
        string FullPresentation { get; }
        bool IssuedByServer { get; }
        int LicenseType { get; }
        int MaxUsersAll { get; }
        int MaxUsersCur { get; }
        bool Net { get; }
        string RmngrAddress { get; }
        string RmngrPid { get; }
        int RmngrPort { get; }
        string Series { get; }
        string ShortPresentation { get; }
    }
}
