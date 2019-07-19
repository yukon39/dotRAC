/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Timers;
using DotNetty.Common.Concurrency;
using dotRAC.ibis.client;
using dotRAC.ibis.server;

namespace dotRAC.ibis
{
    public interface IV8Integration
    {
        IV8Server CreateServer(IV8ServerContext context);
        IV8ConnectionFactory CreateConnectionFactory(Timer paramTimer, IExecutor paramExecutor, long paramLong);
    }
}
