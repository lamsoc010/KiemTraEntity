using KiemTraEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace KiemTraEntity.Connect
{
    public class ApplicationConnect : DbContext
    {
        public ApplicationConnect(DbContextOptions<ApplicationConnect> options) : base(options)
        {

        }

        public DbSet<Product> products { get; set; }
        public DbSet<ProductImage> product_image { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
