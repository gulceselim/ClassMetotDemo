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

    }
}
