using NArchitecture.Core.Application.Dtos;
using Domain.Enums;

namespace Application.Features.CarColors.Queries.GetList;

public class GetListCarColorListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid ColorId { get; set; }
    public CarColorName CarColorName { get; set; }
}