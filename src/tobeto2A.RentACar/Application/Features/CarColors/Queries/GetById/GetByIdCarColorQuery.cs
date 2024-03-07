using Application.Features.CarColors.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.CarColors.Queries.GetById;

public class GetByIdCarColorQuery : IRequest<GetByIdCarColorResponse>
{
    public Guid Id { get; set; }

    public class GetByIdCarColorQueryHandler : IRequestHandler<GetByIdCarColorQuery, GetByIdCarColorResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarColorRepository _carColorRepository;
        private readonly CarColorBusinessRules _carColorBusinessRules;

        public GetByIdCarColorQueryHandler(IMapper mapper, ICarColorRepository carColorRepository, CarColorBusinessRules carColorBusinessRules)
        {
            _mapper = mapper;
            _carColorRepository = carColorRepository;
            _carColorBusinessRules = carColorBusinessRules;
        }

        public async Task<GetByIdCarColorResponse> Handle(GetByIdCarColorQuery request, CancellationToken cancellationToken)
        {
            CarColor? carColor = await _carColorRepository.GetAsync(predicate: cc => cc.Id == request.Id, cancellationToken: cancellationToken);
            await _carColorBusinessRules.CarColorShouldExistWhenSelected(carColor);

            GetByIdCarColorResponse response = _mapper.Map<GetByIdCarColorResponse>(carColor);
            return response;
        }
    }
}