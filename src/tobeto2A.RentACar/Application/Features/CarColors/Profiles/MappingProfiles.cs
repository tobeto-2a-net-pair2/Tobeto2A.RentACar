using Application.Features.CarColors.Commands.Create;
using Application.Features.CarColors.Commands.Delete;
using Application.Features.CarColors.Commands.Update;
using Application.Features.CarColors.Queries.GetById;
using Application.Features.CarColors.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.CarColors.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CarColor, CreateCarColorCommand>().ReverseMap();
        CreateMap<CarColor, CreatedCarColorResponse>().ReverseMap();
        CreateMap<CarColor, UpdateCarColorCommand>().ReverseMap();
        CreateMap<CarColor, UpdatedCarColorResponse>().ReverseMap();
        CreateMap<CarColor, DeleteCarColorCommand>().ReverseMap();
        CreateMap<CarColor, DeletedCarColorResponse>().ReverseMap();
        CreateMap<CarColor, GetByIdCarColorResponse>().ReverseMap();
        CreateMap<CarColor, GetListCarColorListItemDto>().ReverseMap();
        CreateMap<IPaginate<CarColor>, GetListResponse<GetListCarColorListItemDto>>().ReverseMap();
    }
}