/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace dotRAC.swp.messages
{
    public class ConnectMessage : IServiceWireMessage
    {
        private readonly IDictionary<string, object> parameters;

        public MessageType Type => MessageType.CONNECT;

        public IDictionary<string, object> Parameters => new ReadOnlyDictionary<string, object>(parameters);

        public ConnectMessage(IDictionary<string, object> parameters)
        {
            Contract.Requires(parameters != default);
            this.parameters = parameters;
        }

        public override string ToString() => string.Format("{0} [{1}]", GetType(), parameters);
    }
}
