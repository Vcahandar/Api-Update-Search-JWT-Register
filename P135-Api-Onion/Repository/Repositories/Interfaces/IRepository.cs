using Domain.Common;
using System.Collections;
using System.Linq.Expressions;

namespace Repository.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int? id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task SoftDeleteAsync(T entity);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> expression = null);
    }
}
