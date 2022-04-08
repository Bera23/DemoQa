using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.ElementPage
{
    public class DynamicProperties : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        By formsForm = By.XPath("//*[@class='element-group'][2]");
        By practiceFormsForm = By.XPath("//*[@class = 'element-group'][2]//child::li[1]");
        
        public DynamicProperties(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void EnableBtn()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("enableAfter"))).Click();
        }
        public void ChangeColorBtn()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("colorChange"))).Click();
        }
        public void VisibleAfterBtn()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("visibleAfter"))).Click();
        }
        public void Forms()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(formsForm)).Click();
        }
        public void PracticeFormsForm()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(practiceFormsForm)).Click();
        }
    }
}
