﻿/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace DotRAC.SWP
{
    public class ServiceWireException : Exception
    {
        public ServiceWireException() : base() { }

        public ServiceWireException(string message) : base(message) { }

        public ServiceWireException(string message, Exception innerException) : base(message, innerException) { }
    }
}
