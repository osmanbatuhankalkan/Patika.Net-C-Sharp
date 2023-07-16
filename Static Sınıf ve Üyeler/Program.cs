using System;
using System.Collections;
using System.Collections.Generic;

namespace Static_Sınıf_ve_Üyeler
{
    class Program
    {
     static void Main(string[] args)
     {
        //*Çok önemli bir noktada ilk static class mı ? calısacak public class ımız mı ?
        //*Önce static oda sadece başta 1 kere çalışır çalışana ilk erişildiğinde sonra publice girilcek

        System.Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);//Calisan.CalisanSayisi burada da zaten private olan değilde public olana erişebildiğimizi görüyoruz "99"u yazdıran kısım
        Calisan calisan=new Calisan("Osman Batuhan","Kalkan","IT");//1 elemean atadığımız için 1 attı 100 oldu
        System.Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);//100 ü yazdıran kısım
        /*
        calisan.Isım = "Osman Batuhan";
        calisan.Soyisim = "Kalkan";
        calisan.Departman = "IT";
        Şeklinde yazamıyoruz malesef çünkü altta 
        private string Isim;//field
        private string Soyisim;//field
        private string Departman;//field
        olarak private yaptık
        Biz bunları SET lemek için aşşağıda şöyle tanımladığımız gibi 
        public Calisan(string ısim, string soyisim , string departman) bu şekil setlenecek onuda şimdi bu not satırının hemen üstünde göstereceğim
        */
        System.Console.WriteLine("Toplama işlemi sonucu : {0}", Islemler.Topla(100,200));
        System.Console.WriteLine("Cıkarma işlemi sonucu : {0}", Islemler.Cıkar(100,200));
        //* Burada Öenmli çıakrımlarımız: Statik sınıfların içerinde statik olmayan herhangi bir metot yada property kullanmayız tanımlayamayız. Static sınıflardan kalıtım uygulanamaz static sınıflara.
     }  
    }
    /* Statik olmayan class lar oradaki üyeler o sınıfın nesnelerine özel "set"'leniyor ve "get"'leniyorken.
    Bir sınıf içinde statik olan üyeler sınıf bazında atanır
     */
    class Calisan //Yaratılan CLass
    {
        private static int calisanSayisi;//Mesela bu sınıfa atanmıştır bu özelliğe sınıf aracılığıyla erişeceğimiz için her zaman değiştirilen son değeri getirecektir.
        public static int CalisanSayisi { get => calisanSayisi;}//Buradan "set => calisanSayisi = value;" setini silerek yukarıda private olarak tanımladığımız calısan sayımıza setide iptal ederek aşşağıda kurucumuz aracılığıla arttırma azaltma işlemini yapacağız
        

        private string Isim;//field
        private string Soyisim;//field
        private string Departman;//field

        static Calisan()// STATİC CLASS ların geri dönüş ve erişim belirtecleri yoktur
        {
            calisanSayisi =99;
        }

        public Calisan(string ısim, string soyisim , string departman)//Yaratılan class içerisindeki KURUCU CLASS
        {
            this.Isim = ısim;//yukarıdaki field ları set lemiş olduk
            this.Soyisim = soyisim; //yukarıdaki field ları set lemiş olduk
            this.Departman = departman;//yukarıdaki field ları set lemiş olduk
            calisanSayisi ++;//yukarıda private olan özelliği bir arttırıyoruz.Bu sefer public static olan "public static int CalisanSayisi { get => calisanSayisi;}" geri döndürüleceği için arttırılmış olan bize geri dönecektir.
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cıkar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
//*Neden statik yaptık neden ihtiyac duyduk bir sınıfı static yaparsak o class içindeki hersey statik olmak zorundadadır. içeride static olmayan hiç bir üyeyi kullanamzsın buda bize neyi sağlar sınıf içinde herşeyi static olarak kullanıcaksak o sınıfı koruma altına almış oluruz hemde dışardan bakınca sınıfı statik görürsek ozaman bu sınıfın içindeki herşey statik deriz okunabiliriği bizim açımızdan arttır.