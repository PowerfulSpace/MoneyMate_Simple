namespace PS.MoneyMate_Simple.Entities
{
    public class ExchangeRate
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Уникальный идентификатор
        public Guid FromCurrencyId { get; set; } // Валюта, из которой конвертируем
        public Guid ToCurrencyId { get; set; } // Валюта, в которую конвертируем
        public decimal Rate { get; set; } // Курс обмена
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow; // Последнее обновление курса
    }
}
