using Application.Features.Fuels.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Fuels.Commands.Create;
public class CreateFuelCommand : IRequest<CreatedFuelResponse>
{
    public string Name { get; set; }
}

public class CreateFuelCommandHandler : IRequestHandler<CreateFuelCommand, CreatedFuelResponse>
{
    private readonly IFuelRepository _fuelRepository;
    private readonly IMapper _mapper;
    private readonly FuelBusinessRules _fuelBusinessRules;

    public CreateFuelCommandHandler(IFuelRepository fuelRepository, IMapper mapper, FuelBusinessRules fuelBusinessRules)
    {
        _fuelRepository = fuelRepository;
        _mapper = mapper;
        _fuelBusinessRules = fuelBusinessRules;
    }

    public async Task<CreatedFuelResponse> Handle(CreateFuelCommand request, CancellationToken cancellationToken)
    {
        // await _fuelBusinessRules."Buraya FuelBusinessRules'ta bir method tanımla - TODO"

        Fuel fuel = _mapper.Map<Fuel>(request);

        Fuel addedFuel = await _fuelRepository.AddAsync(fuel);

        CreatedFuelResponse createdFuelResponse = _mapper.Map<CreatedFuelResponse>(addedFuel);

        return createdFuelResponse;
    }
}
