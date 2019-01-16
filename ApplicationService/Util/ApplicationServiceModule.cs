using System;
using System.Collections.Generic;
using System.Text;
using ApplicationService.Repository;
using ApplicationService.Repository.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationService.Util
{
    public static class ApplicationServiceModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ITestAppService, TestAppService>();
        }
    }
}
