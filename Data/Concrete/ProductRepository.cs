using Data.Abstract;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Concrete
{
    public class ProductRepository : GenericRepository<Product, DataContext>, IProductRepository
    {
        public Product GetDetails(string productdetails)
        {
            using(var context =new DataContext())
            {
                return context.products
                    .Where(p => p.Url == productdetails)
                    .Include(p => p.ProductCategories)
                    .ThenInclude(p => p.Category)
                    .FirstOrDefault();
            }
        }

        public List<Product> GetProductCategory(string name,int page,int pageSize)
        {
            using (var context = new DataContext())
            {
                var products = context.products.AsQueryable();

                if (!string.IsNullOrEmpty(name))
                {
                    products = products
                                .Include(p => p.ProductCategories)
                                .ThenInclude(p => p.Category)
                                .Where(i => i.ProductCategories.Any(a => a.Category.Url.ToLower() == name.ToLower()));
                }

                return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }
    }
}
