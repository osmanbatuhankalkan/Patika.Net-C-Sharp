using System;
using System.Collections.Generic;
namespace Polymorphism_ve_Sealed_Class

{
    public sealed class Canlilar //sealed kalıtımı engeller 
    {
        protected void Beslenme()
        {
            System.Console.WriteLine("Canlılar Beslenir.");
        }
         protected void Solunum()
        {
            System.Console.WriteLine("Canlılar Solunum Yapar.");
        }
         protected void Boşaltım()
        {
            System.Console.WriteLine("Canlılar Boşaltım Yapar.");
        }
        public virtual void UyaranlaraTepki(){
            System.Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}