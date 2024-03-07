using Application.Features.CarColors.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.CarColors;

public class CarColorManager : ICarColorService
{
    private readonly ICarColorRepository _carColorRepository;
    private readonly CarColorBusinessRules _carColorBusinessRules;

    public CarColorManager(ICarColorRepository carColorRepository, CarColorBusinessRules carColorBusinessRules)
    {
        _carColorRepository = carColorRepository;
        _carColorBusinessRules = carColorBusinessRules;
    }

    public async Task<CarColor?> GetAsync(
        Expression<Func<CarColor, bool>> predicate,
        Func<IQueryable<CarColor>, IIncludableQueryable<CarColor, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        CarColor? carColor = await _carColorRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return carColor;
    }

    public async Task<IPaginate<CarColor>?> GetListAsync(
        Expression<Func<CarColor, bool>>? predicate = null,
        Func<IQueryable<CarColor>, IOrderedQueryable<CarColor>>? orderBy = null,
        Func<IQueryable<CarColor>, IIncludableQueryable<CarColor, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<CarColor> carColorList = await _carColorRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return carColorList;
    }

    public async Task<CarColor> AddAsync(CarColor carColor)
    {
        CarColor addedCarColor = await _carColorRepository.AddAsync(carColor);

        return addedCarColor;
    }

    public async Task<CarColor> UpdateAsync(CarColor carColor)
    {
        CarColor updatedCarColor = await _carColorRepository.UpdateAsync(carColor);

        return updatedCarColor;
    }

    public async Task<CarColor> DeleteAsync(CarColor carColor, bool permanent = false)
    {
        CarColor deletedCarColor = await _carColorRepository.DeleteAsync(carColor);

        return deletedCarColor;
    }
}
