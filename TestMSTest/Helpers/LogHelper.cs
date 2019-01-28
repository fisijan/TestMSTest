using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;

namespace TestMSTest.Helpers
{
    public static class LogHelper
    {
        public static ThreadLocal<string> testName = new ThreadLocal<string>();

        private static ILog TestLog()
        {
            return log4net.LogManager.GetLogger(testName.Value);
        }

        public static void Info(string s)
        {
            TestLog().Info(s);
        }

        public static void Error(string s)
        {
            TestLog().Error(s);
        }

        public static void Warn(string s)
        {
            TestLog().Warn(s);
        }

        public static void Debug(string s)
        {
            TestLog().Debug(s);
        }

    }
}
