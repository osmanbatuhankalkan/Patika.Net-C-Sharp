using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string [] args)
        {
            //out parametre bir fonk bir iş yaptırıp bir işi setletip, sonrasında bu seti kullanmak isterseniz bunu out parametre olarak verebilirsiniz.
            string sayi ="999"; //Biz bu sayıyı int olarak kullanmak için normalde pars ediyoruz , bu pars işleminin başarılı olup olmayacapınız kontrol etmek için garanti altına almak için TryParse metodnu kullanacağız.

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı !");
                Console.WriteLine(outSayi);

            }
            else{
                Console.WriteLine("Başarısızz! ");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot Aşırı Yükleme = Overloading
            //biz bir fonksiyonun imzasınız değiştirerek bir çok şekilde kullanabiliriz

             int ifade = 7777;
             instance.EkranaYazdir(Convert.ToString(ifade));
             //string ,int şeklinde bunu
             instance.EkranaYazdir(ifade);//bunu şimdi dönüşüm yapmadan yazabildik çünkü aşşağıda overloading yaptık
             //buna metot imzasına göre karar veriyor
             //metotAdı + parametre sayisi + parametre  
            instance.EkranaYazdir("Osman", "Batuhan");

        }
     }
     class Metotlar
     {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        //biz böyle yaparak hem string hem int değer alan karşılığı olan bir tip ürettik yani aşırı yükledik

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
        
     }
}