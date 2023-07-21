using System;
namespace arayuzler_ornek
//3 adet otomobil classı yaratıcaz
//markasını,rengini,ve kaç tekerden oluştuğun bize veren 
//3 tane metot oluşturacağız bu metotların olacağını hayal ediyoruz bunları bir interfacede birleştirip bunlardan kalıtım alacağız
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
        }
    }
}