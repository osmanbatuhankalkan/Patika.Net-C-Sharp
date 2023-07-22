namespace abstract_class
{
    public class NewFocus:Otomobil
    {
    //benim otomobil absturct ımdan kalıtım alacak bunu implemente ediyoruz(sarı ünlemden NewFocus'u)
    public override Marka HangiMarkanınAracı()
    {
        return Marka.Ford;
    }
    }
}
//*Önceki Focus classımızda tek tek değerlerini yazıp kod kalabalığına bürünmüştük 3 adet tekerlekdir,Markadır,Renktir 3 fonksiyon yazmıştık burada ise teke düşürdük New de