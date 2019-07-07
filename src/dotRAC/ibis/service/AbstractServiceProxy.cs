/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using dotRAC.ibis.transport;

namespace dotRAC.ibis.service
{
    public abstract class AbstractServiceProxy : IV8ServiceProxy
    {
        public IV8Transport Transport { get; }
        public string Name => Transport?.Name;
        public string Version => Transport?.Version;

        protected AbstractServiceProxy(IV8Transport transport) => Transport = transport;

        protected void CheckLifecycle()
        {
            if (Transport == default)
            {
                throw new ArgumentOutOfRangeException("Out of lifecycle!");
            }
        }
    }
}
