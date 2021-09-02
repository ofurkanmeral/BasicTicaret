using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
