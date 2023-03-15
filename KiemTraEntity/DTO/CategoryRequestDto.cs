namespace KiemTraEntity.DTO
{
    public class CategoryRequestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdate { get; set; } = DateTime.Now;
    }
}
