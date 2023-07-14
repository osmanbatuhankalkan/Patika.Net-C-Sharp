using System;
using System.Collections;
using System.Collections.Generic;

namespace sinif_kavramı
{ 
class Program
 {
    static void Main(string[] args)
    {
        //Söz Dizimi
        /* class SinifAdi
        { 
            [Erişim Belirleyici][Veri Tipi] ozellikAdi;
            [Erişim Belirleyici][Geri Donus Tipi] MetotAdi([Parametre Listei])
            {
                /* Metot Komutları
            }
        }
        */
        //Erişim Belirleyiciler
        // * Public
        // * Private
        // * Internal
        // * Protected

        Calisan calisan1 = new Calisan();
        calisan1.Ad = "Osman Batuhan";
        calisan1.Soyad = " Kalkan";
        calisan1.No = 567839;
        calisan1.Departman = "IT";
        calisan1.CalisanBilgileri();//calisan1 in bilgilerini ekrana yazdırır
        System.Console.WriteLine("*********************************************");
        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Nevzat";
        calisan2.Soyad = " Kalkan";
        calisan2.No = 567838;
        calisan2.Departman = "Muhasebe";

        calisan2.CalisanBilgileri();

    }
 }
 class Calisan
 {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        System.Console.WriteLine("Çalışan Adı:{0}",Ad);
        System.Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
        System.Console.WriteLine("Çalışan Numarası:{0}",No);
        System.Console.WriteLine("Çalışan Departmanı:{0}",Departman);
    }
 }
}