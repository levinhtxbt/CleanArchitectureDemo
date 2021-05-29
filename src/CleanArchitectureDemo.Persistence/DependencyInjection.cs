using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDemo.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookingDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BookingDatabase")));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<BookingDbContext>());

            return services;
        }
    }
}
