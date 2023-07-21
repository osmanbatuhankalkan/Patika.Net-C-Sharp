namespace arayuzler_ornek
{
    /*
    public interface IOtomobil{
        int KacTekerlektenOlusur();
        string HangiMarkanınAracı();
        string StandartRengiNe();
        //*Bunlar bizim değişmezlerimiz, belli marka renk teker yenilerinin gelmesi çok zordur sabit bilgidir sürekli değişmez ozaman biz bunları ENUM'larda tutacağız.Ve okunabiliriliğimizde attıracağız Sabitler Case ine gidip yaptığımız değişiklikleri görebilirsiniz
    } */

    /* Sabitler Case ndeki değelerimizi olusturduktan sonra burada şöyle değişikliler olucak fark edelim diye üstte ilk basta yazdıklarımızı değiştirmiyorum
    */
    public interface IOtomobil{
        int KacTekerlektenOlusur();
        Marka HangiMarkanınAracı();
        Renk StandartRengiNe();
        //Bunlar bizim değişmezlerimiz, belli marka renk teker yenilerinin gelmesi çok zordur sabit bilgidir sürekli değişmez ozaman biz bunları ENUM'larda tutacağız.Ve okunabiliriliğimizde attıracağız Sabitler Case ine gidip yaptığımız değişiklikleri görebilirsiniz
    }
}