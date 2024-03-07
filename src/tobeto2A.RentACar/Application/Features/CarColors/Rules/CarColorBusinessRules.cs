using Application.Features.CarColors.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.CarColors.Rules;

public class CarColorBusinessRules : BaseBusinessRules
{
    private readonly ICarColorRepository _carColorRepository;
    private readonly ILocalizationService _localizationService;

    public CarColorBusinessRules(ICarColorRepository carColorRepository, ILocalizationService localizationService)
    {
        _carColorRepository = carColorRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, CarColorsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task CarColorShouldExistWhenSelected(CarColor? carColor)
    {
        if (carColor == null)
            await throwBusinessException(CarColorsBusinessMessages.CarColorNotExists);
    }

    public async Task CarColorIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        CarColor? carColor = await _carColorRepository.GetAsync(
            predicate: cc => cc.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await CarColorShouldExistWhenSelected(carColor);
    }
}