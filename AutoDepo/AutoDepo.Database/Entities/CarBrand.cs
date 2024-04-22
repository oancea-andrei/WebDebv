namespace AutoDepoDB.Database.Entities
{
    public class CarBrand
    {
        public int Id { get; set; }

        public string BrandName { get; set; }

        public virtual List<CarModel> CarModel { get; set; }
    }
}
