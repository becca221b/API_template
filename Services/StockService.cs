using Practica1.Models;
using Practica1.Repositories;

namespace Practica1.Services
{
    public class StockService
    {
        private readonly ProductRepository _productRepository;

        public StockService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void ApplyMovement(Movement movement) {
            var product = _productRepository.GetProductById(movement.ProductId);

            if (product == null) {
                throw new Exception("Product not found");
            }

            if(movement.Type == "OUT" && product.Stock < movement.Quantity)
            {
                throw new Exception("No stock");
            }
            if(movement.Type == "IN")
            {
                product.Stock += movement.Quantity;
            }
            else
            {
                product.Stock -= movement.Quantity;
            }
        }
    }
}
