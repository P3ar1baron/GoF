using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class LoggerSingleton
    {
        private LoggerSingleton()
        {

        }
        int _logCount = 0;
        static LoggerSingleton _loggerSingletonInstance = new LoggerSingleton();
        public static LoggerSingleton GetInstance()
        {
            if (_loggerSingletonInstance == null)
            {
                _loggerSingletonInstance = new LoggerSingleton();
            }
            return _loggerSingletonInstance;
        }
        public void Log(string message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    }
}
