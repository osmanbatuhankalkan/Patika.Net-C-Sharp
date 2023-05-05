using System;

namespace Donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
            Console.Write("Lütfen bir sayı Giriniz: ");
            int sayac= int.Parse(Console.ReadLine());
            
            ///Console Readline string olarak algılar o yüzde integer a çevirmek lazım "Parse" kullanıyoruz
            for (int i =1; i<sayac; i++)
            {
                if(i%2 == 1)//Komutlar
                    Console.WriteLine(i);
            }    
            
            // 1 ile 1000 arasındaki tek ve çift sayıların ken içinde toplamlarını ekrana yazdır
            //daha sonra erişebilmek için for dışında tanımlama yapmamız gerekiyor
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i =1; i<=1000; i++)

            
            {
                if(i%2 ==1)
                    tekToplam += i; //tekToplam = tekToplam +i; demek
                else
                    ciftToplam +=i;
                
                Console.WriteLine("Tek Toplam" + tekToplam);
                Console.WriteLine("Çift Toplam" + ciftToplam);
                
                //break, continue
                ///döngü sonlandırma, bir şarata bağlı olarak mevcut döngüde atlama yapmak istiyorsanız.

                for (int o = 1; o < 10; o++)
                {
                    if(o==4)
                        break;
                    Console.WriteLine(o);
                }
                for (int o = 1; o < 10; o++)
                {
                    if(o==4)
                        continue;
                    Console.WriteLine(o);
                }
                
            }
        }
    }
}