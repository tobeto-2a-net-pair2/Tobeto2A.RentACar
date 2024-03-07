using FluentValidation;

namespace Application.Features.CarColors.Commands.Create;

public class CreateCarColorCommandValidator : AbstractValidator<CreateCarColorCommand>
{
    public CreateCarColorCommandValidator()
    {
        RuleFor(c => c.ColorId).NotEmpty();
        RuleFor(c => c.CarColorName).NotEmpty();
    }
}