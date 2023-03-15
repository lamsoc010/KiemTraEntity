using KiemTraEntity.Connect;
using KiemTraEntity.Models;
using KiemTraEntity.Repository.Interface;

namespace KiemTraEntity.Repository
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        private readonly ApplicationConnect _context;

        public ImageRepository(ApplicationConnect context) : base(context)
        {
            _context = context;
        }
    }
}
