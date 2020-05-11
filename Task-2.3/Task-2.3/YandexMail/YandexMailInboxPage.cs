using OpenQA.Selenium;

namespace Task_2._3.YandexMail
{
    class YandexMailInboxPage
    {
        private IWebDriver _driver;

        public YandexMailInboxPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public YandexMailHomePage openInboxPage(string login, string password)
        {
            YandexMailHomePage mailLoginPage = new YandexMailHomePage(_driver);
            mailLoginPage.openHomePage(login, password);
            return new YandexMailHomePage(_driver);
        }

        public bool checkThatLetterNotRead()
        {
            IWebElement elemenLetterNotRead = _driver.FindElement(By
                .XPath("//div[@class='ns-view-container-desc mail-MessagesList js-messages-list']/div[1]//span[@title='Отметить как прочитанное']"));
            return elemenLetterNotRead.Displayed;
        }

        public void openLetter()
        {
            IWebElement elemenLetter = _driver.FindElement(By
               .XPath("//div[@class='ns-view-container-desc mail-MessagesList js-messages-list']/div[1]"));
            elemenLetter.Click();
        }

        public string readLetter()
        {
            IWebElement textLetter = _driver.FindElement(By
              .XPath("//div[@class='mail-Message-Body-Content']/div[1]"));
            string latter = textLetter.Text;
            return latter;
        }

        public void clickReply()
        {
            IWebElement reply = _driver.FindElement(By
              .XPath("//span[text()='Ответить']"));
            reply.Click();
        }

        public void replyToLetter(string letter)
        {
            IWebElement message = _driver.FindElement(By
                .XPath("//div[@class='cke_wysiwyg_div cke_reset cke_enable_context_menu cke_editable cke_editable_themed cke_contents_ltr']/div[1]"));
            message.SendKeys(letter);
        }

        public void clickSend()
        {
            IWebElement send = _driver.FindElement(By
                .XPath("//div[@class='ComposeControlPanelButton ComposeControlPanel-Button ComposeControlPanel-SendButton ComposeSendButton']/button"));
            send.Click();
        }
    }
}
