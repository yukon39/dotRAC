/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis.admin
{
    public interface IObjectLockInfo
    {
        Guid ConnectionId { get; }
        string LockDescr { get; }
        Guid LockedAt { get; }
        Guid Object { get; }
        Guid Sid { get; }
    }
}
