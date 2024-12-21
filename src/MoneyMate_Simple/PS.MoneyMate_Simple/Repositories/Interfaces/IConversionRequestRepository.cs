using PS.MoneyMate_Simple.Entities;
using PS.MoneyMate_Simple.Repositories.Interfaces.Base;

namespace PS.MoneyMate_Simple.Repositories.Interfaces
{
    public interface IConversionRequestRepository : ICrudRepository<ConversionRequest>
    {
        Task<IEnumerable<ConversionRequest>> GetByDateRangeAsync(DateTime startDate, DateTime endDate); // Найти запросы по диапазону дат
    }
}
