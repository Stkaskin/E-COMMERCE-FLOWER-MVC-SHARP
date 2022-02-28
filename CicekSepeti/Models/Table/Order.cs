using CicekSepeti.Models.Table.others;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table
{
    [Table("Order")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string kargo  { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }
        public int? couponTotal { get; set; }
        public int? total { get; set; }
        public DateTime? date { get; set; }
        public int? status { get; set; }
        //public int invoiceid { get; set; }
        //public int cargoid { get; set; }
        public int? Cartid { get; set; }
        public int? Invoiceid { get; set; }
        public int? Userid { get; set; }

        public virtual Invoice Invoice { get; set; }



        public virtual List< OrderDetail> detail { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual User User { get; set; }
       

     
    }
}