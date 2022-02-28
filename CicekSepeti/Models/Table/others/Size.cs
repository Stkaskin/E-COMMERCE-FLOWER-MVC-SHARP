using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table.others
{
    [Table("Size")]
    public class Size
    {
        public int id{ get; set; }
        public int size{ get; set; }
        public int? ProductDetailid { get; set; }
        public virtual List<ProductDetail> ProductDetail { get; set; }
    }
}