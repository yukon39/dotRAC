/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin
{
    public interface ISecurityProfileCOMClass
    {
        string SPName { get; set; }
        string Name { get; set; }
        string Descr { get; set; }
        string FileName { get; set; }
        string ObjectUuid { get; set; }
        string ComputerName { get; set; }
    }
}
