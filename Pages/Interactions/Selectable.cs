using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Interactions
{
    public class Selectable : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
       
        public Selectable(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By resizableInteractions = By.XPath("//*[@class = 'element-group'][5]//child::li[3]");

        public void ListTwo()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'tab-content']//child::li[2]"))).Click();
        }
        public void ListFour()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'tab-content']//child::li[4]"))).Click();
        }
        public void Grid()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id = 'demo-tab-grid']"))).Click();
        }
        public void GridFive()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'demo-tabpane-grid']//child::div[2]//child::li[2]"))).Click();
        }
        public void GridNine()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'demo-tabpane-grid']//child::div[3]//child::li[3]"))).Click();
        }
        public void InteractionsResizable()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(resizableInteractions)).Click();
        }

    }
}
