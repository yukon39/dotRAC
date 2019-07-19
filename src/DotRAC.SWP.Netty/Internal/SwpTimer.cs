/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using DotNetty.Common.Utilities;

namespace DotRAC.SWP.Netty.Internal
{
    public class SwpTimer : ITimer
    {
        private readonly Timer timer;
        //private readonly Queue<Timeout> timeouts;
        public SwpTimer(Timer timer)
        {
            //this.timeouts = new ConcurrentLinkedQueue();
            this.timer = timer;
        }

        public ITimeout NewTimeout(ITimerTask task, TimeSpan delay)
        {
            throw new NotImplementedException();
        }

        public Task<ISet<ITimeout>> StopAsync()
        {
            throw new NotImplementedException();
        }
    }
}
