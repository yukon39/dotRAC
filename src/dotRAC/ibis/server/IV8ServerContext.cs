/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using dotRAC.core.security;

namespace dotRAC.ibis.server
{
    public interface IV8ServerContext : IV8Context
    {
        ushort Port { get; }
        //Executor getExecutor();
        //Timer getTimer();

        SaslProperties GetSaslProperties();

        ISslContextFactory GetSslContextFactory();

        //Properties getProperties();
    }
}
