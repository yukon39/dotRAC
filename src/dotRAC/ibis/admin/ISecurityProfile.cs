/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin
{
    public interface ISecurityProfile
    {
        string SPName { get; set; }
        string Descr { get; set; }
        bool FileSystemFullAccess { get; set; }
        bool ComUseFullAccess { get; set; }
        bool AddInUseFullAccess { get; set; }
        bool ExternalAppFullAccess { get; set; }
        bool InternetUseFullAccess { get; set; }
        bool SafeModeProfile { get; set; }
        bool PrivilegedModeInSafeModeAllowed { get; set; }
        bool UnsafeExternalModuleFullAccess { get; set; }
        bool CryptographyAllowed { get; set; }
        bool RightExtension { get; set; }
        string RightExtensionDefinitionRoles { get; set; }
        bool AllModulesExtension { get; set; }
        string ModulesAvailableForExtension { get; set; }
        string ModulesNotAvailableForExtension { get; set; }
    }
}
