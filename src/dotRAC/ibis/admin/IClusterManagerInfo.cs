/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis.admin
{
    public interface IClusterManagerInfo
    {
        Guid ClusterManagerId { get; }
        string Descr { get; }
        string HostName { get; }
        int MainManager { get; }
        ushort MainPort { get; }
        string Pid { get; }
    }
}
