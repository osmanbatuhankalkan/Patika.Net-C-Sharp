using System;

namespace While_ve_ForEach_Döngüleri
{
    class Program
    {
        static void Main(string[]args)
        {
            //While
            //1 den baslayarak consoldan girilen sayıya kadar (sayı dahil) ortalam hesaplayıp consola yazıralım
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            //ortalama almak için toplama ihtiyac var 
            int toplama = 0;
            while(sayac <= sayi)
            {
                toplama+= sayac;
                sayac ++;
            }
            Console.WriteLine(toplama/sayi);

            // a'dan z'ye kadar tüm harfleri console çıkar
            char karakter = 'a';
            while (karakter < 'z')
            {
                Console.WriteLine(karakter);
                karakter++;
            }
            Console.WriteLine("********FOREACH*********");
            string[] arabalar ={"BMW","FORD","VS"};
            //Var tipi belli olmayan genel bir tanım ifadesi için böyle düşünebiliriz
            //item(araba)her bi degerimiz için bmw for vs 
            //collection(arabalar)
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            
        }
    }
}