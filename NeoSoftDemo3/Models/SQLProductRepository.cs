using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoftDemo3.Models
{
    public class SQLProductRepository : IProductRepository
    {
        private AppDbcontext _dbcontext;

        public SQLProductRepository( AppDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public Product Add(Product product)
        {
            _dbcontext.products.Add(product);
            _dbcontext.SaveChanges();
            return product;
        }

        public Product GetProduct(int Id)
        {
            return _dbcontext.products.Find(Id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbcontext.products;
        }
    }
}
