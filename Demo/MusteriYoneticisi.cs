using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class MusteriYoneticisi
    {
        public void Ekle(Musteri musteri)
        {       

            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + "  adlı müşteri listeye eklendi");

        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {

           
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine("-------------------------------------------------");

            }

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+ " " +musteri.Soyad+" adlı müşteri silindi");
        }
    }
}
