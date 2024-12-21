using PS.MoneyMate_Simple.Entities;
using PS.MoneyMate_Simple.Repositories.Interfaces.Base;

namespace PS.MoneyMate_Simple.Repositories.Interfaces
{
    public interface IExchangeRateRepository : ICrudRepository<ExchangeRate>
    {
        Task<ExchangeRate?> GetRateAsync(Guid fromCurrencyId, Guid toCurrencyId); // Получить курс для пары валют
    }
}
