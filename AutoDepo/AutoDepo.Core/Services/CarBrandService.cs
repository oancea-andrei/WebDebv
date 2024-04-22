using AutoDepoDB.Core.Dtos.Request;
using AutoDepoDB.Core.Dtos.Response;
using AutoDepoDB.Core.Mapping;
using AutoDepoDB.Database.Entities;
using AutoDepoDB.Database.Repositories;

namespace AutoDepoDB.Core.Services
{
    public class CarBrandService : ICarBrandService
    {
        private readonly ICarBrandRepository _carModelRepository;

        public CarBrandService(ICarBrandRepository carBrandRepository)
        {
            _carModelRepository = carBrandRepository;
        }

        public List<CarBrandResponseDto> GetCarBrands()
        {
            List<CarBrand> car_brands = _carModelRepository.GetCarBrands();

            List<CarBrandResponseDto> carModelResponseDtos = new List<CarBrandResponseDto>();

            foreach (CarBrand car_brand in car_brands)
            {
                carModelResponseDtos.Add(car_brand.ToCarModelResponseDto());
            }

            return carModelResponseDtos;
        }

        public int CreateCarBrand(CarBrandRequestDto car_brand)
        {
            int id = _carModelRepository.CreatCarBrand(car_brand.ToCarBrand());
            return id;
        }
    }
}
