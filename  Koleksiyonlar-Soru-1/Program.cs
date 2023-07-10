using System;
using System.Collections;
using System.Collections.Generic;
/* 
Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/
namespace Kolleksiyonlar_Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
          ArrayList sayıAsal = new ArrayList();
          ArrayList sayıAsalOlmayan = new ArrayList();
          
          System.Console.WriteLine("Lütfen Pozitif Tam Sayı Değerlerinizi Giriniz....");
          for(int i=0;i<20;i++)
          { 
            int Deger = Convert.ToInt32(Console.ReadLine());
            int aSal=0;
            int aSalOlmayan=0;

            if(Deger%2==1 && Deger%Deger==0)//asal
            {   
              aSal += Deger;
             }  
            //İstisna
            else if(Deger==2)//asal
            {   
              aSal += Deger;  
             
            }
            else if(Deger==1)//değil
            { 
              aSalOlmayan += Deger;  
            }
            else if(Deger<=0)//Negatif ve uygunsuz Değer Girdiniz Döngüden Çıkılıyor
            {   
              break;
            }
            else//asal olmayan
            {
              aSalOlmayan += Deger;  
            }
            sayıAsal.Add(aSal);
            sayıAsalOlmayan.Add(aSalOlmayan); 
        }
          //Asal olanlarla Asal olmayanları Ayırdığımız Grup
            System.Console.WriteLine("*****************");
            System.Console.WriteLine("Asal Sayı Olanlar");
           foreach (var item in sayıAsal)
           {
            System.Console.WriteLine(item);
           }
           
           System.Console.WriteLine("################");
           System.Console.WriteLine("Asal Sayı Olmayanlar");
             foreach (var item in sayıAsalOlmayan)
           {
            System.Console.WriteLine(item);
           }
           
          //Sıralamayı Sağlayan Kısım Küçükten Büyüğe
           sayıAsal.Sort();
           sayıAsalOlmayan.Sort();
            System.Console.WriteLine("*****************");
            System.Console.WriteLine("Asal Sayı Olanların Sıralanmış Hali");
           foreach (var item in sayıAsal)
           {
            System.Console.WriteLine(item);
           }
             System.Console.WriteLine("################");
            System.Console.WriteLine("Asal Sayı Olmayanların Sıralanmış Hali");
           foreach (var item in sayıAsalOlmayan)
           {
            System.Console.WriteLine(item);
           } 
           //Her iki Dizinin Eleman Sayısını yazdırdığımız kısım
           
           Double sumAsal=0;
           sumAsal = sayıAsal.Count;
           Double sumAsalolmayan=0;
           sumAsalolmayan = sayıAsalOlmayan.Count;
           
            System.Console.WriteLine("*****************");
            System.Console.WriteLine("Asal Sayı Olanların Eleman Sayısı");
           foreach (var item in sayıAsal)
           {
            System.Console.WriteLine(sumAsal);
            
           }
            System.Console.WriteLine("################");
            System.Console.WriteLine("Asal Sayı Olmayanların  Eleman Sayısı");
           foreach (var item in sayıAsalOlmayan)
           {
            System.Console.WriteLine(sumAsalolmayan);
           
           }
           //Her iki Dizinin Ortalmasını yazdırdığımız kısım
           Double ortalma =0;
           
           for (int i = 0; i < 20; i++)
           {
            int ortalamaAsal = (int)sayıAsal[i];
            int ortalamaAsalolmayan = (int)sayıAsalOlmayan[i];
            ortalma = (ortalamaAsal+ortalamaAsalolmayan)/20;
           }
           System.Console.WriteLine("Ortalama: "+ ortalma);

    }
} }