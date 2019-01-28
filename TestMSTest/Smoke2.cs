using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger = TestMSTest.Helpers.LogHelper;

namespace TestMSTest
{
    [TestClass]
    public class Smoke2: TestBase
    {
        [TestMethod]
        public void TestCase3()
        {
            Logger.Info("Info logging3");
            Logger.Error("Error logging3");
            Logger.Debug("Debug logging3");

            System.Threading.Thread.Sleep(5000);

        }
    }
}
