/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Timers;
using DotNetty.Handlers.Logging;
using DotNetty.Transport.Channels;
using DotRAC.SWP.Compression;
using DotRAC.SWP.Format;

namespace dotRAC.swp.netty.Internal
{
    public class ClientChannelPipelineFactory
    {
        private static readonly LoggingHandler LOGGER_HANDLER = new LoggingHandler();

        private readonly Timer timer;
        private readonly IServiceWireFormatFactory formatFactory;
        private readonly ICompressionSupportFactory compressionFactory;

        public IChannelPipeline GetPipeline() => throw new NotImplementedException();
    }
}
