using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    //public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    //{
    //    //Veritabanındaki tablolarda değişiklik olursa databaseyi silip tekrar oluşturur. Seed metodu bize test verileri eklememizi sağlar. 
    //    public override void Seed(BlogContext context)
    //    {
    //        List<Category> Categories = new List<Category>()
    //        {
    //            new Category(){KategoriAdi="C#"},
    //            new Category(){KategoriAdi="Asp.Net MVC"},
    //            new Category(){KategoriAdi="Asp.Net WebForm"},
    //            new Category(){KategoriAdi="Windows Form"},
    //            new Category(){KategoriAdi="Web API"},

    //        };
    //        foreach (var item in Categories)
    //        {
    //            context.Kategoriler.Add(item);
    //        }
    //        context.SaveChanges();



    //        List<Product> Products = new List<Product>()
    //        {
    //              new Product(){},
                 

    //        };
    //        foreach (var item in bloglar)
    //        {
    //            context.Bloglar.Add(item);
    //        }
    //        context.SaveChanges();

    //        base.Seed(context);
    //    }

    
    //}
}