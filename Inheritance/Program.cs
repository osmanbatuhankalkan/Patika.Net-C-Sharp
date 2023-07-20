using System;
using System.Collections.Generic;
namespace Kalıtım
//kalıtım: Bir üst sınıfın alt sınıfa miras vermesi oluyor. Alt sınıfın üst sınıfın bazı özelliklerini kullanması ait olaması gerçek hayattaki miras alma miras vermeden geliyor diyebiliriz.
//C# da ":" kalıtım demektir. ":" koyulduğu zaman sol tarafımızdaki kişiselleştirilmiş özelliğimiz olurken sağ tarafında ise kalıtımı almak istediğimiz sınıf olur. Örnek olarak: "public class Sürümgenler:Hayvanlar"
//                                         Canlılar
//                              _______________|______________
//                       ___Bitkililer___               ___Hayvanlar__
//                       \               \              \            \
//                  Tohumlu         Tohumsuz        Kuslar         Surungenler
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
           //Program cs içerisinde daha az kodla daha güvenilir bir şekilde üst sınıfların yapmaları gerekenlerı özellik içinde tanımyalarak oluşturup çağrılmasını sağladık daha kontrollü oldu Kalıtım konusuna örneğimizi böylelikle anlaşılır bir şekilde vermis olduk
        }
    }
}