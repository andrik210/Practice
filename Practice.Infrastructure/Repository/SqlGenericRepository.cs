using Microsoft.EntityFrameworkCore;
using Practice.Domain.Entities;
using Practice.Domain.Repositories;
using System.Threading.Tasks;

namespace Practice.Infrastructure.Repository
{
    public abstract class SqlGenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext _dbContext;
        protected DbSet<TEntity> entities;

        public SqlGenericRepository(ApplicationDbContext context)
        {
            _dbContext = context;
            entities = context.Set<TEntity>();
        }

        public virtual Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            entities.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual Task DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<TEntity> GetAsync(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
