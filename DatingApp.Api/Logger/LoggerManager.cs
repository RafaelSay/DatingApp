using NLog;

namespace DatingApp.API.Logger
{
    public class LoggerManager : ILoggerManager
    {

        private static ILogger logger = LogManager.GetCurrentClassLogger();
        
        public void LogInfo(string message)
        {
            throw new System.NotImplementedException();
        }

        public void LogWarn(string message)
        {
            throw new System.NotImplementedException();
        }

        public void LogDebug(string message)
        {
            throw new System.NotImplementedException();
        }

        public void LogError(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}