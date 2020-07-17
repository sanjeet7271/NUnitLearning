using OpenQA.Selenium;


namespace NUnitPractice
{
    class TestBase
    {
        public static void TakeScreenShot(string filename, IWebDriver driver)
        {
            ITakesScreenshot shots = driver as ITakesScreenshot;
            Screenshot screen = shots.GetScreenshot();
            screen.SaveAsFile("D:\\Reports"+filename+".jpeg");
        }
    }
}
