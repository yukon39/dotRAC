/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis.admin
{
    public interface IInfoBaseInfo
    {
        Guid InfoBaseId { get; }
        string Name { get; set; }
        string Descr { get; set; }
        int SecurityLevel { get; }
        int DateOffset { get; set; }
        string Dbms { get; set; }
        string DbName { get; set; }
        string DbPassword { get; set; }
        string DbServerName { get; set; }
        string DbUser { get; set; }
        bool SessionsDenied { get; set; }
        DateTime DeniedFrom { get; set; }
        DateTime DeniedTo { get; set; }
        string DeniedMessage { get; set; }
        string DeniedParameter { get; set; }
        string PermissionCode { get; set; }
        string Locale { get; set; }
        bool ScheduledJobsDenied { get; set; }
        int LicenseDistributionAllowed { get; set; }
        string ExternalSessionManagerConnectionString { get; set; }
        bool ExternalSessionManagerRequired { get; set; }
        string SecurityProfileName { get; set; }
        string SafeModeSecurityProfileName { get; set; }
    }
}
