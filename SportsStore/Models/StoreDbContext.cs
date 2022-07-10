using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class StoreDbContext : IdentityDbContext<IdentityUser>
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
        : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Order> Orders => Set<Order>();

    }
}
