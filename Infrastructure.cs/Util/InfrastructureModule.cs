using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Util
{
    public class InfrastructureModule
    {
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
            
        }
    }
}
