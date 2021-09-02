using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new DataContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {

                if (context.categories.Count() == 0)
                {
                    context.AddRange(Categories);
                }

                if (context.products.Count() == 0)
                {
                    context.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
                context.SaveChanges();

            }

        }

        private static Category[] Categories =
            {
                    new Category(){name="Bilgisayar",image="onur",Url="bilgisayar" },
                    new Category (){name="Telefon",image="onur",Url="telefon"},
                    new Category(){name="Elektronik",image="onur",Url="elektronik"},
                    new Category(){name="Beyaz Eşya",image="imageler",Url="beyaz-esya"}
             };
        private static Product[] Products =
        {
                    new Product(){name="onur",image="bmw"},
                    new Product(){name="yigit",image="audi"},
                    new Product(){name="berkan",image="merdeces"},
                    new Product(){name="fatih",image="fiat"},
                    new Product(){name="faruk",image="renalult"},
                    new Product(){name="samet",image="citroen"},
                    new Product(){name="mert",image="peugut"},
             };
        private static ProductCategory[] ProductCategories =
        {
            new ProductCategory(){Produtc=Products[0],Category=Categories[0]},
            new ProductCategory(){Produtc=Products[0],Category=Categories[1]},
            new ProductCategory(){Produtc=Products[1],Category=Categories[0]},
            
            new ProductCategory(){Produtc=Products[2],Category=Categories[1]},
            new ProductCategory(){Produtc=Products[2],Category=Categories[0]},
            new ProductCategory(){Produtc=Products[3],Category=Categories[1]},
            new ProductCategory(){Produtc=Products[4],Category=Categories[1]},
        };

    }
}







