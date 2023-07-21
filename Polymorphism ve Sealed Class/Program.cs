using System;
using System.Collections.Generic;
namespace Polymorphism_ve_Sealed_Class
//Polymorphism(çok biçimcilik)le beraber hayatımıza yeni kavramlar giriyor virtual anahtar kelimesiyle sağlıyoruz sanal metotlar yaratıyoruz peki bu sanal metotlar ne yapıyor? sanal metotlar kalıtım alınan yani biras veren olan üst sınıf içerisinde yazılan ve daha sonra alt sınıflar tarafından yeniden yazılabilen biçimi değiştirilerek, biçimine yeni ifadelere katılarak veya tamamen değiştirlirek sağlanan metotlardır bunuda override anahtar kelimesitle sağlıyoruzz

{
    class Program
    {
        static void Main(string[] args)
        {
           TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();//nesenesini oluşturduk
           tohumluBitkiler.TohumlaCogalma();
           System.Console.WriteLine("*************************************************");
           Kuslar Martı = new Kuslar();
           Martı.Ucmak();
           
        }
    }
}
//kalitim engelemek istiyorsak sealed anahtar kelimesi kullanılır
//bu sealed class lar ile kullanılır canlılar sınıfından tanımlayıp burada uygulayalım