using AutoDepoDB.Database.Entities;

namespace AutoDepoDB.Database.Repositories
{
    public interface ICarModelRepository
    {
        int CreateCarModel(CarModel car_model);
    }
}
