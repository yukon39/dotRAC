/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using dotRAC.ibis.service;

namespace dotRAC.ibis.admin
{
    public interface IAgentAdminConnection : IV8ServiceProxy
    {
        void AuthenticateAgent(string paramString1, string paramString2);
        void Authenticate(Guid paramUUID, string paramString1, string paramString2);
        void AddAuthentication(Guid paramUUID, string paramString1, string paramString2);

        List<IRegUserInfo> GetAgentAdmins();
        void RegAgentAdmin(IRegUserInfo paramIRegUserInfo);
        void UnregAgentAdmin(string paramString);

        List<IRegUserInfo> GetClusterAdmins(Guid paramUUID);
        void RegClusterAdmin(Guid paramUUID, IRegUserInfo paramIRegUserInfo);
        void UnregClusterAdmin(Guid paramUUID, string paramString);

        List<IClusterInfo> GetClusters();
        IClusterInfo GetClusterInfo(Guid paramUUID);
        Guid RegCluster(IClusterInfo paramIClusterInfo);
        void UnregCluster(Guid paramUUID);

        List<IClusterManagerInfo> GetClusterManagers(Guid paramUUID);
        IClusterManagerInfo GetClusterManagerInfo(Guid paramUUID1, Guid paramUUID2);

        List<IWorkingServerInfo> GetWorkingServers(Guid paramUUID);
        IWorkingServerInfo GetWorkingServerInfo(Guid paramUUID1, Guid paramUUID2);
        Guid RegWorkingServer(Guid paramUUID, IWorkingServerInfo paramIWorkingServerInfo);
        void UnregWorkingServer(Guid paramUUID1, Guid paramUUID2);

        List<IWorkingProcessInfo> GetWorkingProcesses(Guid paramUUID);
        IWorkingProcessInfo GetWorkingProcessInfo(Guid paramUUID1, Guid paramUUID2);
        List<IWorkingProcessInfo> GetServerWorkingProcesses(Guid paramUUID1, Guid paramUUID2);

        List<IClusterServiceInfo> GetClusterServices(Guid paramUUID);

        List<IInfoBaseInfoShort> GetInfoBasesShort(Guid paramUUID);
        IInfoBaseInfoShort GetInfoBaseShortInfo(Guid paramUUID1, Guid paramUUID2);
        void UpdateInfoBaseShort(Guid paramUUID, IInfoBaseInfoShort paramIInfoBaseInfoShort);

        List<IInfoBaseInfo> GetInfoBases(Guid paramUUID);
        IInfoBaseInfo GetInfoBaseInfo(Guid paramUUID1, Guid paramUUID2);
        Guid CreateInfoBase(Guid paramUUID, IInfoBaseInfo paramIInfoBaseInfo, int paramInt);
        void UpdateInfoBase(Guid paramUUID, IInfoBaseInfo paramIInfoBaseInfo);
        void DropInfoBase(Guid paramUUID1, Guid paramUUID2, int paramInt);

        List<IInfoBaseConnectionShort> GetInfoBaseConnectionsShort(Guid paramUUID1, Guid paramUUID2);
        List<IInfoBaseConnectionShort> GetConnectionsShort(Guid paramUUID);
        IInfoBaseConnectionShort GetConnectionInfoShort(Guid paramUUID1, Guid paramUUID2);

        List<IInfoBaseConnectionInfo> GetInfoBaseConnections(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3);
        void Disconnect(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3);

        List<ISessionInfo> GetSessions(Guid paramUUID);
        List<ISessionInfo> GetInfoBaseSessions(Guid paramUUID1, Guid paramUUID2);
        ISessionInfo GetSessionInfo(Guid paramUUID1, Guid paramUUID2);
        void TerminateSession(Guid paramUUID1, Guid paramUUID2);
        void TerminateSession(Guid paramUUID1, Guid paramUUID2, string paramString);

        List<IObjectLockInfo> GetLocks(Guid paramUUID);
        List<IObjectLockInfo> GetInfoBaseLocks(Guid paramUUID1, Guid paramUUID2);
        List<IObjectLockInfo> GetConnectionLocks(Guid paramUUID1, Guid paramUUID2);
        List<IObjectLockInfo> GetSessionLocks(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3);

