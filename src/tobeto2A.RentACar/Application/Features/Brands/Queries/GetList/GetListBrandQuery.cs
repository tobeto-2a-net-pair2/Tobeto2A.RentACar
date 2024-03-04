using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Nest;

namespace Application.Features.Brands.Queries.GetList;

public class GetListBrandQuery : IRequest<GetListResponse<GetListBrandItemDto>>
{
    //sayfalama (pagination)

    
    
    
    public PageRequest PageRequest { get; set; }

    public class GetListBrandQueryHandler(IBrandRepository brandRepositoryi IMapper mapper)
    {
        
    }
}