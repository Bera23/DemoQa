using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Alerts
{
    public class BrowserWindows : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public BrowserWindows(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By alertsAlert = (By.XPath("//*[@class = 'element-group'][3]//child::li[2]"));

        public void NewTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("tabButton"))).Click();
        }
        public void NewWindow()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("windowButton"))).Click();
        }
        public void NewWindowMessage()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("messageWindowButton"))).Click();
        }
        public void Alerts()
        {
            wait.Until
                (ExpectedConditions.ElementIsVisible(alertsAlert)).Click();
        }


    }
}
