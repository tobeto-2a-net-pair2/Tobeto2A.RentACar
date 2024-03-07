using FluentValidation;

namespace Application.Features.CarColors.Commands.Update;

public class UpdateCarColorCommandValidator : AbstractValidator<UpdateCarColorCommand>
{
    public UpdateCarColorCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.ColorId).NotEmpty();
        RuleFor(c => c.CarColorName).NotEmpty();
    }
}