using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.ElementPage
{
    public class CheckBox : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        By radioBtnElement = By.XPath("//*[@class = 'element-group'][1]//child::li[3]");

        public CheckBox(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ToggleHome()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@aria-label='Toggle']"))).Click();
        }
        public void ToggleDownloads()
        {
            wait.Until(ExpectedConditions.ElementIsVisible
                (By.XPath("//*[@id='tree-node']//descendant::button[@aria-label='Toggle'][4]"))).Click();
        }
        public void CheckBoxDownloads()
        {
            wait.Until
               (ExpectedConditions.
               ElementIsVisible(By.XPath("//*[@id='tree-node']//descendant::span[@class='rct-checkbox'][4]"))).
               Click();
        }

        public void CollapseAll()
        {
            wait.Until
               (ExpectedConditions.ElementIsVisible(By.XPath("//*[@aria-label='Collapse all']"))).Click();
        }
        public void ElementRadioBtn()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(radioBtnElement)).Click();
        }
    }
}


