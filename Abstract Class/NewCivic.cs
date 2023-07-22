namespace abstract_class
{
    public class NewCivic:Otomobil
    {

        //benim otomobil absturct ımdan kalıtım alacak bunu implemente ediyoruz(sarı ünlemden NewCivic'u)
        public override Marka HangiMarkanınAracı()
    {
        return Marka.Honda;
    }
    }
}
//*Önceki Civic classımızda tek tek değerlerini yazıp kod kalabalığına bürünmüştük 3 adet tekerlekdir,Markadır,Renktir 3 fonksiyon yazmıştık burada ise 2 adetle kurtulduk renk farklı olduğu için override kullandık