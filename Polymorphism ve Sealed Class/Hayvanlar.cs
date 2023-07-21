using System;
using System.Collections.Generic;
namespace Polymorphism_ve_Sealed_Class

{
    public class Hayvanlar:Canlilar//Hayvanlara canlılar sınıfından kalıtım aldırdık
    {
        protected void Adaptasyon()//Hem sürüngen hem kuşlarda ortak olan genel özellik
        {
            System.Console.WriteLine("Hayvanlar Adaptasyona uğrayabilir .");
        }
        public override void UyaranlaraTepki()//bu şu demek uyaranlara tepki sanal olarak yaratıldığı yeredeki halini gel buraya koy bir kez çalıştır demek
        {
            base.UyaranlaraTepki();//Üst sınıftan gelen cw yi ekrana yazıcak
            System.Console.WriteLine("Hayvanlar Temasa Tepki verir");//Hemde kendi içindeki bu satırı yazıcak
        }
    }
    //Hayvanlar sınıfından kalıtım alabileceği hayvanlar sınıfının miras verebileceği neyi var diye baktığımızda,gruplamamızı yaptığımızda Sürüngenleri ve kuşları alabılırız
    public class Sürüngenler:Hayvanlar
    {
        public Sürüngenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void SurunerekHareketEdeler(){//Sürüngenlerin kendine has özelliği
            System.Console.WriteLine("Sürüngenler sürünerek hareket eder");
        }
    }
    public class Kuslar:Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
            base.UyaranlaraTepki();//tanımlamamızıda yaptık
        }
        public void Ucmak(){//kuşların kendine has özelliği
            System.Console.WriteLine("Kuslar Uçarak Hareket eder.");
        }
} 
}