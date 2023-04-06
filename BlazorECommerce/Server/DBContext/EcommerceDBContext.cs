using BlazorECommerce.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorECommerce.Shared.DBContext
{
    public class EcommerceDBContext : DbContext
    {
        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
