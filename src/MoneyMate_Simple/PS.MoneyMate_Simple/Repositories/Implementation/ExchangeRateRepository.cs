using Microsoft.EntityFrameworkCore;
using PS.MoneyMate_Simple.Data;
using PS.MoneyMate_Simple.Entities;
using PS.MoneyMate_Simple.Repositories.Interfaces;

namespace PS.MoneyMate_Simple.Repositories.Implementation
{
    public class ExchangeRateRepository : IExchangeRateRepository
    {
        private readonly MoneyMate_SimpleDbContext _context;

        public ExchangeRateRepository(MoneyMate_SimpleDbContext context)
        {
            _context = context;
        }

        // Получить все курсы
        public async Task<IEnumerable<ExchangeRate>> GetAllAsync()
        {
            return await _context.ExchangeRates.ToListAsync();
        }

        // Получить курс по Id
        public async Task<ExchangeRate?> GetByIdAsync(Guid id)
        {
            return await _context.ExchangeRates.FirstOrDefaultAsync(x => x.Id == id);
        }

        // Добавить новый курс
        public async Task AddAsync(ExchangeRate entity)
        {
            await _context.ExchangeRates.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        // Обновить курс
        public async Task UpdateAsync(ExchangeRate entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Удалить курс
        public async Task DeleteAsync(Guid id)
        {
            var rate = new ExchangeRate { Id = id };
            _context.ExchangeRates.Attach(rate);
            _context.Entry(rate).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        // Получить курс обмена для пары валют
        public async Task<ExchangeRate?> GetRateAsync(Guid fromCurrencyId, Guid toCurrencyId)
        {
            return await _context.ExchangeRates
                .FirstOrDefaultAsync(rate => rate.FromCurrencyId == fromCurrencyId && rate.ToCurrencyId == toCurrencyId);
        }
    }
}
