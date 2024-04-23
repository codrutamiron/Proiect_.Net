using Store.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Store.Core.Dtos.Response;
using Store.Core.Dtos.Request;

namespace Store.Api.Controllers
{
    [Route("api/Brands")]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<List<BrandResponseDto>> GetBrands()
        {
            return Ok(_brandService.GetBrands());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ActionResult<int> CreateBrand([FromBody] BrandRequestDto brand)
        {
            int id = _brandService.CreateBrand(brand);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}
