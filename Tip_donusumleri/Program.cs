using System;

namespace Tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {   //İki Tip Dönüşüm Vardır
            //implicit Conversion (Bilinçsiz Dönüşüm)
            //Explicit Conversion (Bilinçli Dönüşüm)

            //implicit Conversion (Bilinçsiz Dönüşüm)

            Console.WriteLine("Bilinçsiz Dönüşüm:");
            byte a=6;
            sbyte c=4;
            short b=2;
            
            int d= a+b+c;
            Console.WriteLine("d:"+ d);

            long h= d;
            Console.WriteLine("h:"+ h);

            float i=h;
            Console.WriteLine("i:"+i);

            string e = "batuhan";
            char f='k';
            object g = e+f;
                         Console.WriteLine("g:" + g);



            //Explicit Conversion (Bilinçli Dönüşüm)
            //C# ın kendi kendine yapamadığı dönüşümler, birşekilde bizim dönüşümün derleyiciye bildirmemiz.
             Console.WriteLine("Bilinçli Dönüşüm:");

             int x=4; 
             // byte y =6; böyle yazsak hata alıcaktık bu hatayı
             byte y = (byte)x; //diyerek aşıyoruz parantez sağdaki değişkene tanımlanuyor
               Console.WriteLine("y"+ " = " + y);

            int z = 100;
            byte t=(byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:"+ v);
            //çevrimlerde veri kayıp olabilir 

            //*****ToString Methodu *******
            ///aldıpı veriyi stringe test eder
            Console.WriteLine("************** ToString Methodu*************");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" +zz);

            //System.Convert
            Console.WriteLine("************** System.Convert *************");
            string s1 ="10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" +Toplam);

            //Pars
            Console.WriteLine("************** PARS *************");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            Double double1;

            //Pars her zaman string ifadelere dönüştürmede kullanılır

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1:" + rakam1);
            Console.WriteLine("double1:" + double1);

        }
    }
}