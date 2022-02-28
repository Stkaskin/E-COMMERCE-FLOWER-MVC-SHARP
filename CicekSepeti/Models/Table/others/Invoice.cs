using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table.others
{
    [Table("Invoice")]
    public class Invoice
    {
        [ForeignKey("Order")]
        public int id { get; set; }

        public string name { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public string code { get; set; }
        public int? paytype { get; set; }
        public bool? type { get; set; }
        public bool? agreementSmsEmail { get; set; }
        public bool? agreementPersonal { get; set; }
    

        public virtual Order Order { get; set; }



    }
}