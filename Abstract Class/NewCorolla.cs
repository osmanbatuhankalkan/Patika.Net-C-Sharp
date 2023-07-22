namespace abstract_class
{
    public class NewCorolla:Otomobil
    {
    //benim otomobil absturct ımdan kalıtım alacak bunu implemente ediyoruz(sarı ünlemden NewCorolla'u)
    public override Marka HangiMarkanınAracı()
    {
        return Marka.Toyota;
    }
    //*STANDART rengi bu markanın farklı olduğu için override ediceğiz
    public override Renk StandartRengiNe()
    {
        return Renk.Gri;
    }
    }
}
//*Önceki Corolla classımızda tek tek değerlerini yazıp kod kalabalığına bürünmüştük 3 adet tekerlekdir,Markadır,Renktir 3 fonksiyon yazmıştık burada ise teke düşürdük New de