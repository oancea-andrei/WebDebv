using AutoDepoDB.Core.Dtos.Request;
using AutoDepoDB.Core.Dtos.Response;
using AutoDepoDB.Database.Entities;

namespace AutoDepoDB.Core.Mapping
{
    public static class CarBrandMappingExtensions
    {
        public static CarBrandResponseDto ToCarModelResponseDto(this CarBrand car_brand)
        {
            var result = new CarBrandResponseDto();

            result.Id = car_brand.Id;
            result.FullName = car_brand.BrandName;

            List<CarModelResponseDto> car_modelDto = new List<CarModelResponseDto>();

            foreach (var car_model in car_brand.CarModel)
            {
                car_modelDto.Add(car_model.ToCarModelResponseDto());
            }

            result.CarModels = car_modelDto;

            return result;
        }

        public static CarBrand ToCarBrand(this CarBrandRequestDto car_brand)
        {
            return new CarBrand
            {
                BrandName = car_brand.FullName
            };
        }
    }
}
