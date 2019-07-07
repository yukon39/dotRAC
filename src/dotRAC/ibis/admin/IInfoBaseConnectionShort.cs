/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis.admin
{
    public interface IInfoBaseConnectionShort
    {
        Guid InfoBaseConnectionId { get; }
        string Application { get; }
        int BlockedByLs { get; }
        DateTime ConnectedAt { get; }
        int ConnId { get; }
        string Host { get; }
        Guid InfoBaseId { get; }
        Guid WorkingProcessId { get; }
        int SessionNumber { get; }
    }
}
