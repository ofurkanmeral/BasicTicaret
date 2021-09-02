using Microsoft.AspNetCore.Mvc;
using PusulaPlus.Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Abstract;
using Microsoft.AspNetCore.Authorization;
using Bussines.Abstract;

namespace PusulaPlus.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IProductService _productservice;
        public HomeController(IProductService productservice)
        {
            this._productservice = productservice;
        }
        public IActionResult Index(string query)
        {
           
            int zaman = DateTime.Now.Hour;
            string timeup = zaman > 12 ? "Günaydın" : "İyi Akşamklar";

            ViewBag.Gonder = timeup;

            Product onur = new Product { id = 2, image="kelkit", name = "Onur Furkan MEral" };
            Product furkan = new Product { name = "furkan", image = "lityum", id = 1 };
            var products = new List<Product>();
            products.Add(onur);
            products.Add(furkan);
            var category = new List<Category>() { new Category { id = 1, image = "deneme", name = "model" },
             new Category { id = 2, image = "denemsdae", name = "modsadel" }
            };

            if (!string.IsNullOrEmpty(query))
            {
                products=products.Where(i => i.name.Contains(query) || i.image.Contains(query)).ToList();
            }

            ProductViewModel model = new ProductViewModel()
            {
                products = products,
                categories = category
            };
            ViewBag.controller=(RouteData.Values["controller"]);
            ViewBag.action=(RouteData.Values["action"]);
            Console.WriteLine(RouteData.Values["id"]);
            return View(model);
        }

        public IActionResult Detail(string productdetails)
        {
            if (productdetails == null)
            {
                return NotFound();
            }
            Product product = _productservice.GetDetails(productdetails);
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

        public IActionResult liste(int? id, string query)
        {
            ViewBag.query = HttpContext.Request.Query["query"].ToString();
           var products=ProductRepository.Products;
            if (id != null)
            {
                products = products.Where(p => p.cateid == id).ToList();
            }

            if (!string.IsNullOrEmpty(query))
            {
                products = products.Where(i => i.name.Contains(query)||i.image.Contains(query)).ToList();
            }
            var ProductViewModel = new ProductViewModel
            {
                products = products
            };
            return View(ProductViewModel);
        }

        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(Product p)
        {
            ProductRepository.Add(p);
            return View();
        }

       

        public IActionResult userlist()
        {
           // var users = UserRepository.Getir;

            return View();
        }

        public IActionResult edit(int id)
        {
            ProductRepository.GetById(id);
            
            return View();
        }
        [HttpPost]
        public IActionResult edit(Product p)
        {
            ProductRepository.edit(p);
            return RedirectToAction("liste");
        }

        public IActionResult delete(int id)
        {
            //UserRepository.Delete(id);
            return RedirectToAction();
        }
    }
    
}
