using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.CarColors;

public interface ICarColorService
{
    Task<CarColor?> GetAsync(
        Expression<Func<CarColor, bool>> predicate,
        Func<IQueryable<CarColor>, IIncludableQueryable<CarColor, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<CarColor>?> GetListAsync(
        Expression<Func<CarColor, bool>>? predicate = null,
        Func<IQueryable<CarColor>, IOrderedQueryable<CarColor>>? orderBy = null,
        Func<IQueryable<CarColor>, IIncludableQueryable<CarColor, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<CarColor> AddAsync(CarColor carColor);
    Task<CarColor> UpdateAsync(CarColor carColor);
    Task<CarColor> DeleteAsync(CarColor carColor, bool permanent = false);
}
