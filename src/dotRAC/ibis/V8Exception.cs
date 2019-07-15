/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis
{
    public class V8Exception : Exception
    {
        public V8Exception() : base() { }

        public V8Exception(string message) : base(message) { }

        public V8Exception(string message, Exception innerException) : base(message, innerException) { }
    }
}
