using FluentValidation;
using PS.MoneyMate_Simple.Models;

namespace PS.MoneyMate_Simple.Validations
{
    public class CurrencyViewModelValidator : AbstractValidator<CurrencyViewModel>
    {
        public CurrencyViewModelValidator()
        {
            // Проверка на то, что Id является валидным Guid
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Идентификатор не может быть пустым.");

            // Проверка кода валюты
            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Код валюты обязателен.")
                .Length(3).WithMessage("Код валюты должен содержать ровно 3 символа.")
                .Matches("^[A-Z]{3}$").WithMessage("Код валюты должен состоять из 3 заглавных букв.");

            // Проверка имени валюты
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Название валюты обязательно.")
                .MaximumLength(100).WithMessage("Название валюты не может превышать 100 символов.");

            // Проверка символа валюты
            RuleFor(x => x.Symbol)
                .NotEmpty().WithMessage("Символ валюты обязателен.")
                .MaximumLength(10).WithMessage("Символ валюты не может превышать 10 символов.");

            // Проверка статуса активности
            RuleFor(x => x.IsActive)
                .NotNull().WithMessage("Необходимо указать статус активности.");
        }
    }
}
