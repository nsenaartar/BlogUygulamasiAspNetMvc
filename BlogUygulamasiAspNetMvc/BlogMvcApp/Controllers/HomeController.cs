using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {


        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var bloglar = context.Bloglar.
                Select(i => new BlogModel() {
                    Id = i.Id,
                    Baslık = i.Baslık.Length>100? i.Baslık.Substring(0,100)+"..":i.Baslık,
                    Acıklama=i.Acıklama,
                    EklenmeTarihi=i.EklenmeTarihi,
                    Anasayfa=i.Anasayfa,
                    Onay=i.Onay,
                    Resim=i.Resim

                })
          
                .Where(i => i.Onay == true && i.Anasayfa == true);

            bloglar = bloglar.OrderByDescending(i=>i.Baslık);

            return View(bloglar);
        }
    }
}