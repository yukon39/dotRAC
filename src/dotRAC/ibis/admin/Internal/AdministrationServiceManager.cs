/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using dotRAC.ibis.client;
using dotRAC.ibis.service;
using dotRAC.ibis.transport;

namespace dotRAC.ibis.admin.Internal
{
    public class AdministrationServiceManager : AbstractServiceManager
    {
        public AdministrationServiceManager(IV8Connection connection, string encoding) : base(connection, encoding) { }

        protected override IV8ServiceProxy CreateServiceProxy(Type type, IV8Connection connection, string encoding)
        {
            if (type.IsAssignableFrom(typeof(IAgentAdminConnection)))
            {
                IV8Transport transport = connection.StartService("v8.service.Admin.Cluster",
                    AgentAdminConnectionProxy.ServiceVersions, encoding, AgentAdminConnectionProxy.FormatFactory);

                return new AgentAdminConnectionProxy(transport);
            }
            else
            {
                return default;
            }
        }
    }
}
