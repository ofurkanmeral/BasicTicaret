using Bussines.Abstract;
using Data.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productservice;
        public ProductManager(IProductRepository productservice)
        {
            _productservice = productservice;
        }
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productservice.GetAll();
        }

        public Product GetById(int id)
        {
            return _productservice.GetById(id);
        }

       public Product GetDetails(string productdetails)
        {
            return _productservice.GetDetails(productdetails);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProductCategory(string name,int page,int pageSize)
        {
            return _productservice.GetProductCategory(name,page,pageSize);
        }

      
    }
}
