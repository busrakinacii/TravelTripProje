using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Models.Classes
{
    public class BlogYorum
    {
        public IEnumerable<blog>Deger1 { get; set; }
        public IEnumerable<comment>Deger2 { get; set; }
        public IEnumerable<blog> blogSiralama { get; set; }

    }
}