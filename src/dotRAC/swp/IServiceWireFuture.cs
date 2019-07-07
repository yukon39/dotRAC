/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;

namespace dotRAC.swp
{
    public interface IServiceWireFuture
    {
        //IServiceWireConnection getConnection();
        //boolean isDone();
        //boolean isCancelled();
        //boolean isSuccess();
        bool Failed { get; }
        //Object getResult();
        Exception InnerException { get; }
        //boolean cancel();
        //boolean setSuccess();
        //boolean setResult(Object paramObject);
        //boolean setFailure(Throwable paramThrowable);
        //boolean setProgress(long paramLong1, long paramLong2, long paramLong3);
        //void addListener(IServiceWireFutureListener paramIServiceWireFutureListener);
        //void removeListener(IServiceWireFutureListener paramIServiceWireFutureListener);
        //IServiceWireFuture await() throws InterruptedException;
        IServiceWireFuture AwaitUninterruptibly();
        //IServiceWireFuture await(long paramLong, TimeUnit paramTimeUnit) throws InterruptedException, TimeoutException;
        //IServiceWireFuture await(long paramLong) throws InterruptedException, TimeoutException;
        //IServiceWireFuture awaitUninterruptibly(long paramLong, TimeUnit paramTimeUnit) throws InterruptedException, TimeoutException;
        //IServiceWireFuture AwaitUninterruptibly(long paramLong);
    }
}

