using OpenQA.Selenium;

namespace Task_2._3
{
    public class MailRuLoginPage 
    {
        private IWebDriver _driver;
        const string MAIL_PAGE_URL = "https://mail.ru/";

        public MailRuLoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public MailRuLoginPage openAuthorizationPage()
        {
            _driver.Navigate().GoToUrl(MAIL_PAGE_URL);
            IWebElement elementButtonMail = _driver.FindElement(By
                .XPath("//span[@class='x-ph__link__text']"));
            elementButtonMail.Click();
            return this;
        }

        public void enterLogin(string login)
        {
            IWebElement elementLogin = _driver.FindElement(By.XPath("//input[@name='Login']"));
            elementLogin.Clear();
            elementLogin.SendKeys(login);
            IWebElement buttonEnterPassword = _driver.FindElement(By.XPath("//button[@data-test-id='next-button']"));
            buttonEnterPassword.Click();

        }

        public void enterPassword(string password)
        {
            IWebElement elementPassword = _driver.FindElement(By.XPath("//input[@name='Password']"));
            elementPassword.Clear();
            elementPassword.SendKeys(password);
            IWebElement buttonComeIn = _driver.FindElement(By.XPath("//button[@data-test-id='submit-button']"));
            buttonComeIn.Click();
        }

        public MailRuHomePage loginAs(string login, string password)
        {
            openAuthorizationPage();
            enterLogin(login);
            enterPassword(password);
            return new MailRuHomePage(_driver);
        }
    }
}
