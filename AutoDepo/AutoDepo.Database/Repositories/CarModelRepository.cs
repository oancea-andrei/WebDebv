using AutoDepoDB.Database.Context;
using AutoDepoDB.Database.Entities;

namespace AutoDepoDB.Database.Repositories
{
    public class CarModelRepository : BaseRepository, ICarModelRepository
    {
        public CarModelRepository(AutoDepoDBContext context) : base(context)
        {
        }

        public int CreateCarModel(CarModel car_model)
        {
            var car_brand = _autodepoDBContext.CarBrand.Find(car_model.CarBrandID);

            if(car_brand == null)
            {
                // Create middleware to handle exceptions
                throw new Exception("CarBrand not found");
            }

            _autodepoDBContext.CarModel.Add(car_model);
            _autodepoDBContext.SaveChanges();

            return car_model.Id;
        }
    }
}
