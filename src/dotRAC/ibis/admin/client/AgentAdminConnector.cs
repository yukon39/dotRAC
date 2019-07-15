/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Timers;
using dotRAC.ibis.admin.Internal;
using dotRAC.ibis.client;
using dotRAC.ibis.service;
using dotRAC.ibis.swp;
using log4net;

namespace dotRAC.ibis.admin.client
{
    public class AgentAdminConnector : IAgentAdminConnector
    {
        private readonly ILog LOGGER = LogManager.GetLogger(typeof(AgentAdminConnector));

        private readonly Timer timer;
        private readonly IV8ConnectionFactory connectionFactory;
        private readonly Dictionary<IAgentAdminConnection, IV8Connection> connections;

        private AgentAdminConnector()
        {
            connections = new Dictionary<IAgentAdminConnection, IV8Connection>();
        }

        internal AgentAdminConnector(long connectTimeout) : this()
        {
            timer = new Timer();

            V8Integration v8Integration = new V8Integration(default);

            connectionFactory = v8Integration.CreateConnectionFactory(timer, connectTimeout);
        }

        internal AgentAdminConnector(Timer timer, long connectTimeout) : this()
        {
            Contract.Requires(timer != default);

            this.timer = timer;

            V8Integration v8Integration = new V8Integration(default);

            connectionFactory = v8Integration.CreateConnectionFactory(timer, connectTimeout);
        }

        public IAgentAdminConnection Connect(string host, ushort port)
        {
            IAgentAdminConnection service = null;

            try
            {
                IV8Connection connection = connectionFactory.CreateConnection();
                connection.Start(new V8ConnectionContext(host, port, false, null));

                AdministrationServiceManager administrationServiceManager = new AdministrationServiceManager(connection, "deflate");

                service = (IAgentAdminConnection)administrationServiceManager.GetService(typeof(IAgentAdminConnection));
                if (service == null)
                {
                    throw new AgentAdminException("Service unsupported");
                }

                connection.AddLifecycleListener(new ConnectionListener(service));
                connections.Add(service, connection);
            }
            catch (V8UnsupportedServiceException e)
            {
                throw new AgentAdminConnectionException("Service unsupported", e);
            }
            catch (V8Exception e)
            {
                throw new AgentAdminConnectionException("Service unsupported", e);
            }

            return service;
        }

        public void Close(IAgentAdminConnection connection)
        {
            Contract.Requires(connection != default);

            IV8Connection inner = connections[connection];
            if (inner != default)
            {
                try
                {
                    inner.Stop();
                }
                catch (V8Exception e)
                {
                    LOGGER.Warn(string.Format("Error closing connection: {0}", inner), e);
                }
            }
        }

        public void Dispose()
        {
            foreach (KeyValuePair<IAgentAdminConnection, IV8Connection> keyValue in connections)
            {
                try
                {
                    keyValue.Value.Stop();
                }
                catch (V8Exception e)
                {
                    LOGGER.Warn(string.Format("Error closing connection: {0}", keyValue.Value), e);
                }
            }

            try
            {
                connectionFactory.Dispose();
            }
            catch (V8Exception e)
            {
                LOGGER.Warn("Shutdown error", e);
            }

            if (timer != default)
            {
                timer.Stop();
            }
        }

        private class ConnectionListener : IV8LifecycleListener
        {
            private readonly IAgentAdminConnection service;

            public ConnectionListener(IAgentAdminConnection service) { this.service = service; }
            public void OnStateChange(V8LifecycleListenerState state)
            {
                if (state == V8LifecycleListenerState.STOPPED)
                {
                    //    AgentAdminConnector.this.connections.remove(service);
                }
            }

            public void OnException(V8Exception exception) { }
        }
    }
}
