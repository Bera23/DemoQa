using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Widgets
{
    public class ProgressBar : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public ProgressBar(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By tabsWidgets = By.XPath("//*[@class = 'element-group'][4]//child::li[6]");

        public void StartProgressBar()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'startStopButton']"))).Click();
        }
        public void StopProgressBar()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'startStopButton']"))).Click();
        }
        public void WidgetsTabs()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(tabsWidgets)).Click();
        }
    }
}
