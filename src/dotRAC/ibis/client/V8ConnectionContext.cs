/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Diagnostics.Contracts;
using System.Net.Security;
using dotRAC.core.security;

namespace dotRAC.ibis.client
{
    public class V8ConnectionContext : IV8ConnectionContext
    {
        private readonly string hostName;
        private readonly ushort port;
        private readonly bool tlsRequired;
        private readonly ISslContextFactory sslFactory;

        public string HostName => hostName;

        public ushort Port => port;

        public bool TlsRequired => tlsRequired && (sslFactory is ISslContextFactory);

        public V8ConnectionContext(string hostName, ushort port, bool tlsRequired, ISslContextFactory sslFactory)
        {
            this.hostName = hostName;
            this.port = port;
            this.tlsRequired = tlsRequired;
            this.sslFactory = sslFactory;
        }

        public SslStream CreateContext()
        {
            Contract.Requires<InvalidOperationException>(sslFactory is ISslContextFactory);
            return sslFactory.CreateContext();
        }
    }
}
