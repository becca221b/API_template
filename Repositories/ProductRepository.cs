using Practica1.Context;
using Practica1.Models;

namespace Practica1.Repositories
{
    public class ProductRepository
    {
        private readonly DbContext _context;

        public ProductRepository(DbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public Product GetProductById(int id) {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
