/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using dotRAC.ibis.client;

namespace dotRAC.ibis.service
{
    public abstract class AbstractServiceManager : IV8ServiceManager
    {
        private readonly Dictionary<object, IV8ServiceProxy> services;
        private readonly IV8Connection connection;
        private readonly string encoding;

        public AbstractServiceManager(IV8Connection connection, string encoding)
        {
            Contract.Requires(connection != default);

            this.connection = connection;
            this.encoding = encoding;
        }

        public IV8ServiceProxy GetService(Type type)
        {
            IV8ServiceProxy proxy = services[type];

            if (proxy == default)
            {
                proxy = CreateServiceProxy(type, connection, encoding);
                if (proxy == default)
                {
                    throw new V8UnsupportedServiceException(type.Name);
                }

                if (!(proxy.GetType().IsAssignableFrom(type)))
                {
                    throw new InvalidOperationException(string.Format("Illegal service implementation: {0}", proxy.GetType()));
                }
            }

            return proxy;
        }

        protected abstract IV8ServiceProxy CreateServiceProxy(Type paramClass, IV8Connection paramIV8Connection, string paramString);

    }
}
