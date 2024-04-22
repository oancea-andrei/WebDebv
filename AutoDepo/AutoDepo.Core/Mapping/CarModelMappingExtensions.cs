using AutoDepoDB.Core.Dtos.Request;
using AutoDepoDB.Core.Dtos.Response;
using AutoDepoDB.Database.Entities;

namespace AutoDepoDB.Core.Mapping
{
    public static class CarModelMappingExtensions
    {
        public static CarModelResponseDto ToCarModelResponseDto(this CarModel car_model)
        {
            var result = new CarModelResponseDto
            {
                Id = car_model.Id,
                Name = car_model.Series,
            };

            return result;
        }

        public static CarModel ToCarModel(this CarModelRequestDto car_model)
        {
            return new CarModel
            {
                Series = car_model.Name,
                CarBrandID = car_model.CarBrandID
            };
        }
    }
}
