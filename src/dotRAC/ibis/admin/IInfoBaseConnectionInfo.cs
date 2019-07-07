/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis.admin
{
    public interface IInfoBaseConnectionInfo
    {
        Guid InfoBaseConnectionId { get; }
        string AppId { get; }
        int BlockedByDbms { get; }
        long BytesAll { get; }
        long BytesLast5Min { get; }
        long CallsAll { get; }
        long CallsLast5Min { get; }
        DateTime ConnectedAt { get; }
        int ConnId { get; }
        int DbConnMode { get; }
        long DbmsBytesAll { get; }
        long DbmsBytesLast5Min { get; }
        string DbProcInfo { get; }
        int DbProcTook { get; }
        DateTime DbProcTookAt { get; }
        int DurationAll { get; }
        int DurationAllDbms { get; }
        int DurationCurrent { get; }
        int DurationCurrentDbms { get; }
        long DurationLast5Min { get; }
        long DurationLast5MinDbms { get; }
        string HostName { get; }
        int IbConnMode { get; }
        int ThreadMode { get; }
        string UserName { get; }
        long MemoryCurrent { get; }
        long MemoryLast5Min { get; }
        long MemoryTotal { get; }
        long ReadBytesCurrent { get; }
        long ReadBytesLast5Min { get; }
        long ReadBytesTotal { get; }
        long WriteBytesCurrent { get; }
        long WriteBytesLast5Min { get; }
        long WriteBytesTotal { get; }
    }
}
