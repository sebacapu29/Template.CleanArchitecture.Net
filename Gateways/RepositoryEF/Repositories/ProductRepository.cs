using Entities.Interfaces;
using Entities.POCOs;
using RepositoryEF.DataContext;

namespace RepositoryEF.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context) 
        {
            _context = context;
        } 
        public void CreateProduct(Product product)
        {
            _context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
    }
}
