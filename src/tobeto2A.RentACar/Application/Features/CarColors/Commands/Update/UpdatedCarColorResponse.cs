using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.CarColors.Commands.Update;

public class UpdatedCarColorResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid ColorId { get; set; }
    public CarColorName CarColorName { get; set; }
}