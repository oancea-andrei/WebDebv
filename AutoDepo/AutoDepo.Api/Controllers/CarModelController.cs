using AutoDepoDB.Core.Dtos.Request;
using AutoDepoDB.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoDepoDB.Api.Controllers
{
    [Route("api/CarModel")]
    public class CarModelController : ControllerBase
    {
        private readonly ICarModelService _car_modelService;

        public CarModelController(ICarModelService car_modelService)
        {
            _car_modelService = car_modelService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<int> CreateCarModel([FromBody] CarModelRequestDto car_model)
        {
            int id = _car_modelService.CreateCarModel(car_model);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}
