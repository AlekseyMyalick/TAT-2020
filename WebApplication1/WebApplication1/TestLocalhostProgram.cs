using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace WebApplication1
{
    public class TestLocalhostProgram
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpeningSearchEngine()
        {


            driver.Navigate().GoToUrl("http://localhost:49626/Default.aspx");
            //driver.Url = "http://localhost:49626/Default.aspx";
        }

        [Test]
        public void DataInput()
        {
            System.Threading.Thread.Sleep(5000);
            var weit = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            weit.Until(ExpectedConditions.ElementExists(By.XPath("//input[@id ='name']")));
            //elementName.SendKeys("User");

            //IWebElement elementName = driver.FindElement(By.Id("name"));
            //elementName.SendKeys("User");

            //IWebElement elementEmail = driver.FindElement(By.Id("email"));
            //elementEmail.SendKeys("user@yandex.ru");

            //IWebElement elementPhone = driver.FindElement(By.Id("phone"));
            //elementPhone.SendKeys("+375293332210");

            //IWebElement elementWillattend = driver.FindElement(By.Id("willattend"));
            //elementWillattend.Click();
        } 

        //[TearDown]
        //public void closeBrowser()
        //{
        //    driver.Close();
        //}
    }
}