using System;
using System.Collections.Generic;
namespace Polymorphism_ve_Sealed_Class

{
    //Bitkilere canlılar sınıfından kalıtım aldırdık
    public class Bitkiler:Canlilar //Genel bitki özelliği klasımız
    {
        protected void FotoSentez()//genel bitki özelleğimiz
        {
            System.Console.WriteLine("Bitkiler FotoSentez Yapar.");
        }
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            System.Console.WriteLine("Bitkiler Güneşe Tepki verirler");//SADECE BU KISIMI YAZDIRICAK
        }
    }
    public class TohumluBitkiler:Bitkiler//Tohumlu bitkilere özel özellik clasımız
    {   
        public TohumluBitkiler(){
            base.FotoSentez();//Burada hayatımıza bir yeni kavram daha giriyor base kalıtım türünden classlarımıza bizi eriştiriyor.
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma()
        {
            System.Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır.");
        }
    }
    public class TohumsuzBitkiler:Bitkiler//Tohumsuz bitkilere özel özellik clasımız
    {   
        public TohumsuzBitkiler(){
            base.FotoSentez();//Burada hayatımıza bir yeni kavram daha giriyor base kalıtım türünden classlarımıza bizi eriştiriyor.
            base.Beslenme();
            base.Boşaltım();
            base.Solunum(); 
        }
        public void SporlaCogalma()
        {
            System.Console.WriteLine("Tohumsuz Bitkiler Tohumla Çoğalır.");
        }
    }
}