namespace AutoDepoDB.Database.Entities
{
    public class CarModel
    {
        public int Id { get; set; }

        public string Series { get; set; }

        public int CarBrandID { get; set; }

        public virtual CarBrand CarBrand { get; set; }
    }
}
