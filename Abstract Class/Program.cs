using System;
using System.Collections.Generic;
//*Abstract class'ları sadece kalıtım için kullanılan sınıflar gibi düşünebilirsiniz. Bazı özellikleri ile sınıflara benzerlerken bazı özellikleriyle arayüzlere benzerler. Abstract sınıfları arayüz ve virtual metotların birleşimi gibi davranış gösterirler.

namespace abstract_class

{
    class Program
    {
        static void Main(string[] args)
        {
          //Nesnelerimizi oluşturalım
            Focus focus = new Focus();
            System.Console.WriteLine(focus.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(focus.KacTekerlektenOlusur());
            System.Console.WriteLine(focus.StandartRengiNe().ToString());
            System.Console.WriteLine("*************************************");
            Civic civic = new Civic();
            System.Console.WriteLine(civic.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(civic.KacTekerlektenOlusur());
            System.Console.WriteLine(civic.StandartRengiNe().ToString());
            System.Console.WriteLine("*************************************");
            Corolla corolla = new Corolla();
            System.Console.WriteLine(corolla.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(corolla.KacTekerlektenOlusur());
            System.Console.WriteLine(corolla.StandartRengiNe().ToString());
            //*Kritik yapalım HangiMarkanınAracı görevini yapmıştır çünkü farklı farklı verilerimizi bize her birinde farklı olacak şekilde interfacein hakkını vererek getirmiştir.
            //*KacTekerlektenOlusur bize yardımcı oluyor fakat her değişkende aynı veriyi kullandığımız için kod kalabalığı Interfacein bize sağladığı avantaj değil düzeltiebilir
            //*StandatRengiNe 2 farklı şekilde kullanıldı buda düşünebilir ABSTRUCT da bir üst şekilde göreceğiz
             System.Console.WriteLine("########################################");
             System.Console.WriteLine("ŞİMDİ ABSTRUCT KULLANIMINI GÖRECEĞİZ");
             
             NewFocus focus1 = new NewFocus();
            System.Console.WriteLine(focus1.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(focus1.KacTekerlektenOlusur());
            System.Console.WriteLine(focus1.StandartRengiNe().ToString());
            System.Console.WriteLine("########################################");

            NewCivic civic1 = new NewCivic();
            System.Console.WriteLine(civic1.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(civic1.KacTekerlektenOlusur());
            System.Console.WriteLine(civic1.StandartRengiNe().ToString());
            System.Console.WriteLine("########################################");

            NewCorolla corolla1 = new NewCorolla();
            System.Console.WriteLine(corolla1.HangiMarkanınAracı().ToString());
            System.Console.WriteLine(corolla1.KacTekerlektenOlusur());
            System.Console.WriteLine(corolla1.StandartRengiNe().ToString());
            //*Değişime kapalı gelişime açık kod yazdık önemli olan bu. Kontrol ve kod yöneyimi önemli hataya kapalı kod yazmak


        }
    }
}

//Kısaca abstract sınıfların özelliklerine bakacak olursak:
/* 
Normal sınıflar gibi new() anahtar kelimesi ile türetilemezler.
Interface ler gibi metot bildirimi yapabilirsiniz.
Sanal metotları override eder gibi abstract metotlar override edilebilir.
Abstract metotların gövdesi yazılamaz.
Bir abstract class bir abstract metot içeriyorsa, abstract sınıftan türeyen tüm sınıflar bu metodu override etmek zorundadır.
Bir sınıf sadece tek abstract sınıftan kalıtım alabilir.
Abstract sınıf başka bir abstract sınıftan kalıtım alabilir. Dolaylı olacak türeyen sınıfta birden fazla abstract dan kalıtım almış olur. Ve bağlantılı olduğu tüm abstract sınıfların bildirimi yapılmış olan abstract metotlarını override etmek zorundadır.


ÖNEMLI: Abstract sınıf içerisinde metot bildirimi yapabilmek için metodun erişim belirtecinden sonra "abstract" anahtar kelimesi mutlaka yazılmalıdır.



ÖNEMLI: Abstract metotdan türetilmiş sınıf içerisinde abstract metodun kullanılabilmesi için de override anahtar kelimesinin kullanılması gerekir.
*/