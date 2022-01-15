using System.Collections.Generic;
using Testing.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        
        public Product GetProduct(int id);
    }
}
