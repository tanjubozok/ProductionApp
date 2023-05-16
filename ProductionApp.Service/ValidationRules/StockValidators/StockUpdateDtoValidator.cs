using FluentValidation;
using ProductionApp.DTOs.StockDtos;

namespace ProductionApp.Service.ValidationRules.StockValidators;

public class StockUpdateDtoValidator : AbstractValidator<StockUpdateDto>
{
    public StockUpdateDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id boş olamaz");

        RuleFor(x => x.Code)
            .NotEmpty().WithMessage("Stok kodu boş olamaz")
            .MinimumLength(3).WithMessage("Stok kodu en az 3 karakter olmalıdır")
            .MaximumLength(10).WithMessage("Stok kodu en fazla 10 karakter olmalıdır");

        RuleFor(x => x.Code)
            .NotEmpty().WithMessage("Stok adı boş olamaz")
            .MinimumLength(3).WithMessage("Stok adı en az 3 karakter olmalıdır")
            .MaximumLength(200).WithMessage("Stok adı en fazla 10 karakter olmalıdır");

        RuleFor(x => x.Description)
            .MinimumLength(3).WithMessage("Stok açıklama en az 3 karakter olmalıdır")
            .MaximumLength(2000).WithMessage("Stok açıklama en fazla 10 karakter olmalıdır");

        RuleFor(x => x.GroupId)
            .NotEmpty().WithMessage("Grup zorunlu alandır")
            .ExclusiveBetween(0, int.MaxValue).WithMessage("Grup seçiniz");

        RuleFor(x => x.VAT)
            .NotEmpty().WithMessage("KDV alanı boş olamaz.")
            .ExclusiveBetween(0, 100).WithMessage("KDV giriniz");

        RuleFor(x => x.Price)
            .NotEmpty().WithMessage("Fiyat alanı boş olamaz.")
            .GreaterThan(0).WithMessage("Fiyat alanı sıfırdan büyük olmalıdır.");
    }
}
