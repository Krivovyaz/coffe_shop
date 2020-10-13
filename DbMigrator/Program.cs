﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using NLayerApp.DAL;

namespace DbMigrator
{
    class Program
    {
        public static void Main(string[] args)
            => CreateHostBuilder(args).Build().Run();
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDAL();
                    services.AddSingleton<IHostedService, Startup>();
                });
    }
}