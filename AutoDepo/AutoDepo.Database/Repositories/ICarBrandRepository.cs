using AutoDepoDB.Database.Entities;

namespace AutoDepoDB.Database.Repositories
{
    public interface ICarBrandRepository
    {
        List<CarBrand> GetCarBrands(); 

        int CreatCarBrand(CarBrand car_brand);
    }
}
