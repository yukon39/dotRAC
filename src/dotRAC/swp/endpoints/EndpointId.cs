/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.swp.endpoints
{
    public class EndpointId : IComparable<EndpointId>
    {
        private readonly int id;

        public EndpointId(int id) => this.id = id;

        public override int GetHashCode() => id;

        public override bool Equals(object obj) => obj is EndpointId endpointId ? id == endpointId.id : false;

        public override string ToString() => id.ToString("X");

        public int CompareTo(EndpointId obj) => (id < obj.id) ? -1 : ((id == obj.id) ? 0 : 1);

        public int ToInt() => id;
    }
}
