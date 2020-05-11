using OpenQA.Selenium;

namespace Task_2._3.YandexMail
{
    class YandexMailHomePage
    {
        private IWebDriver _driver;

        public YandexMailHomePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public YandexMailHomePage openHomePage(string login, string password)
        {
            YandexMailLoginPage mailLoginPage = new YandexMailLoginPage(_driver);
            mailLoginPage.loginAs(login, password);
            return this;
        }

        public YandexMailLoginPage logOut()
        {
            IWebElement elemenLogOut = _driver.FindElement(By
                .XPath("//div[@class='mail-User-Name']"));
            elemenLogOut.Click();
            IWebElement exit = _driver.FindElement(By
                .XPath("//a[text()='Выйти из сервисов Яндекса']"));
            exit.Click();
            return new YandexMailLoginPage(_driver);
        }
    }
}
