using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table.Sehir
{
    [Table("ilceler")]
    public class ilceler
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string ilceadi{ get; set; }
        public int ilid { get; set; }
        public virtual iller il { get; set; }
    }
}