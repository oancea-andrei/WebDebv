using AutoDepoDB.Core.Dtos.Request;

namespace AutoDepoDB.Core.Services
{
    public interface ICarModelService
    {
        int CreateCarModel(CarModelRequestDto car_model);
    }
}
