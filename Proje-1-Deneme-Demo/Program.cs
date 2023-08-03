using System;
using System.Collections.Generic;

namespace Proje
{
    class Program
    {
        public class Kisi
        {
            public string Isim { get; set; }
            public string Soyad { get; set; }
            public int Telefon { get; set; }
        }

        public class yeniKayit : Kisi
        {
            // Kurucu method
            public yeniKayit(string isimKayit, string soyisimKayit, int telefonKayit)
            {
                Isim = isimKayit;
                Soyad = soyisimKayit;
                Telefon = telefonKayit;
            }
        }

        static void Main(string[] args)
        {
            List<Kisi> rehber = new List<Kisi>();

            yeniKayit kisi1 = new yeniKayit("Osman Batuhan", "Kalkan", 111111);
            yeniKayit kisi2 = new yeniKayit("Ali", "Kalkan", 222222);
            yeniKayit kisi3 = new yeniKayit("Veli", "Kalkan", 333333);
            yeniKayit kisi4 = new yeniKayit("Ahmet", "Kalkan", 444444);
            yeniKayit kisi5 = new yeniKayit("Mehmet", "Kalkan", 555555);

            rehber.Add(kisi1);
            rehber.Add(kisi2);
            rehber.Add(kisi3);
            rehber.Add(kisi4);
            rehber.Add(kisi5);

            int secilenNumara;

            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz. " +
                              "(1):Yeni Numara Kaydetmek, " +
                              "(2):Var Olan Numarayı Silmek, " +
                              "(3):Var Olan Numarayı Güncellemek, " +
                              "(4):Rehberi Listelemek, " +
                              "(5):Rehberde Arama Yapmak.");
            secilenNumara = Convert.ToInt32(Console.ReadLine());
            
            if (secilenNumara == 1)
            {
                Console.WriteLine("(1):Yeni Numara Kaydetmek");
                Console.WriteLine("Lütfen isim giriniz...");
                string isimKayit = Console.ReadLine();

                Console.WriteLine("Lütfen Soyisim giriniz...");
                string soyisimKayit = Console.ReadLine();

                Console.WriteLine("Lütfen Telefon numarasını giriniz...");
                int telefonKayit = Convert.ToInt32(Console.ReadLine());

                yeniKayit kayit = new yeniKayit(isimKayit, soyisimKayit, telefonKayit);
                rehber.Add(kayit);
                rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));

            }
            else if (secilenNumara == 2)
            {
                Console.WriteLine("(2)Var Olan Numarayı Sildirmek");
                rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));
                // Silme işlemini burada yapabilirsiniz
            }
            else if (secilenNumara == 3)
            {
                Console.WriteLine("(3)Var Olan Numarayı Güncelle");
                rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));
                // Güncelleme işlemini burada yapabilirsiniz
            }
            else if (secilenNumara == 4)
            {
                Console.WriteLine("(4)Rehberi Listele");
                rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));
            }
            else if (secilenNumara == 5)
            {
                Console.WriteLine("(5)Rehberde Arama Yap");
                rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));
                
            }
            else{
                         System.Console.WriteLine("Hata");
            }
            }
        }
}

 