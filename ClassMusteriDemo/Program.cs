using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Ahmet";
            musteri1.Surname = "Kiraz";
            musteri1.Id = 10101;


            Musteri musteri2 = new Musteri();
            musteri2.Name = "Mehmet";
            musteri2.Surname = "Yarıbıçak";
            musteri2.Id = 101010;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Ali";
            musteri3.Surname = "Tamyol";
            musteri3.Id = 1010101;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            
            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            musteriManager.Erase(musteri1);
            musteriManager.Erase(musteri2);
            musteriManager.Erase(musteri3);

            musteriManager.List(musteriler);

            
            







        }
    }
}
