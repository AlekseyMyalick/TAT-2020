using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

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
        public void PositiveAnswerPage()
        {
            DataInput.UsersData(driver, "Name", "Email", "Phone", "Да");
            Assert.AreEqual(driver.Url, "http://localhost:49626/seeyouthere.html");
        }

        [Test]
        public void NegativeAnswerPage()
        {
            DataInput.UsersData(driver, "Name", "Email", "Phone", "Нет");
            Assert.AreEqual(driver.Url, "http://localhost:49626/sorryyoucantcome.html");
        }

        [Test]
        public void PresenceNameError()
        {
            DataInput.UsersData(driver, String.Empty , "Email", "Phone", "Нет");
            IWebElement nameError = driver.FindElement(By
                .XPath("//div[@id='validationSummary']/ul/li"));
            Assert.AreEqual(nameError.Text, "Требуется поле Name.");

        }

        [Test]
        public void PresenceEmailError()
        {
            DataInput.UsersData(driver, "Name", String.Empty, "Phone", "Нет");
            IWebElement nameError = driver.FindElement(By
                .XPath("//div[@id='validationSummary']/ul/li"));
            Assert.AreEqual(nameError.Text, "Требуется поле Email.");
        }

        [Test]
        public void PresencePhoneError()
        {
            DataInput.UsersData(driver, "Name", "Email", String.Empty, "Нет");
            IWebElement nameError = driver.FindElement(By
                .XPath("//div[@id='validationSummary']/ul/li"));
            Assert.AreEqual(nameError.Text, "Требуется поле Phone.");
        }

        [Test]
        public void PresenceWillattendError()
        {
            DataInput.UsersData(driver, "Name", "Email", "Phone", "Выберите один из вариантов");
            IWebElement nameError = driver.FindElement(By
                .XPath("//div[@id='validationSummary']/ul/li"));
            Assert.AreEqual(nameError.Text, "Пожалуйста укажите, придете ли вы"); 
        }

        [TearDown]
        public void СloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}