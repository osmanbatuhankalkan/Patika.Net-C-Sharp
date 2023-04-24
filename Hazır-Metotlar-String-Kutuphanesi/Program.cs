using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp,Hoşgeldiniz!";
            string degisken2 = "dersimiz Csharp,Hoşgeldiniz!";
            //length = içerisinde kaç karakter var onu belirtir
            Console.WriteLine(degisken.Length);


            Console.WriteLine(degisken.Replace("CSharp","C#"));

            //ToUooer, ToLower = ya hepsi büyür ya hepsi küçülür
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat = 2 tane parametre alıyor 
            Console.WriteLine(string.Concat(degisken,"Merhaba"));

            //Compare , CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true)); //burada true dersek büyük küçük harf duyarsız hale gelir
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); //True
            Console.WriteLine(degisken.EndsWith("Merhaba!")); //FALSE

            //Indexof
            Console.WriteLine(degisken.IndexOf("Cs"));//Bulursa hangi satır olduğunu yazdırır bulamazsa -1 döner
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Obk"));//dedimki 0.Indexe bunu ekle oda ekledi

            //PadLeft, PadRight;
            Console.WriteLine(degisken + degisken2.PadLeft(30));//pedleft sonuna 30 a tamamlayacak kadar boşluk tanımlardegisken2 30 dan küçükse hiçbir şey yapmayacaktır
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); //30dan sonra git yıldız eklede diyebiliyoruz
            Console.WriteLine(degisken.PadRight(50) + degisken2);//50 adet boşluk
            Console.WriteLine(degisken.PadRight(50,'-')+ degisken2);//50 adet boşluğa karşılık gelen - ekledi

            //Remove
            Console.WriteLine(degisken.Remove(10));//10.karaktersen sonrasını siler
            Console.WriteLine(degisken.Remove(5,3));//5.indexten başla 3 karakter sil 
            
            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));//CSharpla C# ı değiştir dedik
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split En çok kullanılanlardan
            Console.WriteLine(degisken.Split(' ')[1]); //git dizi içerisinden 1 i getir dedik 

            //substring
            Console.WriteLine(degisken.Substring(4));//4.indexten başla sonuncuya kadar getir
            Console.WriteLine(degisken.Substring(4,6));//4 den başla 6 karakter getir

        }
    }
}