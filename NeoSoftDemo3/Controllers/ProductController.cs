using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeoSoftDemo3.Models;
using NeoSoftDemo3.ViewModel;

namespace NeoSoftDemo3.Controllers
{
    public class ProductController : Controller
    {
        private  IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
           _productRepository = productRepository;
        }

        public IActionResult Index()
        {
          var model=  _productRepository.GetProducts();
            return View(model);
        }

        public IActionResult Details(int Id)
        {
            ProductDetails product = new ProductDetails();
            Product product1 = new Product();
            product1=  _productRepository.GetProduct(Id);
            product.Id = product1.Id;
            product.Name = product1.Name;
            //product.Category = product1.Category;
            product.Price = product1.Price;
            product.StortDescription = product1.StortDescription;
            return View(product);

        }
    }
}
