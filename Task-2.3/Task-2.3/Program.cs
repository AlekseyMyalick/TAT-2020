﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.by/");

        }
    }
}
