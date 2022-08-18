using Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace RepositoryEF.DataContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {

        }
        public DbSet<Product>? Products { get; set; }

    }
}
