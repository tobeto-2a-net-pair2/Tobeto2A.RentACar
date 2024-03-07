using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.CarColors.Queries.GetById;

public class GetByIdCarColorResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid ColorId { get; set; }
    public CarColorName CarColorName { get; set; }
}