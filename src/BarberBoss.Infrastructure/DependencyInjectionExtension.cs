﻿using BarberBoss.Infrastructure.DataAcces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BarberBoss.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            AddRepositories(services);
        }
        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Connection");

            var dbVersion = new MySqlServerVersion(new Version(8, 0, 41));

            services.AddDbContext<BarberBossDbContext>(config => config.UseMySql(connectionString, dbVersion));
        }
        private static void AddRepositories(IServiceCollection services)
        {
            
        }
    }
}