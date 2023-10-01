using NLog;
using SocialMediaAnalyis.Repository.Contracts;

namespace SocialMediaAnalyis.LoggerService
{

    public partial class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public LoggerManager()
        {
        }

        public void LogDebug(string message) => logger.Debug(message);

        public void LogError(string message) => logger.Debug(message);

        public void LogInfo(string message) => logger.Debug(message);

        public void LogWarn(string message) => logger.Debug(message);
    }
}