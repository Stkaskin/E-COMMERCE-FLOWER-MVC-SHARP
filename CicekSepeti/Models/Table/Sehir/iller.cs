using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table.Sehir
{
    [Table("iller")]
    public class iller
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string sehiradi { get; set; }
        public virtual ICollection<ilceler>  ilceler { get; set; }
    }
}