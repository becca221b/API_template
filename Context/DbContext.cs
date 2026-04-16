

using Practica1.Models;

namespace Practica1.Context
{
    public class DbContext
    {
        
        public List<Product> Products { get; set; } = new List<Product>();
    }

}
