using DemoGraphQL.Application.Interfaces;
using DemoGraphQL.Application.Interfaces.Repositories;
using DemoGraphQL.Infrastructure.Persistence.Contexts;
using DemoGraphQL.Infrastructure.Persistence.Repositories;
using DemoGraphQL.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQL.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<VietbankDbContext>(options =>
           options.UseMySql(
               configuration.GetConnectionString("DefaultConnection"),
               b => b.MigrationsAssembly(typeof(VietbankDbContext).Assembly.FullName)));

            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IProductRepositoryAsync, ProductRepositoryAsync>();
            #endregion
        }
    }
}
