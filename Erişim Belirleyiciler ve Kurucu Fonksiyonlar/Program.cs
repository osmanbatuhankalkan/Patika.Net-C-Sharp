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

        System.Console.WriteLine("********************** Çalışan 1 **********************");
        Calisan calisan1 = new Calisan( "Osman Batuhan"," Kalkan",567839, "IT");//normalde 4-5 satırda yapılan iş tek satıra düştü
        calisan1.CalisanBilgileri();//calisan1 in bilgilerini ekrana yazdırır

        System.Console.WriteLine("********************** Çalışan 2 **********************");
        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Nevzat";
        calisan2.Soyad = " Kalkan";
        calisan2.No = 567838;
        calisan2.Departman = "Muhasebe";
        calisan2.CalisanBilgileri();

        System.Console.WriteLine("********************** Çalışan 3 **********************");
        Calisan calisan3 = new Calisan("Ali","Paşa");//isim,soyisim yazdırlır. numara 0, departman bos gelir
        calisan3.CalisanBilgileri();
        
 }
 class Calisan
 {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    
    //kurucu fonk bas
    public Calisan(string ad, string soyad, int no, string departman )//Burda oluşturduğumuz Kurucu fonk yukarısındaki class ile aynı ismi almalıydı ve bizde verdik.
    {
        this.Ad=ad;
        this.Soyad= soyad;
        this.No = no;
        this.Departman = departman;
    }
     public Calisan(string ad, string soyad )//Yeni Çalısmaya baslayan kişilerin no su ve departmanı olmadığı için böyle bir klasa daha ihtiyac duyduğumuzu var sayıyoruz
    {
        this.Ad=ad;
        this.Soyad= soyad;
    }
    public Calisan(){}
    //kurucu fonk bitis

    public void CalisanBilgileri()
    {
        System.Console.WriteLine("Çalışan Adı:{0}",Ad);
        System.Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
        System.Console.WriteLine("Çalışan Numarası:{0}",No);
        System.Console.WriteLine("Çalışan Departmanı:{0}",Departman);
    }
 }
}}