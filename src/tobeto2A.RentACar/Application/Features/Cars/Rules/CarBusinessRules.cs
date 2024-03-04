using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Rules;
public class CarBusinessRules : BaseBusinessRules
{
    private readonly ICarRepository _carRepository;


    public CarBusinessRules(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }


    // TODO: İş kurallarını buraya ekle.
}