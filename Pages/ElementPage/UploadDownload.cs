using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.ElementPage
{
    public class UploadDownload : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        By dynamicPropertiesElement = By.XPath("//*[@class = 'element-group'][1]//child::li[9]");
        public UploadDownload(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void DownloadBtn()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("downloadButton"))).Click();
        }

        public void UploadBtn(string picture)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("uploadFile"))).SendKeys(picture);
        }
        public void ElementDynamicProperties()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(dynamicPropertiesElement)).Click();
        }
    }
}
