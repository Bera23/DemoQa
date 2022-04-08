using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Interactions
{
    public class Dragabble : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        private Actions actions;

        public Dragabble(WebDriver driver, WebDriverWait wait, Actions actions)
        {
            this.driver = driver;
            this.wait = wait;
            this.actions = actions;
        }

        By openBookStoreApplication = By.XPath("//*[@class='element-group'][6] ");
        By loginBookStore = By.XPath("//*[@class = 'element-group'][6]//child::li[1]");

        public void SimpleDropBox(int x, int y)
        {
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'tab-content']//child::div[@id='dragBox']"))),
               x, y).Release().Build().Perform();
        }

        public void AxisTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'draggableExample-tab-axisRestriction']"))).Click();
        }

        public void XDrag(int x)
        {
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'restrictedX']"))),
               x, 0).Release().Build().Perform();
        }
        public void YDrag(int y)
        {
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'restrictedY']"))),
               0, y).Release().Build().Perform();
        }
        public void ContainerTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'draggableExample-tab-containerRestriction']"))).Click();
        }

        public void ContainerBox(int x, int y)
        {
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='draggable ui-widget-content ui-draggable ui-draggable-handle']"))),
               x, y).Release().Build().Perform();
        }
        public void ContainerParent(int x, int y)
        {
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='ui-widget-header ui-draggable ui-draggable-handle']"))),
               x, y).Release().Build().Perform();
        }

        public void BookStore()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(openBookStoreApplication)).Click();
        }

        public void LoginBS()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(loginBookStore)).Click();
        }
    }
}
