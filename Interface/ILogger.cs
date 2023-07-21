using System;

namespace arayuzler
{
    public interface ILogger//interfaceler interface anahtar kelimesi ile gelir
    {
        //log yazan sınıflar için yapıyoruz.Bir metota ihtiyaç varsa muhtemel writeLogdur
        void writeLog();
    }
}