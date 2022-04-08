using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.ElementPage
{
    public class Links : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        By brokenLinksElement = By.XPath("//*[@class = 'element-group'][1]//child::li[7]");
        public Links(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void HomeLink()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("simpleLink"))).Click();
        }
        public void HomeLink2()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("dynamicLink"))).Click();
        }
        public void Created()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("created"))).Click();
        }
        public void NoContent()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("no-content"))).Click();
        }
        public void Moved()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("moved"))).Click();
        }
        public void BadRequest()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("bad-request"))).Click();
        }
        public void Unauthorized()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("unauthorized"))).Click();
        }
        public void Forbidden()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("forbidden"))).Click();
        }
        public void NotFound()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("invalid-url"))).Click();
        }

        public void ElementBrokenLinks()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(brokenLinksElement)).Click();
        }
    }
}
