using Mapster;
using PS.MoneyMate_Simple.Entities;
using PS.MoneyMate_Simple.Models;

namespace PS.MoneyMate_Simple.Mappings
{
    public class ExchangeRateMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<ExchangeRate, ExchangeRateViewModel>()
              .IgnoreNullValues(true);
        }
    }
}
