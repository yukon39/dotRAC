/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using log4net;

namespace DotRAC.Core
{
    public class DefaultExceptionResolver : IExceptionResolver
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(DefaultExceptionResolver));

        public Exception ResolveException(string name, string message)
        {
            Exception exception = default;

            try
            {
                Type type = Type.GetType(name);
                exception = string.IsNullOrEmpty(message) ? (Exception)Activator.CreateInstance(type) : (Exception)Activator.CreateInstance(type, message);
            }
            catch (Exception e)
            {
                logger.Warn(string.Format("Unresolved exception: ''{0}'' with message: ''{1}''", name, message), e);
            }

            return exception;

        }

        public string ResolveName(Exception exception) => exception.GetType().Name;
    }
}
