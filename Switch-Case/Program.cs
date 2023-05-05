using System;

namespace switch_case 
{
    class Program
    {
        static void Main(string[] args)
        {
        ///Bu sefer DateTime'ın Ayını getiren tipi üzerinde çalışalım
        ///Hangi Ayda oldupumuzu string olarak veren Switch-Case tipi üstünden 
                int month = DateTime.Now.Month;
        //Expression(Kontrol etmek isteğimiz kısım) hangi ifade üstünden (month)
                switch(month)
                {
                    case 2:
                    Console.WriteLine("Ocak ayındasınız! ");
                    break;///bu break her zaman kullanılmalı unutma

                    case 1:
                    Console.WriteLine("Şubat ayındasınız! ");
                    break;

                    case 8:
                    Console.WriteLine("Mart ayındasınız! ");
                    break;
                    ///yukarıda caseleri bilerek karışık yaptık burada bir sıra zorunlulupu yok şart uygun değilse bir sonrakine geçer 
                    default:
                    Console.WriteLine("Yanlış veri Girdiniz !");
                    break;

                    //Şuan Şubat ayındayız 2. ay case 2 nereye taşırsam o bloğu okuyor
                }

                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("Kış Ayındasınız ! ");
                        break;
                /// if-else olarak yapsak okunabilirlik anlamında işimiz uzayacaktı böyle ardı sıra terimlerde işlem(ay, yıl vb.) ve kod okunurlupunu yükseltiyor
                    default:
                    break;
                }
        }
    }
    
}