
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table.others
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
      
        public int id { get; set; }
        public string name{ get; set; }
        public string tel{ get; set; }
        public string mail{ get; set; }
        
        public int? reason { get; set; }
        public string adressname{ get; set; }
 

        public string Note{ get; set; }

        public string receiverName { get; set; }
        public DateTime senderTime { get; set; }
        public DateTime receiverTime { get; set; }
        public string stage { get; set; }
        public int? Orderid{ get; set; }
        public int? pid { get; set; }
        public virtual Product p { get; set; }


        public virtual Order Order { get; set; }



    }
}