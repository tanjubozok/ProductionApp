namespace ProductionApp.Service.ValidationRules.GroupValidators;

public class GroupUpdateValidator : AbstractValidator<GroupUpdateDto>
{
    public GroupUpdateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Grup id boş olamaz");

        RuleFor(x => x.Code)
            .NotEmpty().WithMessage("Grup kodu boş olamaz")
            .MinimumLength(3).WithMessage("Grup kodu en az 3 karakter olmalıdır")
            .MaximumLength(20).WithMessage("Grup kodu en fazla 20 karakter olmalıdır");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Grup adı boş olamaz")
            .MinimumLength(3).WithMessage("Grup adı en az 3 karakter olmaldır")
            .MaximumLength(200).WithMessage("Grup adı en fazla 200 karakter  olmalıdır");
    }
}
