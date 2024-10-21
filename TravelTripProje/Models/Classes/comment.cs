using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class comment
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }

        //Blog tablosundan gelen blog Blog Tablosundaki Idyi tutuyor.
        //Bir blogda Yalnız bir Yorum Olabilir.1e Çok İlişki Yoktur.
        public virtual blog Blog { get; set; }

    }
}