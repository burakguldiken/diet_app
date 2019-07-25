using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiyetApp.Models
{
    public class Diyet
    {
        public string Ogun { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public bool Tamamlandimi { get; set; }


    }
}