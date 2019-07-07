/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin
{
    public class LicenseInfo : ILicenseInfo
    {
        public string FullName { get; }
        public string FullPresentation { get; }
        public bool IssuedByServer { get; }
        public int LicenseType { get; }
        public int MaxUsersAll { get; }
        public int MaxUsersCur { get; }
        public bool Net { get; }
        public string RmngrAddress { get; }
        public string RmngrPid { get; }
        public int RmngrPort { get; }
        public string Series { get; }
        public string ShortPresentation { get; }

        internal LicenseInfo() { }

        public override string ToString()
             => "LicenseInfo [fullName=" + FullName
                + ", fullPresentation=" + FullPresentation
                + ", issuedByServer=" + IssuedByServer
                + ", licenseType=" + LicenseType
                + ", maxUsersAll=" + MaxUsersAll
                + ", maxUsersCur=" + MaxUsersCur
                + ", net=" + Net
                + ", rmngrAddress=" + RmngrAddress
                + ", rmngrPid=" + RmngrPid
                + ", rmngrPort=" + RmngrPort
                + ", series=" + Series
                + ", shortPresentation=" + ShortPresentation + "]";

    }
}
