using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Interactions
{
    public class Droppable : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        private Actions actions;

        public Droppable(WebDriver driver, WebDriverWait wait, Actions actions)
        {
            this.driver = driver;
            this.wait = wait;
            this.actions = actions;
        }

        By dragabbleInteractions = By.XPath("//*[@class = 'element-group'][5]//child::li[5]");

        public void SimpleDropBox()
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'simple-drop-container']//child::div[@id][1]"))),
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'simple-drop-container']//child::div[@id='droppable']")))).Release().Build().Perform();
        }
        public void AcceptTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id = 'droppableExample-tab-accept']"))).Click();
            string aa = null;
        }
        public void AcceptableDropBox()
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'accept-drop-container']//child::div[@id][1]"))),
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'accept-drop-container']//child::div[@id = 'droppable']")))).Release().Build().Perform();
        }
        public void PreventTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id = 'droppableExample-tab-preventPropogation']"))).Click();
        }
        public void PreventDropBoxOuter()
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='dragBox']"))),
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='notGreedyDropBox']")))).Release().Build().Perform();
        }
        public void PreventDropBoxOuterDrop()
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='dragBox']"))),
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'pp-drop-container']//child::div[@id='greedyDropBox']")))).Release().Build().Perform();
        }
        public void RevertTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id = 'droppableExample-tab-revertable']"))).Click();
        }
        public void WillRevert()
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='revertable']"))),
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='droppable']")))).Release().Build().Perform();
        }
        public void NotRevert()
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='notRevertable']"))),
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'revertable-drop-container']//child::div[@id='droppable']")))).Release().Build().Perform();
        }
        public void InteractionsDragabble()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(dragabbleInteractions)).Click();
        }
    }
}
