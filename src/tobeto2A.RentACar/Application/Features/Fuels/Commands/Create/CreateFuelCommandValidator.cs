﻿using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Fuels.Commands.Create;
public class CreateFuelCommandValidator:AbstractValidator <CreateFuelCommand>
{
    public CreateFuelCommandValidator()
    {
        // FluentValidation
        RuleFor(i => i.Name).NotEmpty().NotNull().MinimumLength(2);
    }

}
