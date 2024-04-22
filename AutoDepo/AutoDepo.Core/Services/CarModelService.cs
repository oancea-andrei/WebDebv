using AutoDepoDB.Core.Dtos.Request;
using AutoDepoDB.Core.Mapping;
using AutoDepoDB.Database.Repositories;

namespace AutoDepoDB.Core.Services
{
    public class CarModelService : ICarModelService
    {
        private readonly ICarModelRepository _carModelRepository;

        public CarModelService(ICarModelRepository CarModelRepository)
        {
            _carModelRepository = CarModelRepository;
        }

        public int CreateCarModel(CarModelRequestDto car_model)
        {
            int id = _carModelRepository.CreateCarModel(car_model.ToCarModel());
            return id;
        }
    }
}
