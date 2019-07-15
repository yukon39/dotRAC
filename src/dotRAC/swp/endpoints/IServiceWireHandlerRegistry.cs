/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using dotRAC.swp.codec;

namespace dotRAC.swp.endpoints
{
    public interface IServiceWireHandlerRegistry
    {
        EndpointId OpenEndpoint(ServiceId serviceId, IServiceWireCodec wireCodec);

        void CloseEndpoint(EndpointId endpointId);

        ServiceId GetServiceId(EndpointId endpointId);

        IServiceWireEndpointFormat GetServiceFormat(EndpointId endpointId);

        IServiceWireEndpointMessage DispatchMessage(EndpointId endpointId, IServiceWireEndpointMessage message);

        void CloseAll();
    }
}
