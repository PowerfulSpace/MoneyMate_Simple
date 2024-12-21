using Microsoft.EntityFrameworkCore;
using PS.MoneyMate_Simple.Data;

namespace PS.MoneyMate_Simple
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddControllersWithViews();

            services
                .AddPersistance(configuration)
                .AddMapsterConfiguration()
                .AddValidationConfiguration();

            return services;
        }

        private static IServiceCollection AddPersistance(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<MoneyMate_SimpleDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }

        private static IServiceCollection AddMapsterConfiguration(this IServiceCollection services)
        {
            return services;
        }
        private static IServiceCollection AddValidationConfiguration(this IServiceCollection services)
        {
            return services;
        }

    }
}
