using System;
using System.Collections;
using System.Collections.Generic;

namespace Static_Sınıf_ve_Üyeler
{
    class Program
    {
     static void Main(string[] args)
     {
        //Class(sınıfları kullanmak için nesnesini oluşturuyorduk)
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.KisaKenar = 3;
        dikdortgen.UzunKenar = 4;
        
        System.Console.WriteLine("Class Alan Hesabı :{0}", dikdortgen.AlanHesapla());

        //Burada da nesnemizi oluşturuyoruz ve üzerinden değerlerimizi atıyoruz
        Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();//bunu şöylede kullanabiliyoruz opsiyonel olarak
        //* Dikdörtgen_Struct dikdörtgen_struct; bunu classlarla yapamayız
        dikdortgen_Struct.KisaKenar =5;
        dikdortgen_Struct.UzunKenar =6;

        System.Console.WriteLine("Struct Alan Hesabi:{0}",dikdortgen_Struct.AlanHesapla());

        /*Aşşağıdaki şu tanımımızdan dolayı 
         public Dikdortgen_Struct2(int kisaKenar,int uzunKenar)
        {
            KisaKenar =kisaKenar;
            UzunKenar =uzunKenar;
        }
        Bu Değerleri Şöylede yazabiliyoruz
        */
        Dikdortgen_Struct dikdortgen_Struct2 = new Dikdortgen_Struct(9,15);
        System.Console.WriteLine("Struct Alan Hesabi:{0}",dikdortgen_Struct2.AlanHesapla());

        
         
     }
    }
    class Dikdortgen //class değelere değer atamasakta kendi otomatik default değerlerini atar ve biz sorunsuz devam edebiliriz. örn: int'e 0, stringe null ama BİZ STRUCTa değer girmezsek kendisi değer atayamıyor sorun veriyor
    //sınıflar çok güçlü referans türünde olduğu için stackde değilde heap te tutuldupu için performansta avantaj sağlıyor 
    //structlarda heapde tutuldupu için hızlı 
    //16byte kadar veriler için struct, 16 dan büyük veriler için sınıflar yani referans türde tutmal daha avantaj sağlamakta tavisiye edilen şekil budur performansta
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen()//default değeri kendimiz doğrudan değer atayabiliyoruz fakat bu struct da işe yaramaz 
        {
            KisaKenar =3;
            UzunKenar =4;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
         public Dikdortgen_Struct(int kisaKenar,int uzunKenar)
        {
            KisaKenar =kisaKenar;
            UzunKenar =uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdortgen_Struct2
    {
        public int KisaKenar;
        public int UzunKenar;
         public Dikdortgen_Struct2(int kisaKenar,int uzunKenar)
        {
            KisaKenar =kisaKenar;
            UzunKenar =uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
