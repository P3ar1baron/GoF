using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var providerType = GetTypeOfLoggingProviderFromConfigFile();
            ILogger logger = LoggerProviderFactory.GetLoggingProvider(providerType);
            logger.LogMessage("Hello Factory Method Design Pattern");
        }

        static LoggingProviders GetTypeOfLoggingProviderFromConfigFile()
        {
            return LoggingProviders.Log4Net;
        }
    }
}
