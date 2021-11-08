using Microsoft.EntityFrameworkCore;
using Practice.Domain.Entities;

namespace Practice.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> ctx) : base (ctx)
        {

        }
    }
}
