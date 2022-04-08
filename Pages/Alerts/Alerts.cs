using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Alerts
{
    public class Alerts : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public Alerts(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By framesAlerts = By.XPath("//*[@class = 'element-group'][3]//child::li[3]");
        By nestedFramesAlerts = By.XPath("//*[@class = 'element-group'][3]//child::li[4]");
        By modealDialogsAlerts = By.XPath("//*[@class = 'element-group'][3]//child::li[5]");

        public void Alert()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("alertButton"))).Click();
        }
        public void AlertWait()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("timerAlertButton"))).Click();
        }
        public void ComfirmAlert()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("confirmButton"))).Click();
        }
        public void PromptAlert()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("promtButton"))).Click();
        }

        public void AlertFrames()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(framesAlerts)).Click();
        }
        public void AlertNestedFrames()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(nestedFramesAlerts)).Click();
        }
        public void AlertModealDialogs()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(modealDialogsAlerts)).Click();
        }
    }
}
