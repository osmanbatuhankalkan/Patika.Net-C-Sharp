using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyon_sorular2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int[] deger = new int[4];
        System.Console.WriteLine("Lütfen Değerlerinizi Giriniz......");
        for (int i = 0; i < 4; i++)
        {
         int girilenDeger = Convert.ToInt32(Console.ReadLine());
         deger[i] = girilenDeger;
         
        }
        System.Console.WriteLine("Girilen Değerler");
        foreach (var item in deger)
        {
         System.Console.WriteLine(item);
        }
        System.Console.WriteLine("*********************************************");
        System.Console.WriteLine("********************* Sıralama ****************");
        Array.Sort(deger); //Değişken elemanlarını sıralar.
          foreach (var item in deger)
        {
         System.Console.WriteLine(item);
        }
        System.Console.WriteLine("******************* En Küçük 3 Değer ***********");
        System.Console.WriteLine($"{deger[0]},{deger[1]},{deger[2]}",deger,deger,deger);

        System.Console.WriteLine("******************* En Küçük 3 Değer Ortalaması ***********");
        int ortalamaK = ((deger[0]+deger[1]+deger[2])/3);
        System.Console.WriteLine($"ortalama={ortalamaK}",ortalamaK);

        Array.Reverse(deger); //Değişken elemanlarını ters çevirir

        System.Console.WriteLine("******************* En Büyük 3 Değer ***********");
        System.Console.WriteLine($"{deger[0]},{deger[1]},{deger[2]}",deger,deger,deger);

        System.Console.WriteLine("******************* En Büyük 3 Değer Ortalaması ******");
        int ortalamaB = ((deger[0]+deger[1]+deger[2])/3);
        System.Console.WriteLine($"ortalama={ortalamaB}",ortalamaB);

        System.Console.WriteLine("******************* En Büyük ve En küçük Değerlerin Ortalama Toplamı ******");
        int Toplam = ortalamaB+ortalamaK;
        System.Console.WriteLine($"{Toplam}",Toplam);
        }
    }
}