using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class ThreadSafeLoggerSingleton
    {
        private ThreadSafeLoggerSingleton()
        {

        }
        int _logCount = 0;
        static ThreadSafeLoggerSingleton _loggerInstance;
        static readonly object locker = new object();

        static ThreadSafeLoggerSingleton GetInstance()
        {
            lock(locker)
            {
                if (_loggerInstance == null)
                {
                    _loggerInstance = new ThreadSafeLoggerSingleton();
                }
            }
            return _loggerInstance;
        }

        public void Log(string message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    }
}
