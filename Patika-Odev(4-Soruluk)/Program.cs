using System;
namespace Odev1
{
class Program
{
    static void Main(string[] args)
    {   //Soru1
        Console.Write("Lütfen pozitif bir sayı girin Giridiğiniz bu sayı işlem adedinizi belirleyecektir....");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Çift bulmak istediğiniz sayıları giriniz ");

        for (int i = 0; i < n; i++)
        {
            int deger1 = Convert.ToInt32(Console.ReadLine());
            if (deger1 % 2 == 0)
            {
                Console.WriteLine(deger1 + " çifttir.");
            }
        }
        Console.ReadLine();
        Console.WriteLine("***********************************************************************************");
        //Soru2
        Console.Write("Lütfen pozitif 2 adet sayı giriniz.......");
        Console.Write("Bu ilk gireceğiniz değer kaç adet pozitif değer girmek istiyosanız onun için .....");
        int k = Convert.ToInt32(Console.ReadLine());
         Console.Write("Bu ikinci gireceğiniz değer eşit yada tam bölsün istediğiniz değer için ......");
        int l = Convert.ToInt32(Console.ReadLine());

         for (int i = 0; i < k; i++)
        {
            int  deger2 = Convert.ToInt32(Console.ReadLine());
            if (deger2  == l)
            {
                Console.WriteLine(deger2 + " Eşittir.");
            }
            else if(deger2 %l==0)
            {
                Console.WriteLine(deger2 + " Tam Bölünür");
            }
            else
            Console.WriteLine("Bölünmez");
        }
        Console.WriteLine("***********************************************************************************");
        //Soru3
       Console.Write("Kaç kelime gireceksiniz? Lütfen pozitif bir sayı girin: ");
        int u = int.Parse(Console.ReadLine());

        // n adet kelime girmesini isteyin ve bunları bir diziye kaydedin
        string[] kelimeler = new string[n];
        for (int i = 0; i < u; i++)
        {
            Console.Write(i + 1 + ". kelimeyi girin: ");
            kelimeler[i] = Console.ReadLine();
             
        }
        Array.Reverse(kelimeler);
        foreach(var p in kelimeler)
        {
            Console.WriteLine(p);
        }
        //soru4
        
        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();

        // Kelime sayısını hesapla
        int kelimeSayisi = cumle.Split(' ').Length;

        // Harf sayısını hesapla
        int harfSayisi = cumle.Length;

        Console.WriteLine("Girilen cümle: " + cumle);
        Console.WriteLine("Kelime sayısı: " + kelimeSayisi);
        Console.WriteLine("Harf sayısı: " + harfSayisi);


    }

}
}
