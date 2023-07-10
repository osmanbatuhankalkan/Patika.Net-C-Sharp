using System;
using System.Collections;
using System.Collections.Generic;

namespace Kolleksiyonlar_Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] pozitifSayı = new int[3];
          
          
          
          System.Console.WriteLine("Lütfen Pozitif Tam Sayı Değerlerinizi Giriniz....");
          for(int i=0;i<pozitifSayı.Length;i++)
          { 

            ArrayList sayıAsal = new ArrayList();
            ArrayList sayıAsalOlmayan = new ArrayList();
            int Deger = Convert.ToInt32(Console.ReadLine());

            if(Deger%2==1 && Deger%Deger==0)
            {   
                System.Console.WriteLine("Asal Sayıdır");
                sayıDüzenleme(ref Deger);
                
            }
            //İstisna
            else if(Deger==2)
            {   
                System.Console.WriteLine("Asaldır");
                sayıDüzenleme(ref Deger);
                
                
            }
            else if(Deger==1)
            {
                System.Console.WriteLine("Asal Değildir");
                sayıDüzenleme(ref Deger);
                
                
            }
            else if(Deger<=0)
            {   
                System.Console.WriteLine("Negatif ve uygunsuz Değer Girdiniz Döngüden Çıkılıyor.....");
                break;
            }
            else
            {
                 System.Console.WriteLine("ASAL OLMAYAN");
                 sayıDüzenleme(ref Deger);
                
                
            }

          foreach (int asAl in sayıAsal)
          {
            System.Console.WriteLine(asAl);
          }
          foreach (int asAlOlmayan in sayıAsalOlmayan)
          {
            System.Console.WriteLine(asAlOlmayan);
          }
          
          } 
            
          
        }
       public static void sayıDüzenleme(ref int Deger)
       {
        int gecici = Deger;
        
        System.Console.WriteLine(Deger);
       }
    }
}