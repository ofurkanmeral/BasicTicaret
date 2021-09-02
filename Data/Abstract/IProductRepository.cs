using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Abstract
{
   public interface IProductRepository:IRepository<Product>
    {
        Product GetDetails(string productdetails);
        List<Product> GetProductCategory(string name,int page,int pageSize);
               
    }
}
