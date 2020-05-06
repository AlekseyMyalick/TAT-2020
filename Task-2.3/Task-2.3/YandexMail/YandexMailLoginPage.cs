using OpenQA.Selenium;

namespace Task_2._3.ProtonMail
{
    class YandexMailLoginPage
    {
        private IWebDriver _driver;
        const string MAIL_PAGE_URL = "https://passport.yandex.by/auth?origin=home_desktop_by&retpath=https%3A%2F%2Fmail.yandex.by%2F&backpath=https%3A%2F%2Fyandex.by";

        public YandexMailLoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public YandexMailLoginPage openAuthorizationPage()
        {
            _driver.Navigate().GoToUrl(MAIL_PAGE_URL);
            return this;
        }

        public void enterLogin(string login)
        {
            IWebElement elementLogin = _driver.FindElement(By.XPath("//input[@id='passp-field-login']"));
            elementLogin.Clear();
            elementLogin.SendKeys(login);
            IWebElement buttonComeIn = _driver.FindElement(By
                .XPath("//button[@class='control button2 button2_view_classic button2_size_l " +
                "button2_theme_action button2_width_max button2_type_submit passp-form-button']"));
            buttonComeIn.Click();
        }

        public void enterPassword(string password)
        {
            IWebElement elementPassword = _driver.FindElement(By.XPath("//input[@id='passp-field-passwd']"));
            elementPassword.Clear();
            elementPassword.SendKeys(password);
            IWebElement buttonComeIn = _driver.FindElement(By
                .XPath("//button[@class='control button2 button2_view_classic " +
                "button2_size_l button2_theme_action button2_width_max button2_type_submit passp-form-button']"));
            buttonComeIn.Click();
        }

       
        public YandexMailHomePage loginAs(string login, string password)
        {
            openAuthorizationPage();
            enterLogin(login);
            enterPassword(password);
            return new YandexMailHomePage(_driver);
        }

    }
}
