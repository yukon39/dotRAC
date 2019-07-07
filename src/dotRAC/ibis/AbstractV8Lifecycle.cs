/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;

namespace dotRAC.ibis
{
    public abstract class AbstractV8Lifecycle<T> : IV8Lifecycle<T>
    {
        protected List<IV8LifecycleListener> listeners;

        public AbstractV8Lifecycle()
        {
            listeners = new List<IV8LifecycleListener>();
        }

        public void Start(T context) => throw new NotImplementedException();

        public void Cleanup() => throw new NotImplementedException();

        public void Stop() => throw new NotImplementedException();

        public void AddLifecycleListener(IV8LifecycleListener listener) => listeners.Add(listener);

        public void RemoveLifecycleListener(IV8LifecycleListener listener) => listeners.Remove(listener);

        public void NotifyOnStateChanged(V8LifecycleListenerState state) => listeners.ForEach(x => x.OnStateChange(state));

        public void NotifyOnException(V8Exception exception) => listeners.ForEach(x => x.OnException(exception));

        public void NotifyOnStart() => NotifyOnStateChanged(V8LifecycleListenerState.STARTED);
        public void NotifyOnCleanedUp() => NotifyOnStateChanged(V8LifecycleListenerState.CLEANED_UP);
        public void NotifyOnStopped() => NotifyOnStateChanged(V8LifecycleListenerState.STOPPED);
    }
}
