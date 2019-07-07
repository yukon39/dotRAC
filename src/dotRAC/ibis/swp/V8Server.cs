/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using dotRAC.ibis.server;
using dotRAC.swp;

namespace dotRAC.ibis.swp
{
    public class V8Server : AbstractV8Lifecycle<IV8ServerContext>, IV8Server
    {
        public V8Server(IServiceWireServerFactory factory)
        {

        }
    }
}
