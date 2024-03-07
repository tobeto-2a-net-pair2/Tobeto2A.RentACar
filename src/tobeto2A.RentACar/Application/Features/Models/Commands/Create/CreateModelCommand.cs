using Application.Features.Models.Constants;
using Application.Features.Models.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Models.Constants.ModelsOperationClaims;

namespace Application.Features.Models.Commands.Create;

public class CreateModelCommand : IRequest<CreatedModelResponse>, ISecuredRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid BrandId { get; set; }
    public string Name { get; set; }
    public Guid FuelId { get; set; }
    public Guid TransmissionId { get; set; }
    public decimal DailyPrice { get; set; }
    public short Year { get; set; }
    public Brand? Brand { get; set; }
    public Transmission? Transmission { get; set; }
    public Fuel? Fuel { get; set; }

    public string[] Roles => [Admin, Write, ModelsOperationClaims.Create];

    public class CreateModelCommandHandler : IRequestHandler<CreateModelCommand, CreatedModelResponse>
    {
        private readonly IMapper _mapper;
        private readonly IModelRepository _modelRepository;
        private readonly ModelBusinessRules _modelBusinessRules;

        public CreateModelCommandHandler(IMapper mapper, IModelRepository modelRepository,
                                         ModelBusinessRules modelBusinessRules)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
            _modelBusinessRules = modelBusinessRules;
        }

        public async Task<CreatedModelResponse> Handle(CreateModelCommand request, CancellationToken cancellationToken)
        {
            Model model = _mapper.Map<Model>(request);

            await _modelRepository.AddAsync(model);

            CreatedModelResponse response = _mapper.Map<CreatedModelResponse>(model);
            return response;
        }
    }
}