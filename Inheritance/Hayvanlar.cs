using System;
using System.Collections.Generic;
namespace Kalıtım

{
    public class Hayvanlar:Canlilar//Hayvanlara canlılar sınıfından kalıtım aldırdık
    {
        protected void Adaptasyon()//Hem sürüngen hem kuşlarda ortak olan genel özellik
        {
            System.Console.WriteLine("Hayvanlar Adaptasyona uğrayabilir .");
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
        }
        public void Ucmak(){//kuşların kendine has özelliği
            System.Console.WriteLine("Kuslar Uçarak Hareket eder.");
        }
} 
}