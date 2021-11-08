using Microsoft.EntityFrameworkCore;
using Practice.Domain.Entities;
using Practice.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Infrastructure.Repository
{
    public class SqlUserRepository : SqlGenericRepository<User>, IUserRepository
    {
        public SqlUserRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public async Task<List<User>> GetManyAsync()
        {
            return await entities
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }

        public override async Task<User> GetAsync(string id)
        {
            return await entities
                .Where(x => x.Id == id && !x.IsDeleted)
                .FirstOrDefaultAsync();
        }

        public override async Task DeleteAsync(string id)
        {
            var user = await GetAsync(id);

            if (user == null)
                return;

            user.IsDeleted = true;
            await UpdateAsync(user);
        }

        public async Task<bool> IsUniqueAsync(User user)
        {
            return await entities
                .AnyAsync(x => x.Id == user.Id || x.Email == user.Email || x.UserName == user.UserName);
        }
    }
}
