using KiemTraEntity.Connect;
using KiemTraEntity.Models;
using KiemTraEntity.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace KiemTraEntity.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationConnect _context;

        public ProductRepository(ApplicationConnect context) : base(context)
        {
            _context = context;
        }
    }
}
