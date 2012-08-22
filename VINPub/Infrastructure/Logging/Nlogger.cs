using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;

namespace VINPub.Infrastructure.Logging
{
    public class Nlogger : VINPub.Infrastructure.Logging.INlogger
    {
        Logger _logger;

        public Nlogger()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public void LogInfo(string message)
        {
            _logger.Info(message);
        }

        public void LogWarning(string message)
        {
            _logger.Warn(message);
        }

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogError(string message)
        {
            _logger.Error(message);
        }

        public void LogFatal(string message)
        {
            _logger.Debug(message);
        }
    }
}