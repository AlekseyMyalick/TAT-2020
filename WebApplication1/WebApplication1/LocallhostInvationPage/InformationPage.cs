using OpenQA.Selenium;

namespace WebApplication1.LocallhostInvationPage
{
    public class InformationPage
    {
        private IWebDriver _driver;
        const string INFORMATION_PAGE_URL = "http://localhost:49626/Summary.aspx";

        public InformationPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public InformationPage openInformationPage()
        {
            _driver.Navigate().GoToUrl(INFORMATION_PAGE_URL);
            return this;
        }

        public bool complianceСheckConsensusTable(string name, string email, string phone)
        {
            openInformationPage();
            IWebElement elementName = _driver.FindElement(By
                .XPath("//table[1]/tbody/tr/td[1]"));

            IWebElement elementEmail = _driver.FindElement(By
                .XPath("//table[1]/tbody/tr/td[2]"));

            IWebElement elementPhone = _driver.FindElement(By
                .XPath("//table[1]/tbody/tr/td[3]"));

            return elementName.Text == name && elementEmail.Text == email && elementPhone.Text == phone;
        }

        public bool complianceСheckRefusedTable(string name, string email, string phone)
        {
            openInformationPage();
            IWebElement elementName = _driver.FindElement(By
                .XPath("//table[2]/tbody/tr/td[1]"));

            IWebElement elementEmail = _driver.FindElement(By
                .XPath("//table[2]/tbody/tr/td[2]"));

            IWebElement elementPhone = _driver.FindElement(By
                .XPath("//table[2]/tbody/tr/td[3]"));

            return elementName.Text == name && elementEmail.Text == email && elementPhone.Text == phone;
        }
    }
}