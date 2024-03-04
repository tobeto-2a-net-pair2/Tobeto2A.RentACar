using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Queries.GetList;
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


namespace Application.Features.Fuels.Profiles;
public class MappingProfiles:AutoMapper.Profile //TODO: Neden AutoMapper.Profile oluyor?   
{
    public MappingProfiles()
    {
   
        CreateMap<Fuel, CreateFuelCommand>().ReverseMap();
        CreateMap<Fuel, CreatedFuelResponse>().ReverseMap();
        CreateMap<Fuel, GetListFuelItemDto>().ReverseMap();
        CreateMap<IPaginate<Fuel>, GetListResponse<GetListFuelItemDto>>().ReverseMap();
    }


}
