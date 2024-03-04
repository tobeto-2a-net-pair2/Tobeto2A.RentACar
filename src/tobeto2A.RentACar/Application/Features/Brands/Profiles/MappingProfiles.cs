using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Features.Brands.Profiles;
public class MappingProfiles:AutoMapper.Profile //TODO: Neden AutoMapper.Profile oluyor?   
{
    public MappingProfiles()
    {
        //CreateMap<CreateBrandCommand, Brand>();
        //CreateMap<Brand, CreateBrandCommand>();
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();
        CreateMap<Brand, GetListBrandItemDto>().ReverseMap();
        CreateMap<IPaginate<Brand>, GetListResponse<GetListBrandItemDto>>().ReverseMap();
    }


}
