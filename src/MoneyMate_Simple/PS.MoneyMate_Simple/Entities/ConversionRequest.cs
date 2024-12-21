namespace PS.MoneyMate_Simple.Entities
{
    public class ConversionRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Уникальный идентификатор
        public Guid FromCurrencyId { get; set; } // Валюта, из которой конвертируем
        public Guid ToCurrencyId { get; set; } // Валюта, в которую конвертируем
        public decimal Amount { get; set; } // Сумма, которую конвертируем
        public decimal ConvertedAmount { get; set; } // Результат конвертации
        public DateTime ConversionDate { get; set; } = DateTime.UtcNow; // Дата выполнения конверсии
    }
}
