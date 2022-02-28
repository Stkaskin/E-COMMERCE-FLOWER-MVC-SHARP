using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table.others
{
    [Table("Color")]
    public class Color
    {
        public int id { get; set; }
        public string name{ get; set; }
        public int? ProductDetailid { get; set; }
        public virtual List<ProductDetail> ProductDetail { get; set; }
    }
}