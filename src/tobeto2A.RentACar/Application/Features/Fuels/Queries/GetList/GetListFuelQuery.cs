using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Fuels.Queries.GetList;
public class GetListFuelQuery : IRequest<GetListResponse<GetListFuelItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListFuelQueryHandler : IRequestHandler<GetListFuelQuery, GetListResponse<GetListFuelItemDto>>
    {
        private readonly IFuelRepository _fuelRepository;
        private readonly IMapper _mapper;

        public GetListFuelQueryHandler(IFuelRepository fuelRepository, IMapper mapper)
        {
            _fuelRepository = fuelRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListFuelItemDto>> Handle(GetListFuelQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Fuel> fuels = await _fuelRepository.GetListAsync(index: request.PageRequest.PageIndex, size: request.PageRequest.PageSize);

            GetListResponse<GetListFuelItemDto> response = _mapper.Map<GetListResponse<GetListFuelItemDto>>(fuels);

            return response;
        }
    }
}
