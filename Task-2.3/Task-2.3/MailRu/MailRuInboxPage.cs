using OpenQA.Selenium;

namespace Task_2._3.MailRu
{
    class MailRuInboxPage
    {
        private IWebDriver _driver;

        public MailRuInboxPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public MailRuHomePage openInboxPage(string login, string password)
        {
            MailRuLoginPage mailLoginPage = new MailRuLoginPage(_driver);
            mailLoginPage.loginAs(login, password);
            return new MailRuHomePage(_driver);
        }

        public void openLastLetter()
        {
            IWebElement lastLetter = _driver.FindElement(By
                .XPath("//div[@class='dataset__items']/a[1]"));
            lastLetter.Click();
        }

        public string readLetter()
        {
            IWebElement textLetter = _driver.FindElement(By
                .XPath("//div[@class='js-helper js-readmsg-msg']/descendant::div[text()][1]"));
            string letter = textLetter.Text;
            return letter;
        }
    }
}
