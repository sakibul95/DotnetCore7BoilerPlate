using Infrastructure.Helpers.Services.ServiceImplementation;
using Infrastructure.Helpers.Services.ServiceInterface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Helpers.Services
{
    public static class ServicesDependency
    {
        public static IServiceCollection AddServicesDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBasicTestCrudFunctionality), typeof(BasicTestCrudFunctionality));
            return services;
        }
    }
}
