using KiemTraEntity.Connect;
using KiemTraEntity.Models;
using KiemTraEntity.Repository.Interface;

namespace KiemTraEntity.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private readonly ApplicationConnect _context;

        public ProductImageRepository(ApplicationConnect context) : base(context)
        {
            _context = context;
        }
    }
}
