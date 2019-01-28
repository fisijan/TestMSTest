using log4net;
using System.Threading;

namespace Logger
{
    public static class Log
    {
        public static ThreadLocal<ILog> _log;
        public static ILog Getlog()
        {
            return log4net.LogManager.GetLogger();
        }
    }
}
