/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

namespace dotRAC.ibis
{
    public interface IV8LifecycleListener
    {
        void OnStateChange(V8LifecycleListenerState state);
        void OnException(V8Exception exception);
    }
}
