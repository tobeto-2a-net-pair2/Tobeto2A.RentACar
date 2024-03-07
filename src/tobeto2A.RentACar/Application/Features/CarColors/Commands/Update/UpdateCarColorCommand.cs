using Application.Features.CarColors.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Domain.Enums;

namespace Application.Features.CarColors.Commands.Update;

public class UpdateCarColorCommand : IRequest<UpdatedCarColorResponse>
{
    public Guid Id { get; set; }
    public Guid ColorId { get; set; }
    public CarColorName CarColorName { get; set; }

    public class UpdateCarColorCommandHandler : IRequestHandler<UpdateCarColorCommand, UpdatedCarColorResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarColorRepository _carColorRepository;
        private readonly CarColorBusinessRules _carColorBusinessRules;

        public UpdateCarColorCommandHandler(IMapper mapper, ICarColorRepository carColorRepository,
                                         CarColorBusinessRules carColorBusinessRules)
        {
            _mapper = mapper;
            _carColorRepository = carColorRepository;
            _carColorBusinessRules = carColorBusinessRules;
        }

        public async Task<UpdatedCarColorResponse> Handle(UpdateCarColorCommand request, CancellationToken cancellationToken)
        {
            CarColor? carColor = await _carColorRepository.GetAsync(predicate: cc => cc.Id == request.Id, cancellationToken: cancellationToken);
            await _carColorBusinessRules.CarColorShouldExistWhenSelected(carColor);
            carColor = _mapper.Map(request, carColor);

            await _carColorRepository.UpdateAsync(carColor!);

            UpdatedCarColorResponse response = _mapper.Map<UpdatedCarColorResponse>(carColor);
            return response;
        }
    }
}