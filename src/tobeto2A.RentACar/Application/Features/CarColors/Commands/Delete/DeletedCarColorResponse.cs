using NArchitecture.Core.Application.Responses;

namespace Application.Features.CarColors.Commands.Delete;

public class DeletedCarColorResponse : IResponse
{
    public Guid Id { get; set; }
}