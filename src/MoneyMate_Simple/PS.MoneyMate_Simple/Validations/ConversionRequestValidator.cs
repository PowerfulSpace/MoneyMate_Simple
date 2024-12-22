using FluentValidation;
using PS.MoneyMate_Simple.Models;

namespace PS.MoneyMate_Simple.Validations
{
    public class ConversionRequestViewModelValidator : AbstractValidator<ConversionRequestViewModel>
    {
        public ConversionRequestViewModelValidator()
        {
            // Проверка на то, что Id не пустой
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Идентификатор запроса не может быть пустым.");

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

            // Проверка на то, что Amount больше 0
            RuleFor(x => x.Amount)
                .GreaterThan(0).WithMessage("Сумма для конверсии должна быть больше 0.");

            // Проверка на то, что ConvertedAmount больше 0
            RuleFor(x => x.ConvertedAmount)
                .GreaterThan(0).WithMessage("Конвертированная сумма должна быть больше 0.");

            // Проверка на то, что ConversionDate не в будущем
            RuleFor(x => x.ConversionDate)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Дата конверсии не может быть в будущем.");
        }
    }
}
