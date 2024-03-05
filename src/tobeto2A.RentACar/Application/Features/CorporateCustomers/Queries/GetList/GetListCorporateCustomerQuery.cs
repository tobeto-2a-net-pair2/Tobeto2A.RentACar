using Application.Features.CorporateCustomers.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.CorporateCustomers.Constants.CorporateCustomersOperationClaims;

namespace Application.Features.CorporateCustomers.Queries.GetList;

public class GetListCorporateCustomerQuery : IRequest<GetListResponse<GetListCorporateCustomerListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListCorporateCustomers({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetCorporateCustomers";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListCorporateCustomerQueryHandler : IRequestHandler<GetListCorporateCustomerQuery, GetListResponse<GetListCorporateCustomerListItemDto>>
    {
        private readonly ICorporateCustomerRepository _corporateCustomerRepository;
        private readonly IMapper _mapper;

        public GetListCorporateCustomerQueryHandler(ICorporateCustomerRepository corporateCustomerRepository, IMapper mapper)
        {
            _corporateCustomerRepository = corporateCustomerRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListCorporateCustomerListItemDto>> Handle(GetListCorporateCustomerQuery request, CancellationToken cancellationToken)
        {
            IPaginate<CorporateCustomer> corporateCustomers = await _corporateCustomerRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListCorporateCustomerListItemDto> response = _mapper.Map<GetListResponse<GetListCorporateCustomerListItemDto>>(corporateCustomers);
            return response;
        }
    }
}