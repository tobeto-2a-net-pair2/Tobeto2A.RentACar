using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;

namespace Application.Features.CarColors.Queries.GetList;

public class GetListCarColorQuery : IRequest<GetListResponse<GetListCarColorListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListCarColorQueryHandler : IRequestHandler<GetListCarColorQuery, GetListResponse<GetListCarColorListItemDto>>
    {
        private readonly ICarColorRepository _carColorRepository;
        private readonly IMapper _mapper;

        public GetListCarColorQueryHandler(ICarColorRepository carColorRepository, IMapper mapper)
        {
            _carColorRepository = carColorRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListCarColorListItemDto>> Handle(GetListCarColorQuery request, CancellationToken cancellationToken)
        {
            IPaginate<CarColor> carColors = await _carColorRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListCarColorListItemDto> response = _mapper.Map<GetListResponse<GetListCarColorListItemDto>>(carColors);
            return response;
        }
    }
}