using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommand : IRequest<CreatedBrandResponse>
{
    public string Name { get; set; }
    public string Logo { get; set; }


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
            await _brandBusinessRules.BrandShouldNotExistsWithSameName(request.Name);  // Request'den gelen name ile kuralı kontrol et. Aynı isimde bir araba var ise exception fırlat.
            
            Brand brand = _mapper.Map<Brand>(request);  // Brand'i request'den mapledik.
            
            Brand addedBrand = await _brandRepository.AddAsync(brand);

            CreatedBrandResponse createdBrandResponse = _mapper.Map<CreatedBrandResponse>(addedBrand);  // CreatedBrandResponse'u addedBrand'den mapledik.
            
            return createdBrandResponse;
        }
    }
}