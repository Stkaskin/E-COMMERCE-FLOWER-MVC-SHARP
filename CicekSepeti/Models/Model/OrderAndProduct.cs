using CicekSepeti.Models.Table;
using CicekSepeti.Models.Table.others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Model
{
    public class OrderAndProduct
    {
      public  Product Product { get; set; }
        public OrderDetail Order{ get; set; }

    }
}