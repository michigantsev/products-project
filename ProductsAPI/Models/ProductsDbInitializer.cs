using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductsAPI.Models
{
    public class ProductsDbInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext db)
        {
            db.Products.Add(new Product { Name = "Какой-то продукт", Price = 500, Type = "Какой-то тип"});
            db.Products.Add(new Product { Name = "Какой-то продукт # 2", Price = 200, Type = "Какой-то тип # 2"});

            base.Seed(db);
        }
    }
}