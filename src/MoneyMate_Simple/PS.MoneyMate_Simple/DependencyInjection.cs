using Microsoft.EntityFrameworkCore;
using PS.MoneyMate_Simple.Data;
using PS.MoneyMate_Simple.Repositories.Implementation;
using PS.MoneyMate_Simple.Repositories.Interfaces;

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

            services.AddScoped<IConversionRequestRepository, ConversionRequestRepository>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<IExchangeRateRepository, ExchangeRateRepository>();

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
