/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis.admin.client
{
    public interface IAgentAdminConnectorFactory
    {
        IAgentAdminConnector CreateConnector(long connectTimeout);
        
        //TODO: Add method to interface
        //IAgentAdminConnector createConnector(Timer paramTimer, Executor paramExecutor, long paramLong);
    }
}
