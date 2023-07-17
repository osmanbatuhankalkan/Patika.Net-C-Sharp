using System;
using System.Collections;
using System.Collections.Generic;

namespace Static_Sınıf_ve_Üyeler
{
    class Program
    {
     static void Main(string[] args)
     {
        System.Console.WriteLine(Gunler.Pazar);
        System.Console.WriteLine((int)Gunler.Cumartesi);
        //ekrandan user dan bir sıcaklık değeri aldığımızı varsayalım
        int sıcaklık =32;

        if(sıcaklık <= (int)HavaDurumu.Normal)
        {
            System.Console.WriteLine("Dışarıya çıkmak için biraz daha ısınmasını bekle.");
        }
        else if(sıcaklık>=(int)HavaDurumu.Sıcak)
        {
            System.Console.WriteLine("Dışarıya çıkmak için çok sıcak");
        }
        else if(sıcaklık >= (int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSıcak)
        {
            System.Console.WriteLine("Dışarı çıkılır!");
        }
     }
    } 
    enum Gunler
    {
        Pazartesi=8,//normalde 1,2,3 diye index alır ama sen bir başlangıç verirsen ona göre sıralanır.
        Salı,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        soguk =5,
        Normal=20,
        Sıcak=25,
        CokSıcak=30,
    }
}