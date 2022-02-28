using CicekSepeti.Models.Database;
using CicekSepeti.Models.Table;
using CicekSepeti.Models.Table.others;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace CicekSepeti
{
    public class Global : HttpApplication
    {
           private void ss() {
            //resim copy

            string secilenDizin = "C:\\Users\\Askin\\source\\repos\\CicekSepeti\\CicekSepeti\\sepetfile\\cicek-resim\\l\\";
            string[] dizindekiKlasorler = Directory.GetDirectories(secilenDizin);
            string[] dizindekiDosyalar = Directory.GetFiles(secilenDizin);
            int i = 0;
            foreach (string dosya in dizindekiDosyalar)
            {
                i++;
           
                FileInfo fileInfo = new FileInfo(dosya);
                string dosyaAdi = fileInfo.Name;
                File.Copy(secilenDizin+dosyaAdi,secilenDizin+"img"+i+fileInfo.Extension);
            
            }
        }
        void Application_Start(object sender, EventArgs e)
        {
           // ss();
         
            // Code that runs on application startup
            using (BaseData db = new BaseData())
            {

               // db.Database.Delete();
                db.Database.CreateIfNotExists();

             //    ekle(db);


            }

                AreaRegistration.RegisterAllAreas();
           RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        private void ekle(BaseData db)
        {

            for (int i = 1; i <= 5; i++)
            {
                Category c = new Category();
                c.name = "Katagori" + i;

                c.count = 0;
                db.CatogoryDbTable.Add(c);
                db.SaveChanges();
            }
            for (int i = 1; i < 100; i++)
            {
                Random random = new Random();

                int c = i % 4;
                Product k = new Product();
                k.name = "NARİN PRODUCT  " + i;
                k.explanation = "Best friend or Best Time";
                k.price = random.Next(20, 500);
                k.image = "img" + i + ".jpg";
                k.CategoryID = random.Next(1, 5);
                k.count = 0;
                db.ProductDbTable.Add(k);
                db.SaveChanges();
            }
       

        }
    }
}