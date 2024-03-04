using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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

    
    // TODO: İş kurallarını buraya ekle.
}