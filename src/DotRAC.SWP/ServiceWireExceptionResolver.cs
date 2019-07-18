/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotRAC.Core;

namespace DotRAC.SWP
{
    public class ServiceWireExceptionResolver : IExceptionResolver
    {
        public Exception ResolveException(string name, string message)
        {
            throw new NotImplementedException();
        }

        public string ResolveName(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
