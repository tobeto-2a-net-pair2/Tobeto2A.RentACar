using Application.Features.Transmissions.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Transmissions.Commands.Create;

public class CreateTransmissionCommand : IRequest<CreatedTransmissionResponse>
{
    public string Name { get; set; }

}

public class CreateTransmissionCommandHandler : IRequestHandler<CreateTransmissionCommand, CreatedTransmissionResponse>
{
    private readonly ITransmissionRepository _transmissionRepository;
    private readonly IMapper _mapper;
    private readonly TransmissionBusinessRules _transmissionBusinessRules;

    public CreateTransmissionCommandHandler(ITransmissionRepository transmissionRepository, IMapper mapper, TransmissionBusinessRules transmissionBusinessRules)
    {
        _transmissionRepository = transmissionRepository;
        _mapper = mapper;
        _transmissionBusinessRules = transmissionBusinessRules;
    }

    public async Task<CreatedTransmissionResponse> Handle(CreateTransmissionCommand request, CancellationToken cancellationToken)
    {
        // await _transmissionBusinessRules."Buraya TransmissionBusinessRules'ta bir method tanımla - TODO"

        Transmission transmission = _mapper.Map<Transmission>(request);

        Transmission addedTransmission = await _transmissionRepository.AddAsync(transmission);

        CreatedTransmissionResponse createdTransmissionResponse = _mapper.Map<CreatedTransmissionResponse>(addedTransmission);

        return createdTransmissionResponse;
    }
}

