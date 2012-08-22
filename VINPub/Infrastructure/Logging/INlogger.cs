using System;
namespace VINPub.Infrastructure.Logging
{
   public interface INlogger
    {
        void LogDebug(string message);
        void LogError(string message);
        void LogFatal(string message);
        void LogInfo(string message);
        void LogWarning(string message);
    }
}
