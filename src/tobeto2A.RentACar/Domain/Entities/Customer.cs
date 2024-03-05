using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Customer : Entity<Guid>
{
    public Guid UserId { get; set; }

    public User? User { get; set; } = null;
    public IndividualCustomer? IndividualCustomers { get; set; } = null;
    public CorporateCustomer? CorporateCustomers { get; set; } = null;
}
