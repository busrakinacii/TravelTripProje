using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class blog
    {
        [Key]
        public int ID { get; set; }

        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }

        //1e Çok İlişki Kurarız comment sınıfına 
        public ICollection<comment> Comments { get; set; }
    }
}