/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System.Collections.Specialized;
using System.Timers;
using DotNetty.Common.Concurrency;

namespace DotRAC.SWP
{
    public interface IServiceWireConnectorFactory
    {
        IServiceWireConnector CreateConnector(IExecutor executor, Timer timer, NameValueCollection properties);
    }
}
