using FluentValidation;

namespace Application.Features.CarColors.Commands.Delete;

public class DeleteCarColorCommandValidator : AbstractValidator<DeleteCarColorCommand>
{
    public DeleteCarColorCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}