using NeoSoftDemo3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoftDemo3.Models
{
    public class MockProductRepository : IProductRepository
    {
        public List<Product> _productsList;

        public MockProductRepository()
        {
            //_productsList = new List<Product>()
            //{
            //    new Product(){Id=1,Name="Apple",Description="Apple Fruit ",StortDescription="apple",IsActive=true,Category=Ca,Price="1000.00"},
            //    new Product(){Id=2,Name="Mango",Description="Mango Fruit ",StortDescription="Mango",IsActive=true,Category="Electronics",Price="150.00"},
            //    new Product(){Id=3,Name="Strabery",Description="Strabery Fruit ",StortDescription="Starabery",IsActive=true,Category="Fruit",Price="200.00"},
            //    new Product(){Id=4,Name="Chikko",Description="Chikko Fruit ",StortDescription="Chikko",IsActive=true,Category="Electronics",Price="800.00"}
            //};
        }

        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int Id)
        {
            return _productsList.FirstOrDefault(p => p.Id == Id);
        }

        public IEnumerable<Product> GetProducts()
        {
             
            return _productsList;
        }
    }
}
