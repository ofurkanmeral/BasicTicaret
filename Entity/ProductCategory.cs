using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ProductCategory
    {
        public int productId { get; set; }
        public Product Produtc { get; set; }
        public int categoriId { get; set; }
        public Category Category { get; set; }
    }
}
