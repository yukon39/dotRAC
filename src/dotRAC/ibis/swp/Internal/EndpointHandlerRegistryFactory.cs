/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Diagnostics.Contracts;
using dotRAC.ibis.host;
using dotRAC.swp.endpoints;

namespace dotRAC.ibis.swp.Internal
{
    internal class EndpointHandlerRegistryFactory : IServiceWireHandlerRegistryFactory
    {

        private readonly IV8ServerHostProviderFactory hostProviderFactory;

        public EndpointHandlerRegistryFactory(IV8ServerHostProviderFactory hostProviderFactory)
        {
            Contract.Requires(hostProviderFactory != default);
            this.hostProviderFactory = hostProviderFactory;
        }

        public IServiceWireHandlerRegistry CreateRegistry()
        {
            EndpointHandlerFactory handlerFactory = new EndpointHandlerFactory(hostProviderFactory.CreateProvider());
            ServiceWireHandlerRegistryFactory registryFactory = new ServiceWireHandlerRegistryFactory(handlerFactory);

            return registryFactory.CreateRegistry();
        }
    }
}
