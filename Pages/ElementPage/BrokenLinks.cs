using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.ElementPage
{
    public class BrokenLinks : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        By uploadAndDownloadElement = By.XPath("//*[@class = 'element-group'][1]//child::li[8]");
        public BrokenLinks(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        public void ValidLink()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class='col-12 mt-4 col-md-6']//child::div[a]//child::a[1]"))).Click();
        }
        public void BrokenLink()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class='col-12 mt-4 col-md-6']//child::div[a]//child::a[2]"))).Click();
        }
        public void ElementUploadAndDownload()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(uploadAndDownloadElement)).Click();
        }
    }
}
