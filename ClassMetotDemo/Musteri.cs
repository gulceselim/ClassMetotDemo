using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNo { get; set; }

        public Musteri(int ıd, string ad, string soyad, string telefonNo)
        {
            Id = ıd;
            Ad = ad;
            Soyad = soyad;
            TelefonNo = telefonNo;
        }
    }
}
