namespace abstract_class
{
    public class Focus : IOtomobil //Kalıtım için public class Focus : IOtomobil bu kısmı yazdıktan sonra IOtomobilin üstünden uyarlar dersek aşşağıda bize otomatik olarak uyarlanmıs halini vermekte tek tek uğraşma zaman kaybetmeyiz
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Ford;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}