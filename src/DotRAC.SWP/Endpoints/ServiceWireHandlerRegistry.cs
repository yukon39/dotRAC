/*----------------------------------------------------------
This Source Code Form is subject to the terms of the 
Mozilla Public License, v.2.0. If a copy of the MPL 
was not distributed with this file, You can obtain one 
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using DotRAC.SWP.Codec;
using log4net;

namespace DotRAC.SWP.Endpoints
{
    public class ServiceWireHandlerRegistry : IServiceWireHandlerRegistry
    {
        private static readonly ILog LOGGER = LogManager.GetLogger(typeof(ServiceWireHandlerRegistry));

        private readonly IServiceWireHandlerFactory handlerFactory;

        private int lastEndpointId;
        private readonly Dictionary<EndpointId, ServiceId> serviceIds;
        private readonly Dictionary<EndpointId, IServiceWireEndpointHandler> serviceHandlers;

        internal ServiceWireHandlerRegistry(IServiceWireHandlerFactory handlerFactory)
        {
            Contract.Requires(handlerFactory != null);

            this.handlerFactory = handlerFactory;
            lastEndpointId = 0;
            serviceIds = new Dictionary<EndpointId, ServiceId>();
            serviceHandlers = new Dictionary<EndpointId, IServiceWireEndpointHandler>();
        }

        public EndpointId OpenEndpoint(ServiceId serviceId, IServiceWireCodec wireCodec)
        {
            IServiceWireEndpointHandler handler = handlerFactory.CreateHandler(serviceId, wireCodec);
            if (handler == default)
            {
                throw new ServiceWireEndpointException("Service handler doesn`t exist");
            }

            if (handler is IServiceWireHandlerLifecycle lifecycle)
            {
                try
                {
                    lifecycle.OnOpenEndpoint();
                }
                catch (ServiceWireEndpointException e)
                {
                    LOGGER.Error(string.Format("Endpoint service: {0} - opened with error.", serviceId), e);
                    throw e;
                }
                catch (Exception e)
                {
                    string exceptionMessage = string.Format("Endpoint service: {0} - opened with error.", serviceId);
                    LOGGER.Error(exceptionMessage, e);
                    throw new ServiceWireEndpointException(exceptionMessage, e);
                }
            }

            EndpointId endpointId = null;

            lock (this)
            {

                endpointId = new EndpointId(++lastEndpointId);
                serviceIds.Add(endpointId, serviceId);
                serviceHandlers.Add(endpointId, handler);
            }

            LOGGER.Debug(string.Format("Endpoint {0} of service: {1} - opened.", endpointId, serviceId));

            return endpointId;
        }

        public void CloseEndpoint(EndpointId endpointId)
        {
            ServiceId serviceId = null;
            IServiceWireEndpointHandler handler = null;
            lock (this)
            {
                //serviceId = (ServiceId)serviceIds.Remove(endpointId);
                //handler = (IServiceWireEndpointHandler)this.serviceHandlers.remove(endpointId);
            }

            if (serviceId == null || handler == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            CloseServiceEndpoint(serviceId, endpointId, handler);
        }

        public ServiceId GetServiceId(EndpointId endpointId) => serviceIds[endpointId];

        public IServiceWireEndpointFormat GetServiceFormat(EndpointId endpointId)
        {
            IServiceWireEndpointHandler handler = null;
            lock (this)
            {
                handler = serviceHandlers[endpointId];
            }

            if (handler == default)
            {
                throw new ServiceWireEndpointException("Service handler doesn`t exist");
            }

            return handler.Format;
        }

        public IServiceWireEndpointMessage DispatchMessage(EndpointId endpointId, IServiceWireEndpointMessage message)
        {
            IServiceWireEndpointHandler handler = null;
            lock (this)
            {
                handler = serviceHandlers[endpointId];
            }

            if (handler == default)
            {
                throw new ServiceWireEndpointException("Service handler doesn`t exist");
            }

            try
            {
                return handler.HandleMessage(message);
            }
            catch (Exception e)
            {
                throw new ServiceWireEndpointException("Service handler error", e);
            }
        }

        public void CloseAll()
        {
            Dictionary<EndpointId, ServiceId> services = new Dictionary<EndpointId, ServiceId>();

            Dictionary<EndpointId, IServiceWireEndpointHandler> handlers = new Dictionary<EndpointId, IServiceWireEndpointHandler>();

            lock (this)
            {
                foreach (KeyValuePair<EndpointId, ServiceId> keyValue in serviceIds)
                {
                    services.Add(keyValue.Key, keyValue.Value);
                }
                services.Clear();

                foreach (KeyValuePair<EndpointId, IServiceWireEndpointHandler> keyValue in serviceHandlers)
                {
                    handlers.Add(keyValue.Key, keyValue.Value);
                }
                serviceHandlers.Clear();
            }

            foreach (KeyValuePair<EndpointId, IServiceWireEndpointHandler> keyValue in handlers)
            {
                EndpointId endpointId = keyValue.Key;
                IServiceWireEndpointHandler handler = keyValue.Value;
                ServiceId serviceId = services[keyValue.Key];

                CloseServiceEndpoint(serviceId, endpointId, handler);
            }
        }

        private void CloseServiceEndpoint(ServiceId serviceId, EndpointId endpointId, IServiceWireEndpointHandler handler)
        {
            LOGGER.Debug(string.Format("Endpoint {0} of service: {1} - closed.", endpointId, serviceId));

            if (handler is IServiceWireHandlerLifecycle lifecycle)
            {
                try
                {
                    lifecycle.OnCloseEndpoint();
                }
                catch (ServiceWireEndpointException e)
                {
                    LOGGER.Error(string.Format("Endpoint service: {0} - closed with error.", serviceId), e);
                    throw e;
                }
                catch (Exception e)
                {
                    string exceptionMessage = string.Format("Endpoint {0} of service: {1} - closed with error.", endpointId, serviceId);
                    LOGGER.Error(exceptionMessage, e);
                    throw new ServiceWireEndpointException(exceptionMessage, e);
                }
            }
        }
    }
}
