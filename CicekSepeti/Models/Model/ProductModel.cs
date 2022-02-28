using CicekSepeti.Models.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Model
{
    public class ProductModel
    {
       public List<Product> ProductsTable { get; set; }
       public LinkedList<Product> lastproducts { get; set; }
       public List<Category> CategoryTable { get; set; }

  

    }
}