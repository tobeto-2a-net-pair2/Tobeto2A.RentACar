using Application.Features.Transmissions.Commands.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Fuels.Commands.Create;
public class CreateFuelCommandValidator : AbstractValidator<CreateFuelCommand>
{
    public CreateFuelCommandValidator()
    {
        // Fluent Validation
        // TODO: Buraya RuleFor'ları ekle
    }
}