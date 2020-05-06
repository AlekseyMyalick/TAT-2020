using OpenQA.Selenium;

namespace Task_2._3
{
    class MailRuWriteLetterPage
    {
        private IWebDriver _driver;

        public MailRuWriteLetterPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public void sendMassage(string recipient)
        {
            IWebElement buttonWriteLetter = _driver.FindElement(By
                .XPath("//span[@class='compose-button__wrapper']"));
            buttonWriteLetter.Click();
            IWebElement elementRecipient = _driver.FindElement(By
                .XPath("//input[@class='container--H9L5q size_s_compressed--2c-eV']"));
            elementRecipient.Clear();
            elementRecipient.SendKeys(recipient);
            elementRecipient.SendKeys(Keys.Enter);

            IWebElement messageInput = _driver.FindElement(By
                .XPath("//div[@tabindex='505']"));
            messageInput.SendKeys("Hello!");

            IWebElement buttonSend = _driver.FindElement(By
                .XPath("//span[@tabindex='570']"));
            buttonSend.Click();
        }

        public void closeReportWindow()
        {
            IWebElement cross = _driver.FindElement(By
                .XPath("//span[@tabindex='1000']"));
            cross.Click();
        }
    }
}
