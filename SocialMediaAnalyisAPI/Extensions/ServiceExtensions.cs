using JsonDiffPatchDotNet;
using Microsoft.EntityFrameworkCore;
using SocialMediaAnalyis.LoggerService;
using SocialMediaAnalyis.Repository;
using SocialMediaAnalyis.Repository.Contracts;
using SocialMediaAnalyis.Service;
using SocialMediaAnalyis.Service.Contracts;

namespace SocialMediaAnalyis.API.Extensions
{
    public static class ServiceExtensions
    {
        // CORS Configuration
        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder
                .SetIsOriginAllowed(x => true)
                .AllowCredentials()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("X-Pagination")
                );

        });
        //IIS Configuration
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {

        });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
   services.AddSingleton<ILoggerManager, LoggerManager>();



        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureSqlContext(this IServiceCollection services,
           IConfiguration configuration) =>
           services.AddDbContext<RepositoryContext>(opts =>
           opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection")),
               ServiceLifetime.Scoped);

        public static void AddJsonDiffPatch(this IServiceCollection services) =>
            services.AddSingleton<JsonDiffPatch>();


    }
}
