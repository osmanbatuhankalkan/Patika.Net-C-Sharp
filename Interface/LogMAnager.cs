using System;

namespace arayuzler
{
    public class LogManager:ILogger//MAnagerı ILoggerdan kalıtım aldırıpı implamante edyrz
    {
        public ILogger _logger;//bir direk interfaceın ınstance yarattık
        public LogManager(ILogger logger)//interfaceın referansını yaratmışız gibi düşün
        //LogManagerın Constructor'ını dışarıdan file,sms,databaseloggerin instancelerini verebiliriz  ve bu da bize güç kazandırıyor görebiliriz.
        {
            _logger = logger;
        }

        public void writeLog()
        {
            _logger.writeLog();
        }
    }
}