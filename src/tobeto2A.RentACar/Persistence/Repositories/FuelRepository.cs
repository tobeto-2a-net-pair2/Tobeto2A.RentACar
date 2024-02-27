﻿using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;
public class FuelRepository : EfRepositoryBase<Fuel, Guid, BaseDbContext>
{
    public FuelRepository(BaseDbContext context) : base(context)
    {
    }
}
