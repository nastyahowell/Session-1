using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace vstrechashop.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Order { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                    : base(options)
        {
            Database.EnsureCreated();
        }
    }
}