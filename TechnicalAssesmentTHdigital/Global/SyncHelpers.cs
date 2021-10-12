using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TechnicalAssesmentTHdigital.Global
{
    public class SyncHelpers
    {
        public void waitUntilClickable(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void waitUntilVisible(IWebDriver driver, IWebElement element)
        {
            waitUntilVisible(driver, element);
        }

        public void waitUntilSelected(IWebDriver driver, IWebElement element)
        {
            waitUntilSelected(driver, element);
        }

        public void stalenessOf(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.StalenessOf(element));
        }


    }
}