        List<IAssignmentRuleInfo> GetAssignmentRules(Guid paramUUID1, Guid paramUUID2);
        IAssignmentRuleInfo GetAssignmentRuleInfo(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3);
        void ApplyAssignmentRules(Guid paramUUID, int paramInt);
        Guid RegAssignmentRule(Guid paramUUID1, Guid paramUUID2, IAssignmentRuleInfo paramIAssignmentRuleInfo, int paramInt);
        void UnregAssignmentRule(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3);


        List<ISecurityProfile> GetSecurityProfiles(Guid paramUUID);
        void CreateSecurityProfile(Guid paramUUID, ISecurityProfile paramISecurityProfile);
        void DropSecurityProfile(Guid paramUUID, string paramString);

        List<ISecurityProfileVirtualDirectory> GetSecurityProfileVirtualDirectories(Guid paramUUID, string paramString);
        void CreateSecurityProfileVirtualDirectory(Guid paramUUID, ISecurityProfileVirtualDirectory paramISecurityProfileVirtualDirectory);
        void DropSecurityProfileVirtualDirectory(Guid paramUUID, string paramString1, string paramString2);

        List<ISecurityProfileCOMClass> GetSecurityProfileComClasses(Guid paramUUID, string paramString);
        void CreateSecurityProfileComClass(Guid paramUUID, ISecurityProfileCOMClass paramISecurityProfileCOMClass);
        void DropSecurityProfileComClass(Guid paramUUID, string paramString1, string paramString2);

        List<ISecurityProfileAddIn> GetSecurityProfileAddIns(Guid paramUUID, string paramString);
        void CreateSecurityProfileAddIn(Guid paramUUID, ISecurityProfileAddIn paramISecurityProfileAddIn);
        void DropSecurityProfileAddIn(Guid paramUUID, string paramString1, string paramString2);

        List<ISecurityProfileExternalModule> GetSecurityProfileUnsafeExternalModules(Guid paramUUID, string paramString);
        void CreateSecurityProfileUnsafeExternalModule(Guid paramUUID, ISecurityProfileExternalModule paramISecurityProfileExternalModule);
        void DropSecurityProfileUnsafeExternalModule(Guid paramUUID, string paramString1, string paramString2);

        List<ISecurityProfileApplication> GetSecurityProfileApplications(Guid paramUUID, string paramString);
        void CreateSecurityProfileApplication(Guid paramUUID, ISecurityProfileApplication paramISecurityProfileApplication);
        void DropSecurityProfileApplication(Guid paramUUID, string paramString1, string paramString2);

        List<ISecurityProfileInternetResource> GetSecurityProfileInternetResources(Guid paramUUID, string paramString);
        void CreateSecurityProfileInternetResource(Guid paramUUID, ISecurityProfileInternetResource paramISecurityProfileInternetResource);
        void DropSecurityProfileInternetResource(Guid paramUUID, string paramString1, string paramString2);

        List<IResourceConsumptionCounter> GetResourceConsumptionCounters(Guid paramUUID);
        IResourceConsumptionCounter GetResourceConsumptionCounterInfo(Guid paramUUID, string paramString);
        void RegResourceConsumptionCounter(Guid paramUUID, IResourceConsumptionCounter paramIResourceConsumptionCounter);
        void UnregResourceConsumptionCounter(Guid paramUUID, string paramString);

        List<IResourceConsumptionLimit> GetResourceConsumptionLimits(Guid paramUUID);
        IResourceConsumptionLimit GetResourceConsumptionLimitInfo(Guid paramUUID, string paramString);
        void RegResourceConsumptionLimit(Guid paramUUID, IResourceConsumptionLimit paramIResourceConsumptionLimit);
        void UnregResourceConsumptionLimit(Guid paramUUID, string paramString);

        List<IResourceConsumptionCounterValue> GetResourceConsumptionCounterValues(Guid paramUUID, string paramString1, string paramString2);

        void InterruptCurrentServerCall(Guid paramUUID1, Guid paramUUID2, string paramString);
    }
}
