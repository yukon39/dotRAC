/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin
{
    public interface IResourceConsumptionCounter
    {
        string Name { get; set; }
        long CollectionTime { get; set; }
        int Group { get; set; }
        int FilterType { get; set; }
        string FilterValue { get; set; }
        bool AnalyzeDuration { get; set; }
        bool AnalyzeCpuTime { get; set; }
        bool AnalyzeMemory { get; set; }
        bool AnalyzeReadBytes { get; set; }
        bool AnalyzeWriteBytes { get; set; }
        bool AnalyzeDurationDbms { get; set; }
        bool AnalyzeDbmsBytes { get; set; }
        bool AnalyzeDurationService { get; set; }
        bool AnalyzeCalls { get; set; }
        bool AnalyzeActiveSessionCount { get; set; }
        bool AnalyzeSessionCount { get; set; }
        string Description { get; set; }
    }
}
