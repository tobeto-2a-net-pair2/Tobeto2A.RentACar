using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.CorporateCustomers.Commands.Update;

public class UpdatedCorporateCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public Customer? Customer { get; set; }
}