using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task_2._3
{
    class FirstMail
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpeningSearchEngine()
        {
            driver.Url = "http://www.google.co.in";
        }

        [Test]
        public void 

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}