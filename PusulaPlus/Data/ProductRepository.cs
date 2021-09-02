using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PusulaPlus.Data
{
    public static class ProductRepository
    {
        //private static List<Product> _products=null;

        //static ProductRepository()
        //{

        //}
        //public static void Add(Product product)
        //{
        //    _products.Add(product);
        //}
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
             new Product { id = 1, name = "onur", image = "furkan" ,cateid=1},
             new Product { id = 2, name = "adanan", image = "furkan",cateid=2 },
                new Product { id = 3, name = "meral", image = "furkan" ,cateid=1},
             new Product { id = 4, name = "hasan", image = "furkan",cateid=2 },
                new Product { id = 5, name = "ali", image = "furkan" ,cateid=1},
             new Product { id = 6, name = "türker", image = "furkan",cateid=2 },
            };
        }
    

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
            set
            {
                
            }
            
        }

        
        public static void Add(Product pro)
        {
            _products.Add(pro);
        }
        public static Product GetById(int id)
        {
            return _products.FirstOrDefault(product => product.id == id);
        }

        public static void edit(Product product)
        {
            foreach(var iter in _products)
            {
                if (iter.id == product.id)
                {
                    iter.id = product.id;
                    iter.name = product.name;
                    iter.image = product.image;
                    iter.cateid = product.cateid;
                }
            }
            
        }
    }
}
