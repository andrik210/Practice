using Practice.Domain.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> IsUniqueAsync(User user);
        Task<List<User>> GetManyAsync();
    }
}
