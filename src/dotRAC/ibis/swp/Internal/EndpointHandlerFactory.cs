/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Diagnostics.Contracts;
using dotRAC.ibis.host;
using DotRAC.SWP.Codec;
using DotRAC.SWP.Endpoints;

namespace dotRAC.ibis.swp.Internal
{
    public class EndpointHandlerFactory : IServiceWireHandlerFactory
    {
        private readonly IV8ServerHostProvider hostProvider;

        public EndpointHandlerFactory(IV8ServerHostProvider hostProvider)
        {
            Contract.Requires(hostProvider != default);
            this.hostProvider = hostProvider;
        }

        public IServiceWireEndpointHandler CreateHandler(ServiceId serviceId, IServiceWireCodec codec)
        {
            Contract.Requires(codec != default);
            return new EndpointHandler(serviceId.Name, serviceId.Version, hostProvider, new EndpointFormat(codec), codec.Version);
        }
    }
}
