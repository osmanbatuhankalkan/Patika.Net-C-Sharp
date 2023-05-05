//metodlar aslında fonksiyonlardır, bu OOP ile birlikte metod adını almıştır, bir programı parçalamak için kullanıyoruz, neden buna ihtiyaç var küçük parçalara ayırarak yazmak daha okunur bir kod , tekrara düşmeme gibi avantajlar sağlıyor.
//geriye dönük bir değişiklikte bir sürü bağlamı değiştirmek yerine, ortak bir yapıyı değiştirerek bunu her yerde kullanabilirim.
//değişiklik yapacağımız yeri bulmak kolaylaşacak zorlaştırmayacak hangi kod bloğu ne işi yapıyor bilirsek çok hızlı reaksiyon gösterebiliriz.
//tek başlarına yazılabilen yapılar değildir bir CLASS içinde olmaları gerekir.
using System;

namespace Metot_tanımlama
{
    class program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci(public,private), geri_dönüstürücütipi(çağrıldığı yerden geri ihtiyaç duyucak mı geri dönüşü olmayan metotlarda olabilir zorunlu değil void döndürürüz.), metot_adi(parametreListesi/arguman,isimlendirme önemli ne iş yaptığını koyabiliriz mesela)
            //{
                ///Komutlar;
                //return;
            //}

            int a=2;
            int b=3;

            Console.WriteLine(a+b);
            //Bunu metod olarak şöyle yapabilirdik

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            metot ornek = new metot(); //bulunduğumuz class değilde başka class içinden erişmek istiyorsak o classın bir instance yaratırız (Bir class'tan türetilen nesne). new burada anahtar kelime
            ornek.EkranaYazdır(Convert.ToString(sonuc)); //bu örnekle ekrana yazdıra erişiyoruz,sonucumuzu string beklerken biz int değer verdiğimiz için  conver.tostring kullanarak str -> int e çeviriyoruz

            int sonuc2 = ornek.ArttırVeTopla(a,b);
            int sonuc3 = ornek.ArttırVeTopla2(ref a,ref b);//Peki bu referans verme nedir ? bir fonksa a ve b değeri yerine bellekteki değer karşılığının verilmesi. Gidip referanslar üzerinde işlem yapıyor orjinale dokunmuyor
            ornek.EkranaYazdır(Convert.ToString(sonuc3));//Peki bu referans verme nedir ? bir fonksa a ve b değeri yerine bellekteki değer karşılığının verilmesi. Gidip referanslar üzerinde işlem yapıyor orjinale dokunmuyor.
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a+b));
        }
        static int Topla(int deger1, int deger2)
        {
            //bellek burada nasıl davranıyor ? fonksiyon başlarken parametreler yaratılılır yukarıdaki a ve b değerini alıyor getiriyoruz ve yeni yaratılan deger1 ve deger2 nin yerine yazıyor kendi fonksiyon içinde işlemler yaparken oradan akıyor bilgi buraya bu deger1 ve deger2 fonksiyonla beraber yaşamaya başlar görevini tamamladıktan sonra yaşamı sona erer bellekten silinir. 
            
                       return(deger1+deger2);
            //burada yukarda yazdırmak istesek yazdıramaycağız çünkü yukardaki class static bir class, o yüzden int toplanın başına static ekleyeceğiz
        }
    }
    class metot{
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
            //bu veri geri dönmeyeceği için EkranaYazdır(string veri) 'nin başına "void" ekledik.
        }
        //Metotlar içinde bir fonksiyon daha yaratalım
        public int ArttırVeTopla(int deger1 , int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1 + deger2;
        }
        //REFERANS VERME
        //Peki bu referans verme nedir ? bir fonksa a ve b değeri yerine bellekteki değer karşılığının verilmesi. Gidip referanslar üzerinde işlem yapıyor orjinale dokunmuyor
        public int ArttırVeTopla2(ref int deger1 , ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1 + deger2;
        }

    }
}