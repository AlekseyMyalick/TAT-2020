using OpenQA.Selenium;

namespace WebApplication1.LocallhostInvationPage
{
    public class AnswerPage
    {
        private IWebDriver _driver;

        public AnswerPage(IWebDriver driver)
        {
            this._driver = driver;
        }
    }
}