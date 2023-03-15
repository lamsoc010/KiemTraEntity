namespace KiemTraEntity.Models
{
    public class Image : BaseEntity
    {
        public string FileName { get; set; }
        public virtual ICollection<ProductImage>? ProductImages { get; set; }
    }
}
