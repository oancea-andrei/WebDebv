using AutoDepoDB.Database.Context;
using AutoDepoDB.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoDepoDB.Database.Repositories
{
    public class CarBrandRepository : BaseRepository, ICarBrandRepository
    {
        public CarBrandRepository(AutoDepoDBContext auto_depoDbContext) : base(auto_depoDbContext)
        {
        }

        public List<CarBrand> GetCarBrands()
        {
            var result = _autodepoDBContext.CarBrand
                .Include(a => a.CarModel)
                .AsNoTracking()
                .ToList();

            return result;
        }

        public int CreatCarBrand(CarBrand car_brand)
        {
            _autodepoDBContext.CarBrand.Add(car_brand);
            _autodepoDBContext.SaveChanges();

            return car_brand.Id;
        }
    }
}
