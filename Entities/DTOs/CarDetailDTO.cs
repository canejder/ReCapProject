using Entities.Abstract;

namespace Entities.DTOs
{
    public class CarDetailDTO : IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public double DailyPrice { get; set; }
    }
}