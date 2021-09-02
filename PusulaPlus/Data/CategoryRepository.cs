using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PusulaPlus.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _category = null;

        static CategoryRepository()
        {
            _category = new List<Category>
            {
                new Category{id=1,name="Telefonlar",image="free" },
                new Category{id=2,name="Bilgisayar"},
                new Category{id=3,name="Elektonik"}
            };
        }

       public static List<Category> Categories
        {
            get
            {
                return _category;
            }
        }

        public static void Delete(int id)
        {
            Category silinecek=_category.FirstOrDefault(p => p.id == id);
            _category.Remove(silinecek);
        }

        public static void Create(Category cate)
        {
            cate.id = 29;
            cate.image = "backım resmi";
            cate.name = "bekim";
            _category.Add(cate);
        }
        public static void Ekle(Category cate)
        {
            _category.Add(cate);
            
        }
        public static Category Filtreleme(int id)
        {
            return _category.FirstOrDefault(cate => cate.id == id);
        }
    }
}
