﻿/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.ibis.service
{
    public class V8ServiceException : V8Exception
    {
        public V8ServiceException() : base() { }

        public V8ServiceException(string message) : base(message) { }

        public V8ServiceException(string message, Exception innerException) : base(message, innerException) { }
    }
}
