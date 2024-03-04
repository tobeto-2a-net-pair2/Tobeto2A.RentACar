using Application.Features.Brands.Constants;
using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Performance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommand : IRequest<CreatedBrandResponse>, ISecuredRequest, ILoggableRequest, IIntervalRequest
{
    public string Name { get; set; }
    public string Logo { get; set; }


    // || -> Veya var roller arasında. İkisi de şart değil.
    public string[] Roles => new string[] { BrandsOperationClaims.Write, BrandsOperationClaims.Create };

    public int Interval => 3;


    // Command çalıştığında gerçekleşecek somut kod. "Inner Class" olarak yazıldı.
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        private readonly BrandBusinessRules _brandBusinessRules;

        public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
            _brandBusinessRules = brandBusinessRules;
        }

        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            await Task.Delay(5000);
            // Thread.Sleep(5000) => Sync (Senkron olsaydı böyle olacaktı.)

            await _brandBusinessRules.BrandShouldNotExistsWithSameName(request.Name);  // Request'den gelen name ile kuralı kontrol et. Aynı isimde bir marka var ise exception fırlat.

            Brand brand = _mapper.Map<Brand>(request);  // Brand'i request'den mapledik.

            Brand addedBrand = await _brandRepository.AddAsync(brand);

            CreatedBrandResponse createdBrandResponse = _mapper.Map<CreatedBrandResponse>(addedBrand);  // CreatedBrandResponse'u addedBrand'den mapledik.

            return createdBrandResponse;
        }
    }
}