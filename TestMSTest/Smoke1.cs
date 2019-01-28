using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger = TestMSTest.Helpers.LogHelper;
using log4net;

namespace TestMSTest
{
    [TestClass]
    public class Smoke1 : TestBase
    {
        [TestMethod]
        public void TestCase1()
        {
            Logger.Info("Info logging");
            Logger.Error("Error logging");
            System.Threading.Thread.Sleep(2000);
            
        }

        [TestMethod]
        public void TestCase2()
        {
            Logger.Info("Info logging2");
            Logger.Error("Error logging2");
            Logger.Debug("Debug logging2");
            System.Threading.Thread.Sleep(3000);

        }

    }
}
