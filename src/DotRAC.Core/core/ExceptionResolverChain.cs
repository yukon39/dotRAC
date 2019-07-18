/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Diagnostics.Contracts;

namespace DotRAC.Core
{
    public class ExceptionResolverChain : IExceptionResolver
    {
        private readonly IExceptionResolver first;
        private readonly IExceptionResolver second;

        public ExceptionResolverChain(IExceptionResolver _first, IExceptionResolver _second)
        {
            Contract.Requires(_first != default);
            Contract.Requires(_second != default);

            first = _first;
            second = _second;
        }

        public Exception ResolveException(string name, string message)
        {
            Exception exception = first.ResolveException(name, message);
            return exception == default ? second.ResolveException(name, message) : exception;
        }

        public string ResolveName(Exception exception)
        {
            string name = first.ResolveName(exception);
            return string.IsNullOrEmpty(name) ? second.ResolveName(exception) : name;
        }
    }
}
