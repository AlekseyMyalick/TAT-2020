using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebApplication1.LocallhostInvationPage;

namespace WebApplication1
{
    public class LocallhostLoginPage
    {
        private IWebDriver _driver;
        const string LOCALLHOST_PAGE_URL = "http://localhost:49626/Default.aspx";

        public LocallhostLoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public LocallhostLoginPage openAuthorizationPage()
        {
            _driver.Navigate().GoToUrl(LOCALLHOST_PAGE_URL);
            return this;
        }

        public void enterName(string name)
        {
            IWebElement elementName = _driver.FindElement(By.XPath("//input[@id='name']"));
            elementName.SendKeys(name);
        }

        public void enterEmail(string email)
        {
            IWebElement elementEmail = _driver.FindElement(By.XPath("//input[@id='email']"));
            elementEmail.SendKeys(email);
        }

        public void enterPhone(string phone)
        {
            IWebElement elementPhone = _driver.FindElement(By.XPath("//input[@id='phone']"));
            elementPhone.SendKeys(phone);
        }

        public void enterWillatend(string willattend)
        {
            IWebElement elementWillatend = _driver.FindElement(By.XPath("//select[@id='willattend']"));
            SelectElement selectElement = new SelectElement(elementWillatend);
            selectElement.SelectByText(willattend);
        }

        public void pressButton()
        {
            IWebElement elementButtun = _driver.FindElement(By.XPath("//button[@type='submit']"));
            elementButtun.Click();
        }

        public AnswerPage openResponsePage(string name, string email, string phone, string willattend)
        {
            openAuthorizationPage();
            enterName(name);
            enterEmail(email);
            enterPhone(phone);
            enterWillatend(willattend);
            pressButton();
            return new AnswerPage(_driver);
        }

        public IWebElement findError()
        {
            IWebElement nameError = _driver.FindElement(By
                .XPath("//div[@id='validationSummary']/ul/li"));
            return nameError;
        }
    }
}