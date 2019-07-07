/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin
{
    public interface ISecurityProfileVirtualDirectory
    {
        string SPName { get; set; }
        string Alias { get; set; }
        string Descr { get; set; }
        string PhysicalPath { get; set; }
        bool AllowedRead { get; set; }
        bool AllowedWrite { get; set; }
    }
}
