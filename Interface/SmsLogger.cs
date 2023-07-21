using System;

namespace arayuzler
{
    public class SmsLogger:ILogger//Kalıtım uyguladık
    {
        public void writeLog()
        {
            //Gövde boş bırakılabilir throw new NotImplementedException();//Yukarıdaki SmsLogger:ILogger'ı implamente ettik
            System.Console.WriteLine("Sms olarak log yazar");
        }
    }
}