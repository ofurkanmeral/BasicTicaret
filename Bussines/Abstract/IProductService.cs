using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface IProductService
    {
        Product GetDetails(string productdetails);
        List<Product> GetAll();
        void Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
        Product GetById(int id);
        List<Product> GetProductCategory(string name,int page,int pageSize);
    }
}
