using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPractice
{
    //skip test case at class level
    [TestFixture]
    [Parallelizable]
    [Ignore("skip the test")]
    class YahooTest
    {
        [Test]
        public void TestRecieveEmails()
        {
            Console.WriteLine("Testing retrieve emails");
        }
        [Test]
        public void TestSendEmails()
        {
            Console.WriteLine("Testing send emails");
        }
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Opening Browsers");
        }
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Closing Browsers");
        }
    }
}
