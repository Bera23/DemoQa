
using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Interactions
{
    public class Resizable : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        public Resizable(WebDriver driver, WebDriverWait wait, Actions actions)
        {
            this.driver = driver;
            this.wait = wait;
            this.actions = actions;
        }

        By droppableInteractions = By.XPath("//*[@class = 'element-group'][5]//child::li[4]");

        public void ResizableBox(int x, int y)
        {
            Actions action = new Actions(driver);
            action.ClickAndHold(wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class = 'constraint-area']//child::span")))).
                MoveByOffset(x, y).Release().Build().Perform();
        }
        public void ResizableBoxBig(int x, int y)
        {
            Actions action = new Actions(driver);
            action.ClickAndHold(wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class = 'resizable-nolimit mt-4']//child::span")))).
                MoveByOffset(x, y).Release().Build().Perform();
        }

        public void InteractionsDroppable()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(droppableInteractions)).Click();
        }
    }
}
