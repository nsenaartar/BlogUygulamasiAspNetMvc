using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
        public String Resim { get; set; }
        public string Icerik { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}