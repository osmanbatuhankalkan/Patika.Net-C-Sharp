using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama Ve İşlemli Atama
            int x = 3;
            int y = 3;

            y = y+2; ///2 arttırma
            Console.WriteLine(y);

            y += 3; ///bu işlemli atama deniyor
            Console.WriteLine(y);

            y/=2;
            Console.WriteLine(y);

            x *=2; /// x*2 nin cevabı
            Console.WriteLine(x);


            ///Mantıksal Operatörler
            /// \\,&&, !

            bool isSucces = true;
            bool isCompleted = false;

            if(isSucces && isCompleted)
            {
                Console.WriteLine("Perfect !");
            }

            if(isSucces || isCompleted)
            {
                Console.WriteLine("Great !");
            }

            if(isSucces && !isCompleted)
            {
                Console.WriteLine("Very Perfect !");
            }

            //İLİŞKİSEL Operatörler
            // <,>,<=,>=,==,!=

            int d=5;
            int k=9;

            bool sonuc = d>k;
            Console.WriteLine(sonuc);

            sonuc = d<k;
            Console.WriteLine(sonuc);

            sonuc = d>=k;
            Console.WriteLine(sonuc);

            sonuc = d<=k;
            Console.WriteLine(sonuc);

            sonuc = d==k;
            Console.WriteLine(sonuc);

            sonuc = d!=k;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler
            /// +,-,*,/,

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1++;
            Console.WriteLine(sayi1);

            ///MOD ALMA bölümden Kalanı bulur 
            // %
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);





        }
    }
}