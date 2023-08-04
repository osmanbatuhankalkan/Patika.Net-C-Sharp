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

            yeniKayit kisi1 = new yeniKayit("Osman ", "Kalkan", 111111);
            yeniKayit kisi2 = new yeniKayit("Ali", "tukenmez", 222222);
            yeniKayit kisi3 = new yeniKayit("Veli", "deneme", 333333);
            yeniKayit kisi4 = new yeniKayit("Ahmet", "batu", 444444);
            yeniKayit kisi5 = new yeniKayit("Mehmet", "akil", 555555);

            rehber.Add(kisi1);
            rehber.Add(kisi2);
            rehber.Add(kisi3);
            rehber.Add(kisi4);
            rehber.Add(kisi5);

            while(true){
            int secilenNumara;

            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz. " +
                              "(1):Yeni Numara Kaydetmek, " +
                              "(2):Var Olan Numarayı Silmek, " +
                              "(3):Var Olan Numarayı Güncellemek, " +
                              "(4):Rehberi Listelemek, " +
                              "(5):Rehberde Arama Yapmak.");
            secilenNumara = Convert.ToInt32(Console.ReadLine());
            
            if (secilenNumara == 1)//********************* Ekleme işleminin yapıldığı Kod Blogu*******************
             {
                Console.WriteLine("(1):Yeni Numara Kaydetmek");
                while(true)
                { 
                Console.WriteLine("Lütfen isim giriniz...");
                string isimKayit = Console.ReadLine();

                Console.WriteLine("Lütfen Soyisim giriniz...");
                string soyisimKayit = Console.ReadLine();

                Console.WriteLine("Lütfen Telefon numarasını giriniz...");
                int telefonKayit = Convert.ToInt32(Console.ReadLine());

                yeniKayit kayit = new yeniKayit(isimKayit, soyisimKayit, telefonKayit);
                rehber.Add(kayit);
                rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));
                System.Console.WriteLine("Ekleme işi başarıyla tamamlanmıştır.....!");
                break;
               }Console.WriteLine("(1) Ana Menu için");
                 string secim1 = Console.ReadLine();
                if(secim1 == "1" )
                    continue;
             }
            // ################################################### SINIR ###################################################
            else if (secilenNumara == 2)//********************* Silme işleminin yapıldığı Kod Blogu*******************
            {
                while (true)
             {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string aranan = Console.ReadLine();

                // Kişiyi isim veya soyadına göre arıyoruz
                Kisi silinecekKisi = rehber.Find(kisiArama => kisiArama.Isim == aranan || kisiArama.Soyad == aranan);

                if (silinecekKisi != null)
                {
                    Console.WriteLine($"{aranan}: İsimli Kişi Rehberden Silinmek Üzere,onaylıyor musunuz ?(y/n) : {silinecekKisi.Isim} {silinecekKisi.Soyad} - {silinecekKisi.Telefon}");
                    string cevap = Console.ReadLine();

                    if (cevap.ToLower() == "y")
                    {
                        rehber.Remove(silinecekKisi);
                        Console.WriteLine("Kişi rehberden başarıyla silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                    }
                    System.Console.WriteLine("Silme işi başarıyla tamamlanmıştır.....!");
                    System.Console.WriteLine("Güncel Liste Aşşağıdaki Gibidir.......!");
                    rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                }

                Console.WriteLine("* Yeniden silmek için : (1), * Silmeyi sonlandırmak için : (2)");
                string secim = Console.ReadLine();
                if (secim == "2")
                    break;

             }  Console.WriteLine("(1) Ana Menu için");
                 string secim1 = Console.ReadLine();
                if(secim1 == "1" )
                    continue;
            }
            // ################################################### SINIR ###################################################
            else if (secilenNumara == 3)//********************* Güncelleme işleminin yapıldığı Kod Blogu*******************
            {
                Console.WriteLine("(3)Var Olan Numarayı Güncelle");
                while(true)
                { 
                Console.WriteLine("Lütfen Güncelleme Yapmak İstediğiniz Kişinin İsmini veya Soyadını Giriniz:");
                string aranan = Console.ReadLine();
                // Kişiyi isim veya soyadına göre arıyoruz
                Kisi silinecekKisi = rehber.Find(kisiArama => kisiArama.Isim == aranan || kisiArama.Soyad == aranan);
                rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));
                // Güncelleme işlemini burada yapabilirsiniz
                Console.WriteLine("* Yeniden Güncellemek için : (1), * Güncellemeyi sonlandırmak için: (2)");
                string secim = Console.ReadLine();
                if (secim == "2")
                    break;
               }
            }
            // ################################################### SINIR ###################################################
            else if (secilenNumara == 4)//********************* Listeleme işleminin yapıldığı Kod Blogu*******************
            {
                Console.WriteLine("(4)Rehberi Listele");
                while(true)
                { 
                rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));
                Console.WriteLine("* Yeniden Rehberi Listelemek için : (1), * Rehberi Listeleyi sonlandırmak için : (2)");
                string secim = Console.ReadLine();
                if (secim == "2")
                    break;
                }
            }
            // ################################################### SINIR ###################################################
            else if (secilenNumara == 5)//********************* Arama işleminin yapıldığı Kod Blogu*******************
            {
                Console.WriteLine("(5)Rehberde Arama Yap");
                while(true)
                { 
                rehber.ForEach(kisi => Console.WriteLine($"{kisi.Isim} {kisi.Soyad} - {kisi.Telefon}"));

                Console.WriteLine("* Yeniden Rehberde Arama : (1), * Rehberde Arama Yapmayı sonlandırmak için: (2)");
                string secim = Console.ReadLine();
                if (secim == "2")
                    break;
                }
            }
            else{
                System.Console.WriteLine("Hatalı Tuşlama Yaptınız Lütfen Daha Sonra Tekrar Deneyiniz......");
                break;
            }
            // ################################################### SINIR ###################################################
            }

    }
        }
}

 
