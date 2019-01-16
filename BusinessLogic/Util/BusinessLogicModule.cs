using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Repository;
using BusinessLogic.Repository.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.Util
{
    public static class BusinessLogicModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ITestService, TestService>();
        }
    }
}
