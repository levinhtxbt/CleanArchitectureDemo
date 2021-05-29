using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Common.Interfaces;
using CleanArchitectureDemo.Domain.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace CleanArchitectureDemo.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<IDateTime, MachineDateTime>();
            services.AddTransient<INotificationService, NotificationService>();

            return services;
        }
    }


}
