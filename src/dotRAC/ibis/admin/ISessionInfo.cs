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
    public interface ISessionInfo
    {
        Guid Sid { get; }
        string AppId { get; }
        int BlockedByDbms { get; }
        int BlockedByLs { get; }
        long BytesAll { get; }
        long BytesLast5Min { get; }
        int CallsAll { get; }
        long CallsLast5Min { get; }
        Guid ConnectionId { get; }
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
        string Host { get; }
        Guid InfoBaseId { get; }
        DateTime LastActiveAt { get; }
        List<ILicenseInfo> Licenses { get; }
        string Locale { get; }
        Guid WorkingProcessId { get; }
        int SessionId { get; }
        DateTime StartedAt { get; }
        string UserName { get; }
        bool Hibernate { get; }
        int PassiveSessionHibernateTime { get; }
        int HibernateSessionTerminationTime { get; }
        long MemoryCurrent { get; }
        long MemoryLast5Min { get; }
        long MemoryTotal { get; }
        long ReadBytesCurrent { get; }
        long ReadBytesLast5Min { get; }
        long ReadBytesTotal { get; }
        long WriteBytesCurrent { get; }
        long WriteBytesLast5Min { get; }
        long WriteBytesTotal { get; }
        int DurationCurrentService { get; }
        long DurationLast5MinService { get; }
        int DurationAllService { get; }
        string CurrentServiceName { get; }
        long CpuTimeCurrent { get; }
        long CpuTimeLast5Min { get; }
    }
}
