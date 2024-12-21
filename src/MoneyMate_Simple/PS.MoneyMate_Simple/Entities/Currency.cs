namespace PS.MoneyMate_Simple.Entities
{
    public class Currency
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Уникальный идентификатор
        public string Code { get; set; } = string.Empty; // Код валюты (например, USD)
        public string Name { get; set; } = string.Empty; // Название валюты (например, "United States Dollar")
        public string Symbol { get; set; } = string.Empty; // Символ валюты (например, "$")
        public bool IsActive { get; set; } = true; // Флаг активности
    }
}
