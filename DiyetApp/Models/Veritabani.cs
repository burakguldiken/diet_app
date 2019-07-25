using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiyetApp.Models
{
    public  static class Veritabani
    {
        private static List<Diyet> DiyetListesi;
        //Constructer
        static Veritabani()
        {
            DiyetListesi = new List<Diyet>()
            {
                new Diyet() {Ogun = "Kahvaltı" , Aciklama = "Peynir,zeytin ve 1 Yumurta" , Tarih = DateTime.Now.AddDays(-1) , Tamamlandimi = true},
                new Diyet() {Ogun = "Ara Öğün" , Aciklama = "1 Elma" , Tarih = DateTime.Now.AddDays(-1) , Tamamlandimi = true},
                new Diyet() {Ogun = "Öğle Yemeği" , Aciklama = "Fasulye,Yoğurt ve Salata" , Tarih = DateTime.Now.AddDays(-1) , Tamamlandimi = true},
                new Diyet() {Ogun = "Ara Öğün" , Aciklama = "1 Armut" , Tarih = DateTime.Now.AddDays(-1) , Tamamlandimi = true},
                new Diyet() {Ogun = "Akşam Yemeği" , Aciklama = "Tavuk ve Çorba" , Tarih = DateTime.Now.AddDays(-1) , Tamamlandimi = true},


                new Diyet() {Ogun = "Kahvaltı" , Aciklama = "Peynir,domates ve 2 Yumurta" , Tarih = DateTime.Now.AddDays(0) , Tamamlandimi = true},
                new Diyet() {Ogun = "Ara Öğün" , Aciklama = "1 Muz" , Tarih = DateTime.Now.AddDays(0) , Tamamlandimi = true},
                new Diyet() {Ogun = "Öğle Yemeği" , Aciklama = "Brokoli,Yoğurt ve Salata" , Tarih = DateTime.Now.AddDays(0) , Tamamlandimi = false},
                new Diyet() {Ogun = "Ara Öğün" , Aciklama = "1 Ayva" , Tarih = DateTime.Now.AddDays(0) , Tamamlandimi = false},
                new Diyet() {Ogun = "Akşam Yemeği" , Aciklama = "Et ve Çorba" , Tarih = DateTime.Now.AddDays(0) , Tamamlandimi = false},

                new Diyet() {Ogun = "Kahvaltı" , Aciklama = "Kaşar ve Domates" , Tarih = DateTime.Now.AddDays(1) , Tamamlandimi = false},
                new Diyet() {Ogun = "Ara Öğün" , Aciklama = "1 Şeftali" , Tarih = DateTime.Now.AddDays(1) , Tamamlandimi = false},
                new Diyet() {Ogun = "Öğle Yemeği" , Aciklama = "Makarna ve Salata" , Tarih = DateTime.Now.AddDays(1) , Tamamlandimi = false},
                new Diyet() {Ogun = "Ara Öğün" , Aciklama = "1 Ayva" , Tarih = DateTime.Now.AddDays(1) , Tamamlandimi = false},
                new Diyet() {Ogun = "Akşam Yemeği" , Aciklama = "Tavuk ve Çorba" , Tarih = DateTime.Now.AddDays(1) , Tamamlandimi = false},
            };
        }

        //Constructer atama yapılan listeye dışarda erişmek için kullanılan fonksiyon.
        public static List<Diyet> ListeGonder   
        {
            get { return DiyetListesi; }
        }
        //Diyet Listesine dışarıdan ekleme yapabilmemizi sağlayan fonksiyon.
        public static void DiyetEkle(Diyet diyet)
        {
            DiyetListesi.Add(diyet);
        }
    }
}