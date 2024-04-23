using Store.Core.Dtos.Response;
using Store.Core.Dtos.Request;

namespace Store.Core.Services
{
    public interface IBrandService
    {
        List<BrandResponseDto> GetBrands();

        int CreateBrand(BrandRequestDto brand);
    }
}
