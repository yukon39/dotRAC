/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using dotRAC.ibis.service;
using dotRAC.ibis.swp;
using dotRAC.ibis.transport;
using DotRAC.Core;
using DotRAC.SWP.Codec;

namespace dotRAC.ibis.admin.Internal
{
    internal class ServiceManagerFormatFactory : ISwpV8MessageFormatFactory
    {
        private const string VERSION_3 = "3.0";

        private const string VERSION_4 = "4.0";

        private const string VERSION_5 = "5.0";

        private const string VERSION_6 = "6.0";

        private readonly IExceptionResolver resolver;

        public ServiceManagerFormatFactory(IExceptionResolver resolver) => this.resolver = resolver;

        public IV8MessageFormat CreateFormat() => throw new InvalidOperationException();

        public IV8MessageFormat CreateFormat(IServiceWireCodec codec, string version)
        {
            switch (version)
            {
                case VERSION_3:
                    return new ServiceMessageFormat(codec, resolver, 3);

                case VERSION_4:
                    return new ServiceMessageFormat(codec, resolver, 4);

                case VERSION_5:
                    return new ServiceMessageFormat(codec, resolver, 5);

                case VERSION_6:
                    return new ServiceMessageFormat(codec, resolver, 5);

                default:
                    throw new V8UnsupportedServiceFormatException();
            }
        }
    }
}
