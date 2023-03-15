using System.ComponentModel.DataAnnotations.Schema;

namespace KiemTraEntity.Models
{
    public class ProductImage: BaseEntity
    {
        [ForeignKey("IdProduct")]
        public int? ProductId { get; set; }
        [ForeignKey("IdImage")]
        public int? ImageId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Image Image { get; set; }
    }
}
