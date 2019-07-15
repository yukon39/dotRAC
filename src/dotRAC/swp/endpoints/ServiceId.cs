/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Diagnostics.Contracts;

namespace dotRAC.swp.endpoints
{
    public class ServiceId
    {
        private readonly string name;
        private readonly string version;

        public string Name => name;
        public string Version => version;

        public ServiceId(string name, string version)
        {
            Contract.Requires(!string.IsNullOrEmpty(name));
            Contract.Requires(!string.IsNullOrEmpty(version));

            this.name = name;
            this.version = version;
        }

        public override string ToString() => string.Format("[ name='{0}' version='{1}' ]", name, version);

        public override int GetHashCode() => name.GetHashCode() + 5 * version.GetHashCode();

        public override bool Equals(object obj) => obj is ServiceId serviceId ? (name.Equals(serviceId.name) && version.Equals(serviceId.version)) : false;
    }
}
