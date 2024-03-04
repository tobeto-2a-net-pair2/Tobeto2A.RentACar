using FluentValidation;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
{
    public CreateBrandCommandValidator()
    {
        //FluentValidation
        RuleFor(i => i.Name).NotEmpty().NotNull().MinimumLength(2);
    }
    
}