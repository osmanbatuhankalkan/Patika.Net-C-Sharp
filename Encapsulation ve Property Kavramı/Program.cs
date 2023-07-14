using System;
using System.Collections;
using System.Collections.Generic;
/* 
Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/
namespace Kolleksiyonlar_Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
          Ogrenci ogrenci = new Ogrenci();
          ogrenci.Isim = "Osman Batuhan";
          ogrenci.Soyisim = "Kalkan";
          ogrenci.OgrenciNo = 123456;
          ogrenci.Sinif = 3;
          //aşşağıda bu isim,soyisimi,sınıfino gibi değerlerimizin get, setlerini oluştumasaydık yada sadece get oluşturup set olmasaydı okuyabilir fakat yazdırmazdı o mantık hakim.
          ogrenci.OgrenciBilgileriniGetir();

          ogrenci.SinifDusur();
          ogrenci.OgrenciBilgileriniGetir();

          Ogrenci ogrenci2 =new Ogrenci("Ali","Veli",256,1);
          ogrenci2.SinifDusur();
          ogrenci2.SinifDusur();
          ogrenci2.OgrenciBilgileriniGetir();
        }
        
    } 
    class Ogrenci
    {
        private string isim;//Command+. yapınca alanı kapsülle ve özelliği kullan seçeneğini seçince
        private string soyisim;
        private int ogrenciNo;
        private int sinif;
        public string Isim 
        { 
            get {return isim;}  
            set {isim = value;} 
        }//otomatik oarak bunu bize yazıp getiriyor. fakat biz bunu okunabilirliği artsın diye bu şekle getirdik
        public string Soyisim { get => soyisim; set => soyisim = value; }//otomatik oarak bunu bize yazıp getiriyor.
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }//otomatik oarak bunu bize yazıp getiriyor.
        public int Sinif //sınıf değerini neden bu hale getirdik çünkü senaryo oluşturduk ve sınıfımızı yükseltip alçatabiliyoruz buraya kadar okey fakat düşerken 1 den daha geriye gitmesin istiyoruz.
        { 
            get => sinif; 
            set { 
                if(value < 1)
                {
                    System.Console.WriteLine("Sınıfı En Az 1 Olabilir !!");
                    sinif=1;
                } 
                else
                    sinif = value;  
                }
        }//otomatik oarak bunu bize yazıp getiriyor.

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)//parametreli aşırı yükleme yaptık
        {
            Isim = isim;//yukarıdaki get setlerdeki ifadelerimzede command+. yapınca parametre olarak ekleyetıkladıık kendisi böyle otomatık oluşturdu
            Soyisim = soyisim;//yukarıdaki get setlerdeki ifadelerimzede command+. yapınca parametre olarak ekleyetıkladıık kendisi böyle otomatık oluşturdu
            OgrenciNo = ogrenciNo;//yukarıdaki get setlerdeki ifadelerimzede command+. yapınca parametre olarak ekleyetıkladıık kendisi böyle otomatık oluşturdu
            Sinif = sinif;//yukarıdaki get setlerdeki ifadelerimzede command+. yapınca parametre olarak ekleyetıkladıık kendisi böyle otomatık oluşturdu
        } 
        public Ogrenci(){}// boş alan kurucusunu oluşturduk.

        //öğrenci bilgilerini geri döndüren bir metot daha yazalım
        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("********** Öğrenci Bilgilerini Getir **********");
            System.Console.WriteLine("Öğrenci Adı.      :{0}",this.Isim);
            System.Console.WriteLine("Öğrenci Adı.      :{0}",this.Soyisim);
            System.Console.WriteLine("Öğrenci Adı.      :{0}",this.OgrenciNo);
            System.Console.WriteLine("Öğrenci Adı.      :{0}",this.Sinif);
        }
        //Şimdi yardımcı metot yazacağız dışarıdan öğrencinin sınıfı arttırmak yada düşürmek istiyorum
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif +1;
        }
        public void SinifDusur()
        {
            this.Sinif=this.Sinif -1;
        }
    }
}