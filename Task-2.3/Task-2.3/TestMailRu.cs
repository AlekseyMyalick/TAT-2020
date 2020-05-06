using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Task_2._3.ProtonMail;

namespace Task_2._3
{
    class TestMailRu
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void OpeningSearchEngine()
        {
            MailRuLoginPage mailLoginPage = new MailRuLoginPage(driver);
            mailLoginPage.openAuthorizationPage();
            mailLoginPage.enterLogin("firstmantest@mail.ru");
            mailLoginPage.enterPassword("12345First");
        }

        [Test]
        public void SendMassage()
        {
            MailRuHomePage homePage = new MailRuHomePage(driver);
            homePage.openHomePage("firstmantest@mail.ru", "12345First");
            MailRuWriteLetterPage writeLetterPage = new MailRuWriteLetterPage(driver);
            writeLetterPage.sendMassage("man7est@yandex.by");
        }

        //[Test]
        //public void Logout()
        //{
        //    MailRuHomePage homePage = new MailRuHomePage(driver);
        //    homePage.openHomePage("firstmantest@mail.ru", "12345First");
        //    homePage.logOut();
        //}

        [Test]
        public void OpenYandexMailHomePage()
        {
            YandexMailHomePage ProtonHomePage = new YandexMailHomePage(driver);
            ProtonHomePage.openHomePage("man7est@yandex.by", "12345Second");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}