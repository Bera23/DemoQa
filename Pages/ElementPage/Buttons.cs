using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.ElementPage
{
    public class Buttons : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        private Actions actions;

        By linkElement = By.XPath("//*[@class = 'element-group'][1]//child::li[6]");

        public Buttons(WebDriver driver, WebDriverWait wait, Actions actions)
        {
            this.driver = driver;
            this.wait = wait;
            this.actions = actions;
        }

        public void DoubleClick()
        {
            actions.MoveToElement(
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='doubleClickBtn']"))))
                .DoubleClick().Perform();
        }

        public void RightClick()
        {
            actions.MoveToElement(
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='rightClickBtn']"))))
                .ContextClick().Perform();
        }

        public void ClickBtn()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@class= 'mt-4'][2]//child::button"))).Click();
        }

        internal void ElementLinks()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(linkElement)).Click();
        }
    }
}
