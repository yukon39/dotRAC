/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using dotRAC.core;
using dotRAC.ibis.service;
using dotRAC.ibis.swp;
using dotRAC.ibis.transport;
using dotRAC.swp.codec;

namespace dotRAC.ibis.admin.Internal
{
    public class AgentAdminConnectionProxy : AbstractServiceProxy, IAgentAdminConnection
    {
        private static readonly IExceptionResolver ExceptionResolver = new AgentAdminExceptionResolver();

        public static readonly List<string> ServiceVersions = new List<string>(new string[] { "3.0", "4.0", "5.0", "6.0" });
        public static readonly IV8MessageFormatFactory FormatFactory = new ServiceManagerFormatFactory(ExceptionResolver);
        
        public AgentAdminConnectionProxy(IV8Transport transport) : base(transport) { }

        public void AddAuthentication(Guid paramUUID, string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public void ApplyAssignmentRules(Guid paramUUID, int paramInt)
        {
            throw new NotImplementedException();
        }

        public void Authenticate(Guid paramUUID, string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public void AuthenticateAgent(string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public Guid CreateInfoBase(Guid paramUUID, IInfoBaseInfo paramIInfoBaseInfo, int paramInt)
        {
            throw new NotImplementedException();
        }

        public void CreateSecurityProfile(Guid paramUUID, ISecurityProfile paramISecurityProfile)
        {
            throw new NotImplementedException();
        }

        public void CreateSecurityProfileAddIn(Guid paramUUID, ISecurityProfileAddIn paramISecurityProfileAddIn)
        {
            throw new NotImplementedException();
        }

        public void CreateSecurityProfileApplication(Guid paramUUID, ISecurityProfileApplication paramISecurityProfileApplication)
        {
            throw new NotImplementedException();
        }

        public void CreateSecurityProfileComClass(Guid paramUUID, ISecurityProfileCOMClass paramISecurityProfileCOMClass)
        {
            throw new NotImplementedException();
        }

        public void CreateSecurityProfileInternetResource(Guid paramUUID, ISecurityProfileInternetResource paramISecurityProfileInternetResource)
        {
            throw new NotImplementedException();
        }

        public void CreateSecurityProfileUnsafeExternalModule(Guid paramUUID, ISecurityProfileExternalModule paramISecurityProfileExternalModule)
        {
            throw new NotImplementedException();
        }

        public void CreateSecurityProfileVirtualDirectory(Guid paramUUID, ISecurityProfileVirtualDirectory paramISecurityProfileVirtualDirectory)
        {
            throw new NotImplementedException();
        }

        public void Disconnect(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3)
        {
            throw new NotImplementedException();
        }

        public void DropInfoBase(Guid paramUUID1, Guid paramUUID2, int paramInt)
        {
            throw new NotImplementedException();
        }

        public void DropSecurityProfile(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public void DropSecurityProfileAddIn(Guid paramUUID, string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public void DropSecurityProfileApplication(Guid paramUUID, string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public void DropSecurityProfileComClass(Guid paramUUID, string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public void DropSecurityProfileInternetResource(Guid paramUUID, string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public void DropSecurityProfileUnsafeExternalModule(Guid paramUUID, string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public void DropSecurityProfileVirtualDirectory(Guid paramUUID, string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public List<IRegUserInfo> GetAgentAdmins()
        {
            throw new NotImplementedException();
        }

        public IAssignmentRuleInfo GetAssignmentRuleInfo(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3)
        {
            throw new NotImplementedException();
        }

        public List<IAssignmentRuleInfo> GetAssignmentRules(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public List<IRegUserInfo> GetClusterAdmins(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public IClusterInfo GetClusterInfo(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public IClusterManagerInfo GetClusterManagerInfo(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public List<IClusterManagerInfo> GetClusterManagers(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public List<IClusterInfo> GetClusters()
        {
            throw new NotImplementedException();
        }

        public List<IClusterServiceInfo> GetClusterServices(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public IInfoBaseConnectionShort GetConnectionInfoShort(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public List<IObjectLockInfo> GetConnectionLocks(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public List<IInfoBaseConnectionShort> GetConnectionsShort(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public List<IInfoBaseConnectionInfo> GetInfoBaseConnections(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3)
        {
            throw new NotImplementedException();
        }

        public List<IInfoBaseConnectionShort> GetInfoBaseConnectionsShort(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public IInfoBaseInfo GetInfoBaseInfo(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public List<IObjectLockInfo> GetInfoBaseLocks(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public List<IInfoBaseInfo> GetInfoBases(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public List<ISessionInfo> GetInfoBaseSessions(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public IInfoBaseInfoShort GetInfoBaseShortInfo(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public List<IInfoBaseInfoShort> GetInfoBasesShort(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public List<IObjectLockInfo> GetLocks(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public IResourceConsumptionCounter GetResourceConsumptionCounterInfo(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public List<IResourceConsumptionCounter> GetResourceConsumptionCounters(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public List<IResourceConsumptionCounterValue> GetResourceConsumptionCounterValues(Guid paramUUID, string paramString1, string paramString2)
        {
            throw new NotImplementedException();
        }

        public IResourceConsumptionLimit GetResourceConsumptionLimitInfo(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public List<IResourceConsumptionLimit> GetResourceConsumptionLimits(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public List<ISecurityProfileAddIn> GetSecurityProfileAddIns(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public List<ISecurityProfileApplication> GetSecurityProfileApplications(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public List<ISecurityProfileCOMClass> GetSecurityProfileComClasses(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public List<ISecurityProfileInternetResource> GetSecurityProfileInternetResources(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public List<ISecurityProfile> GetSecurityProfiles(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public List<ISecurityProfileExternalModule> GetSecurityProfileUnsafeExternalModules(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public List<ISecurityProfileVirtualDirectory> GetSecurityProfileVirtualDirectories(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public List<IWorkingProcessInfo> GetServerWorkingProcesses(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public ISessionInfo GetSessionInfo(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public List<IObjectLockInfo> GetSessionLocks(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3)
        {
            throw new NotImplementedException();
        }

        public List<ISessionInfo> GetSessions(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public List<IWorkingProcessInfo> GetWorkingProcesses(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public IWorkingProcessInfo GetWorkingProcessInfo(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public IWorkingServerInfo GetWorkingServerInfo(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public List<IWorkingServerInfo> GetWorkingServers(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public void InterruptCurrentServerCall(Guid paramUUID1, Guid paramUUID2, string paramString)
        {
            throw new NotImplementedException();
        }

        public void RegAgentAdmin(IRegUserInfo paramIRegUserInfo)
        {
            throw new NotImplementedException();
        }

        public Guid RegAssignmentRule(Guid paramUUID1, Guid paramUUID2, IAssignmentRuleInfo paramIAssignmentRuleInfo, int paramInt)
        {
            throw new NotImplementedException();
        }

        public Guid RegCluster(IClusterInfo paramIClusterInfo)
        {
            throw new NotImplementedException();
        }

        public void RegClusterAdmin(Guid paramUUID, IRegUserInfo paramIRegUserInfo)
        {
            throw new NotImplementedException();
        }

        public void RegResourceConsumptionCounter(Guid paramUUID, IResourceConsumptionCounter paramIResourceConsumptionCounter)
        {
            throw new NotImplementedException();
        }

        public void RegResourceConsumptionLimit(Guid paramUUID, IResourceConsumptionLimit paramIResourceConsumptionLimit)
        {
            throw new NotImplementedException();
        }

        public Guid RegWorkingServer(Guid paramUUID, IWorkingServerInfo paramIWorkingServerInfo)
        {
            throw new NotImplementedException();
        }

        public void TerminateSession(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public void TerminateSession(Guid paramUUID1, Guid paramUUID2, string paramString)
        {
            throw new NotImplementedException();
        }

        public void UnregAgentAdmin(string paramString)
        {
            throw new NotImplementedException();
        }

        public void UnregAssignmentRule(Guid paramUUID1, Guid paramUUID2, Guid paramUUID3)
        {
            throw new NotImplementedException();
        }

        public void UnregCluster(Guid paramUUID)
        {
            throw new NotImplementedException();
        }

        public void UnregClusterAdmin(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public void UnregResourceConsumptionCounter(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public void UnregResourceConsumptionLimit(Guid paramUUID, string paramString)
        {
            throw new NotImplementedException();
        }

        public void UnregWorkingServer(Guid paramUUID1, Guid paramUUID2)
        {
            throw new NotImplementedException();
        }

        public void UpdateInfoBase(Guid paramUUID, IInfoBaseInfo paramIInfoBaseInfo)
        {
            throw new NotImplementedException();
        }

        public void UpdateInfoBaseShort(Guid paramUUID, IInfoBaseInfoShort paramIInfoBaseInfoShort)
        {
            throw new NotImplementedException();
        }
    }
}
