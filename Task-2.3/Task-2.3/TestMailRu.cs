using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Task_2._3.MailRu;
using Task_2._3.YandexMail;

namespace Task_2._3
{
    class TestMailRu
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void YandexMailComparisonOfTheSentWithTheReceivedLetter()
        {
            YandexMailInboxPage yandexMailInboxPage = new YandexMailInboxPage(driver);
            yandexMailInboxPage.openInboxPage("man7est@yandex.by", "12345Second");
            yandexMailInboxPage.openLetter();
            Assert.IsTrue(yandexMailInboxPage.checkThatLetterNotRead());
            Assert.AreEqual("Hello!", yandexMailInboxPage.readLetter());
        }

        [Test]
        public void YandexMailMessageReply()
        {
            YandexMailInboxPage yandexMailInboxPage = new YandexMailInboxPage(driver);
            yandexMailInboxPage.openInboxPage("man7est@yandex.by", "12345Second");
            yandexMailInboxPage.openLetter();
            yandexMailInboxPage.clickReply();
            yandexMailInboxPage.replyToLetter("Ok");
            yandexMailInboxPage.clickSend();

            MailRuInboxPage mailRuInboxPage = new MailRuInboxPage(driver);
            mailRuInboxPage.openInboxPage("firstmantest@mail.ru", "12345First");
            mailRuInboxPage.openLastLetter();
            Assert.AreEqual("Ok\r\n ", mailRuInboxPage.readLetter());
        }

        [Test]
        public void YandexMailLogout()
        {
            YandexMailHomePage yandexMailHomePage = new YandexMailHomePage(driver);
            yandexMailHomePage.openHomePage("man7est@yandex.by", "12345Second");
            yandexMailHomePage.logOut();
        }


        //[Test]
        //public void OpeningSearchEngine()
        //{
        //    MailRuLoginPage mailLoginPage = new MailRuLoginPage(driver);
        //    mailLoginPage.openAuthorizationPage();
        //    mailLoginPage.enterLogin("firstmantest@mail.ru");
        //    mailLoginPage.enterPassword("12345First");
        //}

        //[Test]
        //public void SendMassage()
        //{
        //    MailRuHomePage homePage = new MailRuHomePage(driver);
        //    homePage.openHomePage("firstmantest@mail.ru", "12345First");
        //    MailRuWriteLetterPage writeLetterPage = new MailRuWriteLetterPage(driver);
        //    writeLetterPage.sendMassage("man7est@yandex.by");
        //}

        //[Test]
        //public  void Check()
        //{ 
        //    YandexMailHomePage yandexMailHomePage = new YandexMailHomePage(driver);
        //    yandexMailHomePage.openHomePage("man7est@yandex.by", "12345Second");
        //    Assert.IsTrue(yandexMailHomePage.checkThatLetterNotRead());
        //}

        //[Test]
        //public void OpenLatter()
        //{
        //    YandexMailHomePage yandexMailHomePage = new YandexMailHomePage(driver);
        //    yandexMailHomePage.openHomePage("man7est@yandex.by", "12345Second");
        //    yandexMailHomePage.openLetter();

        //}

        //[Test]
        //public void LogOut()
        //{
        //    YandexMailHomePage yandexMailHomePage = new YandexMailHomePage(driver);
        //    yandexMailHomePage.openHomePage("man7est@yandex.by", "12345Second");
        //    yandexMailHomePage.logOut();

        //}

        //[Test]
        //public void ReadLatter()
        //{
        //    YandexMailHomePage yandexMailHomePage = new YandexMailHomePage(driver);
        //    yandexMailHomePage.openHomePage("man7est@yandex.by", "12345Second");
        //    yandexMailHomePage.openLetter();
        //    Assert.AreEqual("Hello!", yandexMailHomePage.readLetter());
        //}

        //[Test]
        //public void ReplyToLatter()
        //{
        //    YandexMailHomePage yandexMailHomePage = new YandexMailHomePage(driver);
        //    yandexMailHomePage.openHomePage("man7est@yandex.by", "12345Second");
        //    yandexMailHomePage.openLetter();
        //    yandexMailHomePage.clickReply();
        //    yandexMailHomePage.replyToLetter("Ok");
        //    yandexMailHomePage.clickSend();
        //}

        //[Test]
        //public void OpenYandexMailHomePage()
        //{
        //    YandexMailHomePage ProtonHomePage = new YandexMailHomePage(driver);
        //    ProtonHomePage.openHomePage("man7est@yandex.by", "12345Second");
        //}

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}