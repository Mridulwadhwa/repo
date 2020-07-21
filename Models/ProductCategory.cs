using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Test.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {

        }
        public ProductCategory(Product p, Category c)
        {
            //TO DO: Complete Member Initialization  
            this.Product = p;
            this.Category = c;
        }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
