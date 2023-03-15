using KiemTraEntity.Connect;
using KiemTraEntity.Models;
using KiemTraEntity.Repository.Interface;

namespace KiemTraEntity.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationConnect _context;

        public UnitOfWork(ApplicationConnect context, ICategoryRepository categoryRepository, IImageRepository imageRepository,
            IProductImageRepository productImageRepository, IProductRepository productRepository)
        {
            _context = context;
            CategoryRepository = categoryRepository;
            ImageRepository = imageRepository;
            ProductImageRepository = productImageRepository;
            ProductRepository = productRepository;
        }

        public ICategoryRepository CategoryRepository { get; }
        public IImageRepository ImageRepository { get; }
        public IProductImageRepository ProductImageRepository { get; }
        public IProductRepository ProductRepository { get; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void CreateTransaction()
        {

        }

        public void Commit() { 
        }

        public void Rollback()
        {
            _context.Dispose();
        }


    }
}
