using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Customers.Commands.Update;

public class UpdatedCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public IndividualCustomer? IndividualCustomers { get; set; }
    public CorporateCustomer? CorporateCustomers { get; set; }
}