using CicekSepeti.Models.Table.others;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSepeti.Models.Table
{
    [Table("Product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int?  productcode{ get; set; }
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(100)]
        public string explanation { get; set; }

        public int price { get; set; }
        public int? stock { get; set; }

        public string image { get; set; }
        public string status { get; set; }
        public int count { get; set; }
        //public int Staticticsid { get; set; }
        public int? CategoryID { get; set; }
        public int? ProductDetailid { get; set; }

        public virtual Category Category { get; set; }
        public virtual ProductDetail ProductDetail{ get; set; }
       


     
 
        



    }


}
