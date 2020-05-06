using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebApplication1.LocallhostInvationPage;

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
        }
        
        [Test]
        public void PositiveAnswerPage()
        {
            LocallhostLoginPage locallhostLoginPage = new LocallhostLoginPage(driver);
            locallhostLoginPage.openResponsePage("Name", "Email", "Phone", "Да");
            Assert.AreEqual(driver.Url, "http://localhost:49626/seeyouthere.html");
        }

        [Test]
        public void NegativeAnswerPage()
        {
            LocallhostLoginPage locallhostLoginPage = new LocallhostLoginPage(driver);
            locallhostLoginPage.openResponsePage("Name", "Email", "Phone", "Нет");
            Assert.AreEqual(driver.Url, "http://localhost:49626/sorryyoucantcome.html");
        }
       
        [Test]
        public void PresenceNameError()
        {
            LocallhostLoginPage locallhostLoginPage = new LocallhostLoginPage(driver);
            locallhostLoginPage.openResponsePage(String.Empty, "Email", "Phone", "Нет");
            Assert.AreEqual(locallhostLoginPage.findError().Text, "Требуется поле Name.");

        }

        [Test]
        public void PresenceEmailError()
        {
            LocallhostLoginPage locallhostLoginPage = new LocallhostLoginPage(driver);
            locallhostLoginPage.openResponsePage("Name", String.Empty, "Phone", "Нет");
            Assert.AreEqual(locallhostLoginPage.findError().Text, "Требуется поле Email.");
        }

        [Test]
        public void PresencePhoneError()
        {
            LocallhostLoginPage locallhostLoginPage = new LocallhostLoginPage(driver);
            locallhostLoginPage.openResponsePage("Name", "Email", String.Empty, "Нет");
            Assert.AreEqual(locallhostLoginPage.findError().Text, "Требуется поле Phone.");
        }

        [Test]
        public void PresenceWillattendError()
        {
            LocallhostLoginPage locallhostLoginPage = new LocallhostLoginPage(driver);
            locallhostLoginPage.openResponsePage("Name", "Email", "Phone", "Выберите один из вариантов");
            Assert.AreEqual(locallhostLoginPage.findError().Text, "Пожалуйста укажите, придете ли вы"); 
        }

        [Test]
        [TestCase("Name", "Email", "Phone")]
        public void ComparingTablesWithSourceData_ConsensusTable(string name, string email, string phone)
        {
            LocallhostLoginPage locallhostLoginPage = new LocallhostLoginPage(driver);
            locallhostLoginPage.openResponsePage(name, email, phone, "Да");
            InformationPage informationPage = new InformationPage(driver);
            Assert.IsTrue(informationPage.complianceСheckConsensusTable(name, email, phone));
        }

        [Test]
        [TestCase("Name", "Email", "Phone")]
        public void ComparingTablesWithSourceData_RefusedTable(string name, string email, string phone)
        {
            LocallhostLoginPage locallhostLoginPage = new LocallhostLoginPage(driver);
            locallhostLoginPage.openResponsePage(name, email, phone, "Нет");
            InformationPage informationPage = new InformationPage(driver);
            Assert.IsTrue(informationPage.complianceСheckRefusedTable(name, email, phone));
        }

        [TearDown]
        public void СloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}