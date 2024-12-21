using PS.MoneyMate_Simple.Entities;
using PS.MoneyMate_Simple.Repositories.Interfaces.Base;

namespace PS.MoneyMate_Simple.Repositories.Interfaces
{
    public interface ICurrencyRepository : ICrudRepository<Currency>
    {
        Task<Currency?> GetByCodeAsync(string code); // Найти валюту по коду (например, "USD")
    }
}
