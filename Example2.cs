using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPractice
{
    [TestFixture]
    [Parallelizable]
    class Example2
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
    }
}
