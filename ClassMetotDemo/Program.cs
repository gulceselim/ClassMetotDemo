using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri(1, "Selim", "Gülce", "05053332211");
            Musteri musteri2 = new Musteri(2, "Engin", "Demiroğ", "05054445566");

            musteriManager.AddMusteri(musteri1, musteri2);
            musteriManager.GetMusteri();
            musteriManager.DeleteMusteri(musteri1);
            musteriManager.GetMusteri();

        }

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

        public class MusteriManager
        {
            Musteri[] musteriler;
            public void AddMusteri(params Musteri[] musteri)
            {
                musteriler = musteri;
                Console.WriteLine($"{musteri.Length} Müşteri veritabanına eklendi.");
            }

            public void DeleteMusteri(Musteri musteri)
            {
                foreach (var m in musteriler)
                {
                    if(m.Id == musteri.Id)
                    {
                        List<Musteri> tmp = new List<Musteri>(musteriler);
                        tmp.Remove(m);
                        musteriler = tmp.ToArray();
                        break;
                    }
                }
                Console.WriteLine($"{musteri.Ad} {musteri.Soyad} adlı müşteri veritabanından silindi.");
            }

            public void GetMusteri()
            {
                foreach (Musteri musteri in musteriler)
                {
                    Console.WriteLine($"ID: {musteri.Id}\n" +
                                        $"İsim: {musteri.Ad}\n" +
                                        $"Soyisim: {musteri.Soyad}\n" +
                                        $"Telefon Numarası: {musteri.TelefonNo}\n" +
                                        $"------------------------------");
                }



            }
        }
    }
}
