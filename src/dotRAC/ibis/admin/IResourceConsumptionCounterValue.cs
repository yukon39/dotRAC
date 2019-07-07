/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin
{
    public interface IResourceConsumptionCounterValue
    {
        string Object { get; }
        long CollectionTime { get; }
        long Duration { get; }
        long CpuTime { get; }
        long Memory { get; }
        long ReadBytes { get; }
        long WriteBytes { get; }
        long DurationDbms { get; }
        long DbmsBytes { get; }
        long DurationService { get; }
        long Calls { get; }
        long ActiveSessionCount { get; }
        long SessionCount { get; }
    }
}
