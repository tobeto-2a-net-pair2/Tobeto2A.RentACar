﻿using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class CorporateCustomer : Entity<Guid>
{
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
    public Guid CustomerId { get; set; }

    public Customer? Customer { get; set; } = null;
}
