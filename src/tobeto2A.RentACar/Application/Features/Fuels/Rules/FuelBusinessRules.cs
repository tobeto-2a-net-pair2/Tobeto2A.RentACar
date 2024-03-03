using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Fuels.Rules;
public class FuelBusinessRules : BaseBusinessRules
{
    private readonly IFuelRepository _fuelRepository;


    public FuelBusinessRules(IFuelRepository fuelRepository)
    {
        _fuelRepository = fuelRepository;
    }
}