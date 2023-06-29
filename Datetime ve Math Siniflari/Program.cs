using System;
namespace Datetime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(DateTime.Now);
            System.Console.WriteLine(DateTime.Now.Date);
            System.Console.WriteLine(DateTime.Now.Day);
            System.Console.WriteLine(DateTime.Now.Month);
            System.Console.WriteLine(DateTime.Now.Year);
            System.Console.WriteLine(DateTime.Now.Hour);
            System.Console.WriteLine(DateTime.Now.Minute);
            System.Console.WriteLine(DateTime.Now.Second);

            System.Console.WriteLine(DateTime.Now.DayOfWeek);
            System.Console.WriteLine(DateTime.Now.DayOfYear);

            System.Console.WriteLine(DateTime.Now.ToLongDateString);
            System.Console.WriteLine(DateTime.Now.ToShortDateString);
            System.Console.WriteLine(DateTime.Now.ToLongTimeString);
            System.Console.WriteLine(DateTime.Now.ToShortTimeString);

            System.Console.WriteLine(DateTime.Now.AddDays(2));
            System.Console.WriteLine(DateTime.Now.AddHours(3));
            System.Console.WriteLine(DateTime.Now.AddSeconds(30));
            System.Console.WriteLine(DateTime.Now.AddMonths(5));
            System.Console.WriteLine(DateTime.Now.AddYears(10));
            System.Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DATETİME FORMAT

            System.Console.WriteLine(DateTime.Now.ToString("dd"));
            System.Console.WriteLine(DateTime.Now.ToString("ddd"));
            System.Console.WriteLine(DateTime.Now.ToString("dddd"));

            System.Console.WriteLine(DateTime.Now.ToString("M"));
            System.Console.WriteLine(DateTime.Now.ToString("MM"));
            System.Console.WriteLine(DateTime.Now.ToString("MMM"));

            System.Console.WriteLine(DateTime.Now.ToString("yy"));
            System.Console.WriteLine(DateTime.Now.ToString("yyyy"));

            //MATH KÜTÜPHANESİ
            System.Console.WriteLine(Math.Abs(-25));
            System.Console.WriteLine(Math.Sin(30));
            System.Console.WriteLine(Math.Cos(60));
            System.Console.WriteLine(Math.Tan(90));

            System.Console.WriteLine(Math.Ceiling(22.3));//23 bir üste yuvarlar
            System.Console.WriteLine(Math.Floor(22.3));//22 bir alta yuvarlar
            System.Console.WriteLine(Math.Round(22.3));//5 den aşşası alta
            System.Console.WriteLine(Math.Round(22.5));// 5den yukarısı üste

            System.Console.WriteLine(Math.Max(2,6));//6
            System.Console.WriteLine(Math.Min(2,6));//2

            System.Console.WriteLine(Math.Pow(3,4));//3^4=81
            System.Console.WriteLine(Math.Sqrt(9));//3 kare kök alır
            System.Console.WriteLine(Math.Log(9));
            System.Console.WriteLine(Math.Exp(3));// e üssü
            System.Console.WriteLine(Math.Log10(10));//logaritma 10 tabında 10

        }
    }
}
