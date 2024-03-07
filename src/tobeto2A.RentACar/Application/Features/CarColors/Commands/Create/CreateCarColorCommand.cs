using Application.Features.CarColors.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Domain.Enums;

namespace Application.Features.CarColors.Commands.Create;

public class CreateCarColorCommand : IRequest<CreatedCarColorResponse>
{
    public Guid ColorId { get; set; }
    public CarColorName CarColorName { get; set; }

    public class CreateCarColorCommandHandler : IRequestHandler<CreateCarColorCommand, CreatedCarColorResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarColorRepository _carColorRepository;
        private readonly CarColorBusinessRules _carColorBusinessRules;

        public CreateCarColorCommandHandler(IMapper mapper, ICarColorRepository carColorRepository,
                                         CarColorBusinessRules carColorBusinessRules)
        {
            _mapper = mapper;
            _carColorRepository = carColorRepository;
            _carColorBusinessRules = carColorBusinessRules;
        }

        public async Task<CreatedCarColorResponse> Handle(CreateCarColorCommand request, CancellationToken cancellationToken)
        {
            CarColor carColor = _mapper.Map<CarColor>(request);

            await _carColorRepository.AddAsync(carColor);

            CreatedCarColorResponse response = _mapper.Map<CreatedCarColorResponse>(carColor);
            return response;
        }
    }
}