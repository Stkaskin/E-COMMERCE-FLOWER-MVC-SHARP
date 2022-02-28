using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Table
{
    [Table("Catagory")]
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(100)]
        public string name { get; set; }

        public int? count { get; set; }

        public int? TopCategoryid{ get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public   virtual TopCategory TopCategory { get; set; }

    }
    
}