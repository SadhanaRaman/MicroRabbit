using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using MicroRabbit.Domail.Core.Bus;
using MicroRabbit.Infra.Bus;

namespace MicroRabbit.Infra.IoC
{
    class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
