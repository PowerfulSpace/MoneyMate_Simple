using FluentValidation;
using PS.MoneyMate_Simple.Models;

namespace PS.MoneyMate_Simple.Validations
{
    public class ExchangeRateViewModelValidator : AbstractValidator<ExchangeRateViewModel>
    {
        public ExchangeRateViewModelValidator()
        {
            // Проверка на то, что Id не пустой
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Идентификатор обменного курса не может быть пустым.");

            // Проверка на то, что FromCurrencyId не пустой
            RuleFor(x => x.FromCurrencyId)
                .NotEmpty().WithMessage("Идентификатор валюты-отправителя не может быть пустым.");

            // Проверка на то, что FromCurrencyCode не пустой
            RuleFor(x => x.FromCurrencyCode)
                .NotEmpty().WithMessage("Код валюты-отправителя не может быть пустым.")
                .Length(3).WithMessage("Код валюты-отправителя должен содержать ровно 3 символа.")
                .Matches("^[A-Z]{3}$").WithMessage("Код валюты-отправителя должен состоять из 3 заглавных букв.");

            // Проверка на то, что ToCurrencyId не пустой
            RuleFor(x => x.ToCurrencyId)
                .NotEmpty().WithMessage("Идентификатор валюты-получателя не может быть пустым.");

            // Проверка на то, что ToCurrencyCode не пустой
            RuleFor(x => x.ToCurrencyCode)
                .NotEmpty().WithMessage("Код валюты-получателя не может быть пустым.")
                .Length(3).WithMessage("Код валюты-получателя должен содержать ровно 3 символа.")
                .Matches("^[A-Z]{3}$").WithMessage("Код валюты-получателя должен состоять из 3 заглавных букв.");

            // Проверка на то, что Rate больше 0
            RuleFor(x => x.Rate)
                .GreaterThan(0).WithMessage("Обменный курс должен быть больше 0.");

            // Проверка на то, что LastUpdated не в будущем
            RuleFor(x => x.LastUpdated)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Дата обновления обменного курса не может быть в будущем.");
        }
    }
}
