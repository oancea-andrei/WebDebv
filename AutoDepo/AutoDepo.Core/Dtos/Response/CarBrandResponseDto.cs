namespace AutoDepoDB.Core.Dtos.Response
{
    public class CarBrandResponseDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public List<CarModelResponseDto> CarModels { get; set; }
    }
}
