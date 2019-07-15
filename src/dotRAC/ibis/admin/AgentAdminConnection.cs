/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using dotRAC.ibis.client;
using dotRAC.ibis.service;

namespace dotRAC.ibis.admin
{
    public class AgentAdminConnection
    {
        private readonly IV8ConnectionFactory connectionFactory;

        public AgentAdminConnection()
        {
        }

        public void Connect(string hostName = "localhost", ushort port = 1545)
        {
            try
            {
                IV8Connection connection = connectionFactory.CreateConnection();
                IV8ConnectionContext connectionContext = new V8ConnectionContext(hostName, port, false, null);
                connection.Start(connectionContext);
            }

            catch (V8UnsupportedServiceException e)
            {
                //throw new AgentAdminConnectionException(e);
            }
            catch (V8Exception e)
            {
                //throw new AgentAdminConnectionException(e);
            }
        }

        public void Authenticate(string username, string password) => throw new NotImplementedException();

        public List<IRegUserInfo> GetAdministrators() => throw new NotImplementedException();

        public List<IClusterInfo> GetClusters() => throw new NotImplementedException();

        public IRegUserInfo CreateAdministrator() => throw new NotImplementedException();

        public IClusterInfo CreateCluster() => throw new NotImplementedException();
    }
}
