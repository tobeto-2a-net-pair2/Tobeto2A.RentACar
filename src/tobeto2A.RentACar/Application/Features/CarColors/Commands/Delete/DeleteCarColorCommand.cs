using Application.Features.CarColors.Constants;
using Application.Features.CarColors.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.CarColors.Commands.Delete;

public class DeleteCarColorCommand : IRequest<DeletedCarColorResponse>
{
    public Guid Id { get; set; }

    public class DeleteCarColorCommandHandler : IRequestHandler<DeleteCarColorCommand, DeletedCarColorResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarColorRepository _carColorRepository;
        private readonly CarColorBusinessRules _carColorBusinessRules;

        public DeleteCarColorCommandHandler(IMapper mapper, ICarColorRepository carColorRepository,
                                         CarColorBusinessRules carColorBusinessRules)
        {
            _mapper = mapper;
            _carColorRepository = carColorRepository;
            _carColorBusinessRules = carColorBusinessRules;
        }

        public async Task<DeletedCarColorResponse> Handle(DeleteCarColorCommand request, CancellationToken cancellationToken)
        {
            CarColor? carColor = await _carColorRepository.GetAsync(predicate: cc => cc.Id == request.Id, cancellationToken: cancellationToken);
            await _carColorBusinessRules.CarColorShouldExistWhenSelected(carColor);

            await _carColorRepository.DeleteAsync(carColor!);

            DeletedCarColorResponse response = _mapper.Map<DeletedCarColorResponse>(carColor);
            return response;
        }
    }
}