using System;

namespace arayuzler
{
    public class FileLogger: ILogger
    {
        public void writeLog()
        {
            //throw new NotImplementedException();
            System.Console.WriteLine("FileLogeer'a yazar");
        }

        internal void WriteLog()
        {
            throw new NotImplementedException();
        }
    }
}