using CicekSepeti.Models.Table;
using CicekSepeti.Models.Table.others;
using CicekSepeti.Models.Table.Sehir;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CicekSepeti.Models.Database
{
    public class BaseData:DbContext
    {

        public virtual DbSet<Category> CatogoryDbTable { get; set; }
        public virtual DbSet<Product> ProductDbTable{ get; set; }
        public virtual DbSet<ProductDetail> ProductDetailTable{ get; set; }
        public virtual DbSet<Invoice> InvoiceTable { get; set; }
   

        public virtual DbSet<Order> OrderTable { get; set; }
        public virtual DbSet<OrderDetail> OrderDetailTable {  get; set; }
        public virtual DbSet<WishList> WishListTable { get; set; }

        public virtual DbSet<Cart> CartTable { get; set; }
        public virtual DbSet<User> UserTable { get; set; }
        public virtual DbSet<ilceler> ilcelerTable { get; set; }
        public virtual DbSet<iller> illerTable { get; set; }
        public virtual DbSet<Size> SizeTable { get; set; }
        public virtual DbSet<Color> ColorTable { get; set; }
        public virtual DbSet<ManuFacturer> ManuFacturerTable { get; set; }
    }
}