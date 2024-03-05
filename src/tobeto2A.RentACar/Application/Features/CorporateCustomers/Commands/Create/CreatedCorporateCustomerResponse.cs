using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.CorporateCustomers.Commands.Create;

public class CreatedCorporateCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public Customer? Customer { get; set; }
}