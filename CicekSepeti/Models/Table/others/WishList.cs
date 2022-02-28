using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table.others
{
    [Table("WishList")]
    public class WishList
    {
        [ForeignKey("User")]
        public int? id { get; set; }
        public int? Productid { get; set; }



        public virtual Product Product { get; set; }
        public virtual User User { get; set; }



    }
}