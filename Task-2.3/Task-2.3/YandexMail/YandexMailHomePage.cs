using OpenQA.Selenium;

namespace Task_2._3.ProtonMail
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

       public bool checkThatLetterNotRead()
        {
            IWebElement elemenLetterNotRead = _driver.FindElement(By
                .XPath("//td[@class='w-x-ph__auth__col w-x-ph__auth__col_right']"));
            return elemenLetterNotRead.Displayed;
        }

        public YandexMailLoginPage logOut()
        {
            IWebElement elemenLogOut = _driver.FindElement(By
                .XPath("//td[@class='w-x-ph__auth__col w-x-ph__auth__col_right']"));
            elemenLogOut.Submit();
            return new YandexMailLoginPage(_driver);
        }
    }
}
