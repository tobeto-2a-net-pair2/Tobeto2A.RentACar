using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ICarColorRepository : IAsyncRepository<CarColor, Guid>, IRepository<CarColor, Guid>
{
}