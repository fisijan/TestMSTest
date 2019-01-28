using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger=TestMSTest.Helpers.LogHelper;

namespace TestMSTest
{
    [TestClass]
    public class TestBase
    {
        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void BaseAssemblyInitialize(TestContext testContext)
        {

        }


        [TestInitialize]
        public void BaseTestInit()
        {
            Logger.testName.Value = TestContext.TestName;
            Logger.Info("Start "+Logger.testName.Value);
        }

    }
}
