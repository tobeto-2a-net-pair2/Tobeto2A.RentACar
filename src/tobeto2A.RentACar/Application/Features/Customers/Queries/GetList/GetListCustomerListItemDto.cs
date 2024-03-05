using Domain.Entities;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Customers.Queries.GetList;

public class GetListCustomerListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public IndividualCustomer? IndividualCustomers { get; set; }
    public CorporateCustomer? CorporateCustomers { get; set; }
}