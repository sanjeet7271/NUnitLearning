using NUnit.Framework;
using System;

namespace NUnitPractice
{
    [TestFixture]
    [Parallelizable]
    public class BUnitExample
    {
        [Test]
        public void TestApp()
        {
            //Assert.Pass("test case pass");
            Console.WriteLine("test case pass");
        }
        [Test]
        public void TestApp1()
        {
            //Assert.Pass("test case pass");
            const string Message = "pass";
            Assert.Pass(Message);
        }
        [Test]
        public void TestLogin()
        {
            Assert.Ignore("Skip Test Case");
            Console.WriteLine("login test");
        }

        [Test]
        public void AssertionTestPass()
        {
            Assert.AreEqual("Good", "Good");
        }
        [Test]
        public void AssertionTestFail()
        {
            Assert.AreEqual("Good", "good");
        }
        [Test]
        public void AssertionTestBooleanPass()
        {
            Assert.IsTrue(4>2, "Error Mssge");
        }
        [Test]
        public void AssertionTestBooleanFailed()
        {
            Assert.IsFalse(4 > 5, "Error Mssge");
        }
    }
}
