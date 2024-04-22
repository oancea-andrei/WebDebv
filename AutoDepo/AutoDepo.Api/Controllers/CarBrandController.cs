using AutoDepoDB.Core.Services;
using Microsoft.AspNetCore.Mvc;
using AutoDepoDB.Core.Dtos.Response;
using AutoDepoDB.Core.Dtos.Request;

namespace AutoDepoDB.Api.Controllers
{
    [Route("api/CarBrand")]
    public class CarBrandController : ControllerBase
    {
        private readonly ICarBrandService _carBrandService;
        public CarBrandController(ICarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<List<CarBrandResponseDto>> GetCarBrands()
        {
            return Ok(_carBrandService.GetCarBrands());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ActionResult<int> CreateCarBrand([FromBody] CarBrandRequestDto car_brand)
        {
            int id = _carBrandService.CreateCarBrand(car_brand);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}
