using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebApplication1
{
    public class DataInput
    {
        public static void UsersData
            (IWebDriver driver, string name, string email, string phone, string willattend)
        {
            IWebElement elementName = driver.FindElement(By.XPath("//input[@id='name']"));
            elementName.SendKeys(name);

            IWebElement elementEmail = driver.FindElement(By.XPath("//input[@id='email']"));
            elementEmail.SendKeys(email);

            IWebElement elementPhone = driver.FindElement(By.XPath("//input[@id='phone']"));
            elementPhone.SendKeys(phone);

            IWebElement elementWillatend = driver.FindElement(By.XPath("//select[@id='willattend']"));
            SelectElement selectElement = new SelectElement(elementWillatend);
            selectElement.SelectByText(willattend);

            IWebElement elementButtun = driver.FindElement(By.XPath("//button[@type='submit']"));
            elementButtun.Click();
        }
    }
}