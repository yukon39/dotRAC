/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis.admin
{
    public interface IClusterInfo
    {
        Guid ClusterId { get; }
        string Name { get; set; }
        string HostName { get; set; }
        ushort MainPort { get; set; }
        int ExpirationTimeout { get; set; }
        int LifeTimeLimit { get; set; }
        int MaxMemorySize { get; set; }
        int MaxMemoryTimeLimit { get; set; }
        int SecurityLevel { get; set; }
        int SessionFaultToleranceLevel { get; set; }
        int LoadBalancingMode { get; set; }
        int ClusterRecyclingErrorsCountThreshold { get; set; }
        bool ClusterRecyclingKillProblemProcesses { get; set; }
    }
}
