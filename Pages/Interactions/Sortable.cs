using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Interactions
{
    public class Sortable : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        private Actions actions;
        public Sortable(WebDriver driver, WebDriverWait wait, Actions actions)
        {
            this.driver = driver;
            this.wait = wait;
            this.actions = actions;
        }

        By selectableInteractions = By.XPath("//*[@class = 'element-group'][5]//child::li[2]");

        public void DragSixOnOne()
        {
            Actions action = new Actions(driver);
            action.ClickAndHold
                (wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[6]")))).
                MoveToElement
                (wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[1]")))).
                Release().Build().Perform();
        }
        public void DragTwoOnFour()
        {
            Actions action = new Actions(driver);
            action.ClickAndHold
                (wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[2]")))).
                MoveToElement
                (wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'vertical-list-container mt-4']//child::div[4]")))).
                Release().Build().Perform();
        }

        public void Grid()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id = 'demo-tab-grid']"))).Click();
        }
        public void DragThreeToSeven()
        {
            Actions action = new Actions(driver);
            action.ClickAndHold
                  (wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'create-grid']//child::div[3]")))).
                  MoveToElement
                  (wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'create-grid']//child::div[7]")))).
                  Release().Build().Perform();
        }
        public void InteractionsSelectable()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(selectableInteractions)).Click();
        }
    }
}
