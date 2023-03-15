using KiemTraEntity.Models;
using System.Linq.Expressions;

namespace KiemTraEntity.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        T Create(T t);
        ICollection<T> GetAll();
        T? Update(T t, object key);
        void Delete(T entity);
        T? Get(int id);
        ICollection<T> Get(Expression<Func<T, bool>> match);
        ICollection<T> Get(Expression<Func<T, bool>> match, int pageSize, int pageIndex, out int total);
    }
}
