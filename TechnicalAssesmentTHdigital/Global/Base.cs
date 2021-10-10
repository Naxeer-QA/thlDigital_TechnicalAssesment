using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TechnicalAssesmentTHdigital.Global
{
    class Base
    {
        IWebDriver driver = new ChromeDriver();
        String baseUrl = "https://www.britz.com/";

        [OneTimeSetUp]
        public void Initialize()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(45);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(45);
            driver.Navigate().GoToUrl(baseUrl);
        }

        [OneTimeTearDown]
        public void Terminate()
        {
            driver.Close();
        }
    }
}
