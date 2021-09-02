
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Create(Category entity);
        void Delete(Category entity);
        void Update(Category entity);
    }
}
