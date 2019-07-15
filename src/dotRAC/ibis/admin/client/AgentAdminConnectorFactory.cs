/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Timers;

namespace dotRAC.ibis.admin.client
{
    public class AgentAdminConnectorFactory : IAgentAdminConnectorFactory
    {

        public IAgentAdminConnector CreateConnector(long connectTimeout) => new AgentAdminConnector(connectTimeout);

        public IAgentAdminConnector CreateConnector(Timer timer, long connectTimeout) => new AgentAdminConnector(timer, connectTimeout);
    }
}
