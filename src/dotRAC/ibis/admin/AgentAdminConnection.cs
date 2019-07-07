/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotRAC.ibis.admin.service;
using dotRAC.ibis.client;

namespace dotRAC.ibis.admin
{
    public class AgentAdminConnection
    {
        private readonly IV8ConnectionFactory connectionFactory;

        public AgentAdminConnection(string hostName = "localhost", ushort port = 1545)
        {
            //ServiceProxy = null;


        }

        public void Authenticate(string username, string password) => throw new NotImplementedException();

        public List<IRegUserInfo> GetAdministrators() => throw new NotImplementedException();

        public List<IClusterInfo> GetClusters() => throw new NotImplementedException();

        public IRegUserInfo CreateAdministrator() => throw new NotImplementedException();

        public IClusterInfo CreateCluster() => throw new NotImplementedException();
    }
}
