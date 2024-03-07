using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class CarColorRepository : EfRepositoryBase<CarColor, Guid, BaseDbContext>, ICarColorRepository
{
    public CarColorRepository(BaseDbContext context) : base(context)
    {
    }
}