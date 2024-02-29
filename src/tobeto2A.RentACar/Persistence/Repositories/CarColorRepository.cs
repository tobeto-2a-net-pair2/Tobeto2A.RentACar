using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;
public class CarColorRepository : EfRepositoryBase<CarColor, Guid, BaseDbContext>, ICarColorRepository
{
    public CarColorRepository(BaseDbContext context) : base(context)
    {
    }
}
