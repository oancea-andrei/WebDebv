using AutoDepoDB.Core.Dtos.Response;
using AutoDepoDB.Core.Dtos.Request;

namespace AutoDepoDB.Core.Services
{
    public interface ICarBrandService
    {
        List<CarBrandResponseDto> GetCarBrands();

        int CreateCarBrand(CarBrandRequestDto car_brand);
    }
}
