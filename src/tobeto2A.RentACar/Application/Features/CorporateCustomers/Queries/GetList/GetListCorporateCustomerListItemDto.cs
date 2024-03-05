using Domain.Entities;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.CorporateCustomers.Queries.GetList;

public class GetListCorporateCustomerListItemDto : IDto
{
    public Guid Id { get; set; }
    public int CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public Customer? Customer { get; set; }
}