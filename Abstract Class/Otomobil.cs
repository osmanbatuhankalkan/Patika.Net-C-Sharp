namespace abstract_class
{
    //ABSTRACT class oluşturduk. Bizim arabalarımız var civic corolla focus bunların benzer özellikleri var farklı özellikleri var ve benzer olan özellikleri her seferinde tek tek yazmak kod okunabilirliğini düşürüyor ve sonrasında gelecek olanlar için bize amelelik teşkil etmeye başlıyor
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;//bunu yazınca otomobil abstact klasından oluşan ve erişebilidiği tüm sınıflarda bu 4 değerine erişilecek.
            //*Yani bize corolla civic ve focus classlarına tek tek bunu yazmaktan kurtulduk
        }
        //burada şimdi elimizdeki verilere bakıyoruz 3 aracımız var ikisi aynı renk fakat 1 tane farklı renk hangi çözüm yöntemini seçmemiz doğru olur diye düşünüyoruz ve bize sanal metotun uygun olduğunu buluyoruz neden:default olarak tanımlayacağız ama başka yerlerdende ezilmesine ve farklı cevap dönmesine izin vericez işte bu yöntem SANAL METOT VİRTUAL
        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;//çoğunluk renk
        }
        //Üçüncü Verimiz hangi Markanın aracıydı. Bizde hepsi farklı ortak özellik yoktu Herbirinden dönmesi gerek bir metot lazım biz bunu abstruct olarak yazarsak
        //*alt sınıflarımızı bunu IMPLAMENTE etmeye ve gövdesini yazmaya zorlamış oluruz ve her biri farklı olduğu için en doğru seçenek budur.
        public abstract Marka HangiMarkanınAracı();
    }
}