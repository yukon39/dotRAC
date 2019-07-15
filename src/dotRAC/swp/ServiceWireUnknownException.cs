/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.swp
{
    public class ServiceWireUnknownException : Exception
    {
        private readonly string className;

        public string ExceptionClassName => className;

        public ServiceWireUnknownException(string className, string msg)
            : base(msg) => this.className = className;

        public ServiceWireUnknownException(string className, string msg, Exception exception)
             : base(msg, exception) => this.className = className;
    }
}
