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
    public interface IWorkingProcessInfo
    {
        string getPid { get; }
        Guid WorkingProcessId { get; }
        string HostName { get; }
        ushort MainPort { get; }
        bool Enabled { get; }
        int Running { get; }
        int Use { get; }

        double AvgBackCallTime { get; }
        double AvgCallTime { get; }
        double AvgDBCallTime { get; }
        double AvgLockCallTime { get; }
        double AvgServerCallTime { get; }
        double AvgThreads { get; }

        int Capacity { get; }
        int Connections { get; }
        List<ILicenseInfo> License { get; }
        long MemoryExcessTime { get; }
        int MemorySize { get; }
        int SelectionSize { get; }
        DateTime StartedAt { get; }
        int AvailablePerfomance { get; }
    }
}
