using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class EnterpriseLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(string.Format("{0}: {1}", "EnterpriseLogger", message));
        }
    }
}
