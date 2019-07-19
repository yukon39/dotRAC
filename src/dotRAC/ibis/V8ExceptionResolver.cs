/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using DotRAC.Core;
using dotRAC.ibis.service;

namespace dotRAC.ibis
{
    public class V8ExceptionResolver : IExceptionResolver
    {
        private const string V8_NAMESPACE           = "v8";
        private const string V8_GENERIC             = "v8.Generic";
        private const string V8_UNSUPPORTED_SERVICE = "v8.service.UnsupportedService";
        private const string V8_UNEXPECTED_MESSAGE  = "v8.service.UnexpectedMessage";
        private const string V8_FORMAT              = "v8.service.Format";
        private const string V8_PROCESS_MESSAGE     = "v8.service.ProcessMessage";

        public string ResolveName(Exception exception)
        {
            if (exception is V8ProcessMessageException)
            {
                return V8_PROCESS_MESSAGE;
            }
            else if (exception is V8UnexpectedMessageException)
            {
                return V8_UNEXPECTED_MESSAGE;
            }
            else if (exception is V8ServiceFormatException)
            {
                return V8_FORMAT;
            }
            else if (exception is V8UnsupportedServiceException)
            {
                return V8_UNSUPPORTED_SERVICE;
            }
            else if (exception is V8Exception)
            {
                return V8_GENERIC;
            }

            return default;

        }

        public Exception ResolveException(string name, string message)
        {
            if (name.Equals(V8_PROCESS_MESSAGE))
            {
                return new V8ProcessMessageException(message);
            }
            else if (name.Equals(V8_UNEXPECTED_MESSAGE))
            {
                return new V8UnexpectedMessageException(message);
            }
            else if (name.Equals(V8_FORMAT))
            {
                return new V8ServiceFormatException(message);
            }
            else if (name.Equals(V8_UNSUPPORTED_SERVICE))
            {
                return new V8UnsupportedServiceException(message);
            }
            else if (name.Equals(V8_GENERIC) || name.StartsWith(V8_NAMESPACE))
            {
                return new V8Exception(message);
            }

            return default;
        }
    }
}
