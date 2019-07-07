/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Net.Security;

namespace dotRAC.ibis.client
{
    public interface IV8ConnectionContext : IV8Context
    {
        string HostName { get; }
        ushort Port { get; }
        bool TlsRequired { get; }
        SslStream CreateContext();
    }
}
