using Microsoft.EntityFrameworkCore;
using PS.MoneyMate_Simple.Data;
using PS.MoneyMate_Simple.Entities;
using PS.MoneyMate_Simple.Repositories.Interfaces;

namespace PS.MoneyMate_Simple.Repositories.Implementation
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly MoneyMate_SimpleDbContext _context;

        public CurrencyRepository(MoneyMate_SimpleDbContext context)
        {
            _context = context;
        }

        // Получить все валюты
        public async Task<IEnumerable<Currency>> GetAllAsync()
        {
            return await _context.Currencies.ToListAsync();
        }

        // Получить валюту по Id
        public async Task<Currency?> GetByIdAsync(Guid id)
        {
            return await _context.Currencies.FirstOrDefaultAsync(x => x.Id == id);
        }

        // Получить валюту по коду
        public async Task<Currency?> GetByCodeAsync(string code)
        {
            return await _context.Currencies
                .FirstOrDefaultAsync(currency => currency.Code == code);
        }

        // Добавить новую валюту
        public async Task AddAsync(Currency entity)
        {
            await _context.Currencies.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        // Обновить валюту
        public async Task UpdateAsync(Currency entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Удалить валюту
        public async Task DeleteAsync(Guid id)
        {
            var currency = new Currency { Id = id };
            _context.Currencies.Attach(currency);
            _context.Entry(currency).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
