using Microsoft.EntityFrameworkCore;

namespace TestAppAspNet
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Order> Orders { get; set; }
    }
}