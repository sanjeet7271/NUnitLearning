using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPractice
{
    [TestFixture]
    class RegistrationPage
    {
        //execute test case with different sets of data
        [Test,TestCaseSource("RegisterData")]
        public void TestRegister(string username, string password, string email, string city)
        {
            Console.WriteLine(username+"--->"+password+"--->"+email+"--->"+city);
        }
        public static object[] RegisterData()
        {
            object[][] data = new object[3][];

            //1st row
            data[0] = new object[4];
            data[0][0] = "user1";
            data[0][1]= "pass1";
            data[0][2] = "email1";
            data[0][3] = "city1";

            //second row
            data[1] = new object[4];
            data[1][0] = "user2";
            data[1][1] = "pass2";
            data[1][2] = "email1";
            data[1][3] = "city2";


            //third row
            data[2] = new object[4];
            data[2][0] = "user3";
            data[2][1] = "pass3";
            data[2][2] = "email3";
            data[2][3] = "city3";

            return data;
        }
    }
}
