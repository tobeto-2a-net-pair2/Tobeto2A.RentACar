using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Models.Queries.GetById;

public class GetByIdModelResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BrandId { get; set; }
    public string Name { get; set; }
    public Guid FuelId { get; set; }
    public Guid TransmissionId { get; set; }
    public decimal DailyPrice { get; set; }
    public short Year { get; set; }
    public virtual  Brand? Brand { get; set; }
    public virtual Transmission? Transmission { get; set; }
    public virtual Fuel? Fuel { get; set; }
}