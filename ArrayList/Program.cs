using System;
using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
    {
        //ArrayListler dinamik yapılardır otomatik büyür küçür bir den çok veri tipi içinde barındırabilir.
        ArrayList liste= new ArrayList();
        //eleman atama arrayliste
        liste.Add("Ayşe");
        liste.Add(2);
        liste.Add(true);
        liste.Add('A');
        //içerisinde verilere erişim
        System.Console.WriteLine(liste[1]);
        //foreach ilede tek tek içiersinde gezinebiliriz
        foreach (var item in liste)
        {
            System.Console.WriteLine(item);
        }
        //AddRange birden fazla ifadeyi toplu ekleme
        System.Console.WriteLine("******* Add Range ************");
        string[] renkler = {"kırmızı","sarı","yesil"};
        List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
        liste.AddRange(renkler);
        liste.AddRange(sayılar);
        foreach (var item in liste)
        {
            System.Console.WriteLine(item);
        }
        //SORT (SIRALAMA)
        ArrayList liste2= new ArrayList();
        liste2.AddRange(sayılar);
        System.Console.WriteLine("**** Sort ****");
        liste2.Sort();
        foreach (var item in liste2)
        {
            System.Console.WriteLine(item);
        }
        //Binary Search 
        //kullanmak için önce sıralayıp öyle kullanmamız gerekiyor biz zaten yukarıda sıraladık
        System.Console.WriteLine("Binary Search ");
        System.Console.WriteLine(liste2.BinarySearch(9));//5. index sonucunu alırız

        //Reverse (terse çevirecektir sıralamayı)
        System.Console.WriteLine("**** Reverse ****");
        liste2.Reverse();
        foreach (var item in liste2)
        {
            System.Console.WriteLine(item);
        }
        //Clear Temizler listeyi
        liste2.Clear();
        System.Console.WriteLine("******** Clear ********");
        foreach (var item in liste2)
        {
            System.Console.WriteLine(item );
        }
    }
    }
}