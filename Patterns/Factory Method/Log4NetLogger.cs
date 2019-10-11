using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class Log4NetLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(string.Format("{0}: {1}","Log4Net",message));
        }
    }
}
