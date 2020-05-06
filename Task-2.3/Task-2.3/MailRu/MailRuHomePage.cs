using OpenQA.Selenium;

namespace Task_2._3
{
    public class MailRuHomePage
    {
        private IWebDriver _driver;

        public MailRuHomePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public MailRuHomePage openHomePage(string login, string password)
        {
            MailRuLoginPage mailLoginPage = new MailRuLoginPage(_driver);
            mailLoginPage.loginAs(login, password);
            return this;
        }

        public MailRuLoginPage logOut()
        {
            IWebElement elemenLogOut = _driver.FindElement(By
                .XPath("//td[@class='w-x-ph__auth__col w-x-ph__auth__col_right']"));
            elemenLogOut.Submit();
            return new MailRuLoginPage(_driver);
        }
    }
}
