using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table
{
    [Table("TopCategory")]
    public class TopCategory
    {
        public int id{ get; set; }
        public string name { get; set; }

    }
}