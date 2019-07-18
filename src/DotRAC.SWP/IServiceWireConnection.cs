/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace DotRAC.SWP
{
    public interface IServiceWireConnection
    {
        //SocketAddress GetAddress();
        //IServiceWireFuture GetCloseFuture();
        //IServiceWireCodec createCodec() throws ServiceWireCodecException;
        //IServiceWireFuture startTls(ISslContextFactory paramISslContextFactory);
        //IServiceWireFuture authenticate(String[] paramArrayOfString, String paramString, Map<String, ?> paramMap, CallbackHandler paramCallbackHandler);
        //IServiceWireFuture openEndpoint(ServiceId paramServiceId, Map<String, ?> paramMap, IServiceWireEndpointFormatFactory paramIServiceWireEndpointFormatFactory);
        //IServiceWireEndpointFuture closeEndpoint(IServiceWireEndpoint paramIServiceWireEndpoint);
        //IServiceWireEndpointFuture sendMessage(IServiceWireEndpoint paramIServiceWireEndpoint, IServiceWireEndpointMessage paramIServiceWireEndpointMessage);
        //IServiceWireEndpointFuture sendOneWayMessage(IServiceWireEndpoint paramIServiceWireEndpoint, IServiceWireEndpointMessage paramIServiceWireEndpointMessage);
        IServiceWireFuture Close();
    }
}
