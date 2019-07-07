/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis.client
{
    public class V8ConnectionException : V8Exception
    {

        public V8ConnectionException() : base() { }

        public V8ConnectionException(string message) : base(message) { }

        public V8ConnectionException(string message, Exception innerException) : base(message, innerException) { }
    }
}
