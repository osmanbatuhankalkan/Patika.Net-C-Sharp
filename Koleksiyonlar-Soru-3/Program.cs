using System;
using System.Collections.Generic;

namespace Kolleksiyon_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> harfler = new List<char>();//liste içinde arama yapabilmek için LİST<T> tipini seçtim
            string sesliHarfler = "a,e,ı,i,u,ü,o,ö";//harflerimizi tanımladık

            System.Console.WriteLine("Lütfen Cümlenizi giriniz");
            string cümle = System.Console.ReadLine();
            foreach (var item in cümle)
            {
                if(sesliHarfler.Contains(item))//contains'imiz liste içinde arama yapar
                {
                    harfler.Add(item);
                }
            }

            harfler.Sort();//sıralayalım
            harfler.ForEach(sıralama =>System.Console.WriteLine(sıralama));

           
        }
    }
}
