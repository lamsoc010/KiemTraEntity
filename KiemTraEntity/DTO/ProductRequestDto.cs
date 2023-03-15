
namespace KiemTraEntity.DTO
{
    public class ProductRequestDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public DateTime? DateUpdate { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
    }
}
