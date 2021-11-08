using Practice.Domain.Entities;
using System.Threading.Tasks;

namespace Practice.Domain.Repositories
{
    public interface IRepository<T> where T: BaseEntity
    {
        Task<T> GetAsync(string id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(string id);
    }
}
