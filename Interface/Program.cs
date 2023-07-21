using System;
using System.Collections.Generic;

namespace arayuzler
//*Interface, günlük hayattada çok kullanacağımız, örneklerle ve tekrarlarda anlaşılacak olan bir konudur. Şimdi bu konuya giriş yapacağız.
//Sınıfların içermesi gereken metotların imzalarının yer aldıpı özelliklerin tanımladındığı taslaklardır. genel olarak I harfi ile başlarlar genelde I ile başlayan görürsek interface oldupunu anlayabiliriz yazılım dünyaasında bizden sonrakilerinde anlamasını kolaylaştırmak için yazılı olamayan bir kural olarak düşünülebilir.
//interface içerisindeki propertylere bir değer ataması yapılmaz,bir metotun gövdeside yazılmaz, ilk değer atamasıda yapılmaz.
//interfacelere neden ihtiyac var inetfaceden kalıtım alınana sınıfın sorumlulupunun yanı çervesinin çizilmesine yardımcı olur.
//sadece interfaace bakarak n kadar sınıfın ne iş yaptığını anlamamızda bize yol gösterir okunumu kolaylaştırır. Gerçek hayatta çok kullanacağımız için iyi ögrenilmeli
//*Loglama yapan bir interface örneği yapacağız bizde bir ana sınıf yaratılacak interface
//*ondan türeyeen aynı işi farklı şekillerde yapan birden fazla sınıfna implamente edicez
{
    class Program
    {
        static void Main(string[] args)
        {
          //FileLogger aslında bir class onun bir tane ınstance oluşturuyoruz.
          FileLogger fileLogger=new FileLogger();
          fileLogger.writeLog();
          
          DatabaseLogger databaseLogger = new DatabaseLogger();
          databaseLogger.writeLog();

          SmsLogger smsLogger = new SmsLogger();
          smsLogger.writeLog();
          
          //Loglarımızı çağırdık geldi işimdi bu işi bir adım öteye götürelim
          //*Hangi log sınıfının yazılacağını, hangi log sınıfın yaratılacağını,hangi log sınıfının çağıralacağını belirleyen bir tane log manager yazalım.

          LogManager logManager = new LogManager(new FileLogger());
          logManager.writeLog();
          //yukarıda tek tek yaratmak yerine teke düşürdük ve bunu kodun her yerinden çağırabiliriz

        }
    }
}