using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[]args)
        {
            ///saate göre selamlama yapalım
            int time = DateTime.Now.Hour;//şuanki saaat

            if(time>=6 && time < 11)
                Console.WriteLine("Günaydın ! ");
            else if(time <=18)
                Console.WriteLine("İyi Günler! ");
            else
                Console.WriteLine("İyi Geceler !");
            ///Biz bunu farklı bir gösterimlede gösterebiliriz

            string sonuc = time<=18 ? "İyi Günler!" : "İyi Geceler!";

            sonuc = time>=6 && time<11 ? "Günaydın" : time<=18 ? "İyi Günler!" :"İyi Geceler!";
            Console.WriteLine(sonuc);       

            
        }
    }
}