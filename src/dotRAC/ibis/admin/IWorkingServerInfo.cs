/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;

namespace dotRAC.ibis.admin
{
    public interface IWorkingServerInfo
    {
        Guid WorkingServerId { get; }
        ushort ClusterMainPort { get; }
        string Name { get; }
        string HostName { get; set; }
        ushort MainPort { get; set; }
        bool MainServer { get; set; }
        int InfoBasesPerWorkingProcessLimit { get; set; }
        long WorkingProcessMemoryLimit { get; set; }
        int ConnectionsPerWorkingProcessLimit { get; set; }
        bool DedicatedManagers { get; set; }
        List<IPortRangeInfo> PortRanges { get; set; }
        long SafeWorkingProcessesMemoryLimit { get; set; }
        long SafeCallMemoryLimit { get; set; }
    }
}
