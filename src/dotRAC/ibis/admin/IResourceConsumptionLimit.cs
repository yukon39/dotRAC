/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin
{
    public interface IResourceConsumptionLimit
    {
        string Name { get; set; }
        string Counter { get; set; }
        int Action { get; set; }
        long Duration { get; set; }
        long CpuTime { get; set; }
        long Memory { get; set; }
        long ReadBytes { get; set; }
        long WriteBytes { get; set; }
        long DurationDbms { get; set; }
        long DbmsBytes { get; set; }
        long DurationService { get; set; }
        long Calls { get; set; }
        long ActiveSessionCount { get; set; }
        long SessionCount { get; set; }
        string Message { get; set; }
        string Description { get; set; }
    }
}
