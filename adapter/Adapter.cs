using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStructural
{
    // The Target defines the domain-specific interface used by the client code.
    public interface ILogger
    {
        void Log(string message);
    }
    //Existing Logger - Adaptee
    public class BaseLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Base system log: " + message);
        }
    }
    // New modern logger - Adaptee
    public class AdvanceLogger
    {
        public void LogInfo(string type, string message)
        {
            Console.WriteLine("Advance system log: " + message + " with serverity " + type);
        }
    }
    // Logger Adapter - Adapter
    public class LoggerAdapter : ILogger
    {
        private readonly AdvanceLogger _advanceLogger;
        public LoggerAdapter(AdvanceLogger advanceLogger)
        {
            _advanceLogger = advanceLogger;
        }

        public void Log(string message)
        {
            _advanceLogger.LogInfo("WARNING", message);
        }
    }
}