using Application.Features.Brands.Commands.Create;
using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
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


    public async Task CheckIfFuelExistsForAdd(string name)
    {
        var existingFuel = await _fuelRepository.GetAsync(b => b.Name == name);

        if (existingFuel != null) //  varsa güncelleme yapma
        {
            throw new Exception("Fuel already exists.");
        }
    }
}
