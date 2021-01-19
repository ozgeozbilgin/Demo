using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10;
            musteri1.Ad = "Özge";
            musteri1.Soyad = "Özbilgin";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 13;
            musteri2.Ad = "Melek";
            musteri2.Soyad = "Özbilgin";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 27;
            musteri3.Ad = "Öznur";
            musteri3.Soyad = "Özbilgin";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

           
           
            //müşteri eklendi
            MusteriYoneticisi musteriYoneticisi = new MusteriYoneticisi();
            musteriYoneticisi.Ekle(musteri1);
            musteriYoneticisi.Ekle(musteri2);
            musteriYoneticisi.Ekle(musteri3);

            //müsteri listelendi
            musteriYoneticisi.Listele(musteriler);

            //silindi
            musteriYoneticisi.Sil(musteri1);
            musteriYoneticisi.Sil(musteri2);
            musteriYoneticisi.Sil(musteri3);




        }
    }
}
