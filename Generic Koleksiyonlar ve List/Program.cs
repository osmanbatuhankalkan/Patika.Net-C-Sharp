using System;
using System.Collections.Generic;
namespace Generic_Koleksiyonlar_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türünden

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count listeler içerisinde kaç tane eleman var onu söyler (liste içi eleman sayısını verir)
            System.Console.WriteLine(renkListesi.Count);
            System.Console.WriteLine(sayiListesi.Count);

            System.Console.WriteLine("*************************");

            foreach (var renk in renkListesi)
            {
                System.Console.WriteLine(renk);
            }
            foreach (var sayi in sayiListesi)
            {
                System.Console.WriteLine(sayi);
            }

            System.Console.WriteLine("*************************");
            //Foreach in bir başka kullanımıda şöyledir;
            renkListesi.ForEach(renk=> System.Console.WriteLine(renk));
            sayiListesi.ForEach(sayi=> System.Console.WriteLine(sayi));
            //okuna bilirliği yüksek ve hoş
            System.Console.WriteLine("##############################");
            //Listeden Eleman Çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            renkListesi.ForEach(renk=> System.Console.WriteLine(renk));
            sayiListesi.ForEach(sayi=> System.Console.WriteLine(sayi));
            System.Console.WriteLine("##############################");
            //İndex Olarak Çıkarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);
            renkListesi.ForEach(renk=> System.Console.WriteLine(renk));
            sayiListesi.ForEach(sayi=> System.Console.WriteLine(sayi));

            //Contains Liste içinde Arama yapar
            if(sayiListesi.Contains(10))
            {
                System.Console.WriteLine("10 Liste içerisinde bulundu");
            }
            //Eleman ile indexe erişme
            System.Console.WriteLine(renkListesi.BinarySearch("Mavi"));

            //Elimizdeki diziyi List'e çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi =new List<string>(hayvanlar);

            //Listeyi Nasıl Temizleriz ?
            hayvanListesi.Clear();

            //Liste içerisinde nesen tutmak************* Günlük hayatta çok kullanılır.
            //öne classların elemanlarını tutacak listeyi oluşturacağız
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            //buna eleman atamak için kullanılar nesenelere ihtiyacımız var 
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.İsim = "Ayse";
            kullanıcı1.Soyisim ="Bolukbasi";
            kullanıcı1.Yas = 23;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.İsim = "Osman Batuhan";
            kullanıcı2.Soyisim ="Kalkan";
            kullanıcı2.Yas = 22;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            //Bu Listeye yeni bir kullanıcı atama işlemi başka türlün nasıl yapılabilir?
            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                İsim = "OBK",
                Soyisim ="AB",
                Yas = 24
            });
            //Bu kullanıcılar sınıfının elemanlarına nasıl erişicem ? Foreach ile
            foreach (var kullanıcı in kullanıcıListesi)
            {
                System.Console.WriteLine("Kullanıcı Adı:" + kullanıcı.İsim);
                System.Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Soyisim);
                System.Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Yas);
            }
            foreach (var yenikullanıcı in yeniListe)
            {
                 System.Console.WriteLine("Kullanıcı Adı:" + yenikullanıcı.İsim);
                System.Console.WriteLine("Kullanıcı Adı:" + yenikullanıcı.Soyisim);
                System.Console.WriteLine("Kullanıcı Adı:" + yenikullanıcı.Yas);
            }

        }
    }
    //class oluşturalım ilerde daha detaylı değinilecek
    public class Kullanıcılar{
        private string isim;

        private string soyisim;
        private int yas;

        //kendi elemanlarını koruyup en kapsüle etmiş oluyor
        public string İsim {get => isim;set=>isim=value;}
        public string Soyisim {get => soyisim;set=>soyisim=value;}
        public int Yas {get =>yas;set=>yas=value;}
    }
}