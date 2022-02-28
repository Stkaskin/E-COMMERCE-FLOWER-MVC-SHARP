using CicekSepeti.Models.Table.others;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table
{
    [Table("User")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(100)]
        public string mail { get; set; }

        public string password { get; set; }
        public string adress { get; set; }
        public string username { get; set; }

        public bool? acvtive { get; set; }

        public bool? verfication { get; set; }
        public DateTime? birthday { get; set; }
        public DateTime? lastlogin { get; set; }
        public DateTime? registertime { get; set; }

    
        public int? status { get; set; }
        //public int Staticticsid { get; set; }
        public virtual WishList WishList { get; set; }
        public virtual List<Order> Order{ get; set; }







    }

}