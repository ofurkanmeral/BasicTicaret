using Bussines.Abstract;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PusulaPlus.Controllers
{
   
    public class AgainController : Controller
    {
        private IProductService _productManager;
        private ICategoryService _categoryManager;
        public AgainController(IProductService productManager,ICategoryService categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }
        public IActionResult Index()
        {
            var product = _productManager.GetAll();
            var category = _categoryManager.GetAll();
            ProductViewModel onur = new ProductViewModel()
            {
                categories = category,
                products = product
            };
            return View(onur);
        }


        public IActionResult Detail(string productdetails)
        {
            if (productdetails == null)
            {
                return NotFound();
            }
            Product product = _productManager.GetDetails(productdetails);
            if (product == null)
            {
                return NotFound();
            }
            return View(new ProductDetailModel()
            {
                Product = product,
                Categories = product.ProductCategories.Select(p => p.Category).ToList()
            });
        }
        public IActionResult liste(string category,int page=1)
        {
            const int pageSize = 3;
            if (string.IsNullOrEmpty(category))
            {
                var product = _productManager.GetAll();
                var categoryi = _categoryManager.GetAll();
                ProductViewModel onur = new ProductViewModel()
                {
                    products = product,
                    categories = categoryi
                };
                return View(onur);
            }
            var productss = _productManager.GetProductCategory(category,page,pageSize);
            ProductViewModel dolu = new ProductViewModel()
            {
                products = productss,
            };
            return View(dolu);
          
        }
    }
   
}
