using CicekSepeti.Models.Table.images;
using CicekSepeti.Models.Table.others;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table
{
    [Table("ProductDetail")]
    public class ProductDetail
    {
        [ForeignKey("Product")]
        public int id { get; set; }
        public int? productcode { get; set; }
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(100)]
        public string explanation { get; set; }

        public int? price { get; set; }

        public int? stock { get; set; }
        public int? rating { get; set; }


        public string status { get; set; }
        public int? Count { get; set; }
        public int? Colorid { get; set; }
        public int? Sizeid { get; set; }
        public int? ManuFacturerid { get; set; }

        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
        public virtual Color Color { get; set; }
        public virtual ManuFacturer ManuFacturer { get; set; }
    
        public virtual List<Productİmage> İmages { get; set; }
        
    }
}