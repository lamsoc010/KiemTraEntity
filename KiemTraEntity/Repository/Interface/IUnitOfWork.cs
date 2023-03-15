using Microsoft.EntityFrameworkCore;

namespace KiemTraEntity.Repository.Interface
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IImageRepository ImageRepository { get; }
        IProductImageRepository ProductImageRepository { get; }
        IProductRepository ProductRepository { get; }

        public void SaveChanges();

        public void CreateTransaction();

        public void Commit();

        public void Rollback();
    }
}
