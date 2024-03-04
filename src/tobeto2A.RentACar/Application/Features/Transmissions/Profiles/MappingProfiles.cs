using Application.Features.Transmissions.Commands.Create;
using Application.Features.Transmissions.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Transmissions.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Transmission, CreateTransmissionCommand>().ReverseMap();
        CreateMap<Transmission, CreatedTransmissionResponse>().ReverseMap();
        CreateMap<Transmission, GetListTransmissionItemDto>().ReverseMap();
        CreateMap<IPaginate<Transmission>, GetListResponse<GetListTransmissionItemDto>>().ReverseMap();
    }
}