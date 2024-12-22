using FluentValidation;
using Mapster;
using Microsoft.EntityFrameworkCore;
using PS.MoneyMate_Simple.Data;
using PS.MoneyMate_Simple.Repositories.Implementation;
using PS.MoneyMate_Simple.Repositories.Interfaces;
using PS.MoneyMate_Simple.Validations;

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
            // Регистрируем все конфигурации маппинга в текущей сборке
            TypeAdapterConfig.GlobalSettings.Scan(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
        private static IServiceCollection AddValidationConfiguration(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<CurrencyViewModelValidator>();
            services.AddValidatorsFromAssemblyContaining<ConversionRequestViewModelValidator>();
            services.AddValidatorsFromAssemblyContaining<ExchangeRateViewModelValidator>();

            return services;
        }

    }
}
