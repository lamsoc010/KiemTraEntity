using KiemTraEntity.Connect;
using KiemTraEntity.Models;
using KiemTraEntity.Repository.Interface;

namespace KiemTraEntity.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationConnect _context;

        public CategoryRepository(ApplicationConnect context) : base(context)
        {
            _context = context;
        }
    }
}
