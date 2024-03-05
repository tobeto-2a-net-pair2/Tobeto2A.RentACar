using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.CorporateCustomers.Queries.GetById;

public class GetByIdCorporateCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public Customer? Customer { get; set; }
}