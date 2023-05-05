using System;

namespace hata_yönetimi
{
    class Program
    {
        static void Main(string[]args)
        {
            try{ ///hataya sebebiyet verme ihtmali yüksek olan kısmımız
                 Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
            }
            catch(Exception ex){  ///exception hatayı yakala demek, catch hata ile karşılaşılınca çalışan kısmımız
                Console.WriteLine("Hata: "+ ex.Message.ToString());
            }
            finally ///hata olsun olmasın çalışan kısmımız, mutlaka olsu dediğimiz şeyleri bu kısma yazarız
            {
                Console.Write("İşlem Tamamlandı !!");
            }
            ///küçük hatırlatma: Pars string ifadeleri int değerlere dönüştürmek için kullanılır
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a =  int.Parse("-20000000000");
                
            }
            catch (ArgumentNullException ex)///yazdığımız kodun doğru çalışıp çalışmadığını görmekte bizim için çok önemli
            ///Daha komplike iç içe geçmiş kodlarda hataları bulmak daha da zorlasacak
            {
                Console.WriteLine("Boş Değer Girdiniz");
                Console.WriteLine(ex);
                
            }
            
            catch(FormatException ex)
            {
                Console.WriteLine("Veri Tipi uygun değil");
                Console.WriteLine(ex);
            }

            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük sayı girdiniz");
                Console.WriteLine(ex);
            }

        }   
           
    }
}