/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace DotRAC.SWP.Endpoints
{
    public class ServiceWireEndpointException : ServiceWireException
    {
        public ServiceWireEndpointException() : base() { }

        public ServiceWireEndpointException(string message) : base(message) { }

        public ServiceWireEndpointException(string message, Exception innerException) : base(message, innerException) { }
    }
}
