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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://localhost:49626/Default.aspx");

        }

        [Test]
        public void Positiv()
        {
            DataInput.UsersData(driver, "Name", "Email", "Phone", "Да");
            Assert.AreEqual(driver.Url, "http://localhost:49626/seeyouthere.html");
        }

        [Test]
        public void Negative()
        {
            DataInput.UsersData(driver, "Name", "Email", "Phone", "Нет");
            Assert.AreEqual(driver.Url, "http://localhost:49626/sorryyoucantcome.html");
        }

        [TearDown]
        public void СloseBrowser()
        {
            driver.Close();
            driver.Quit();

        }
    }
}