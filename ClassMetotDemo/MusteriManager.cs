using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
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
                if (m.Id == musteri.Id)
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
