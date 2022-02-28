using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table.images
{
    [Table("Productİmage")]
    public class Productİmage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id{ get; set; }
 
        public string image{ get; set; }
        public int Productid { get; set; }
        public int ProductDetailid { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }

    }
}