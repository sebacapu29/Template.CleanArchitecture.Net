using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace RepositoryEF.DataContext
{
    public class ProductContextFactory: IDesignTimeDbContextFactory<ProductDbContext>
    {
        public ProductContextFactory()
        {

        }

        public ProductDbContext CreateDbContext(string[] args)
        {
            string strCon = "Data Source=localhost;Port=1434;Initial Catalog=RegionalAssets;Persist Security Info=True;User ID=root;Password=testeo123";
            var OptionsBuilder = new DbContextOptionsBuilder<ProductDbContext>();
            OptionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon), b => b.SchemaBehavior(MySqlSchemaBehavior.Ignore));

            return new ProductDbContext(OptionsBuilder.Options);
        }
    }
}
