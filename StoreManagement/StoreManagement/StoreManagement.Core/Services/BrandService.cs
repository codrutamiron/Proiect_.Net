using Store.Core.Dtos.Request;
using Store.Core.Dtos.Response;
using Store.Core.Mapping;
using Store.Database.Entities;
using Store.Database.Repositories;

namespace Store.Core.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public List<BrandResponseDto> GetBrands()
        {
            List<Brand> brands = _brandRepository.GetBrands();

            List<BrandResponseDto> brandResponseDtos = new List<BrandResponseDto>();

            foreach (Brand brand in brands)
            {
                brandResponseDtos.Add(brand.ToBrandResponseDto());
            }

            return brandResponseDtos;
        }

        public int CreateBrand(BrandRequestDto brand)
        {
            int id = _brandRepository.CreateBrand(brand.ToBrand());
            return id;
        }
    }
}
