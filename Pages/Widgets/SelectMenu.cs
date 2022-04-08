using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Widgets
{
    public class SelectMenu : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        private Actions actions;
        public SelectMenu(WebDriver driver, WebDriverWait wait, Actions actions)
        {
            this.driver = driver;
            this.wait = wait;
            this.actions = actions;
        }

        By closeWidgets = By.XPath("//*[@class='element-group'][4]//child::div[@class = 'header-right']");

        By openInteractions = By.XPath("//*[@class='element-group'][5]//child::div[@class = 'header-right']");

        By sortableInteractions = By.XPath("//*[@class = 'element-group'][5]//child::li[1]");

        public void SelectOption()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text() = 'Select Option']"))).Click();
        }
        public void PickOptions()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text() = 'A root option']"))).Click();
        }
        public void SelectOne()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text() = 'Select Title']"))).Click();
        }
        public void PickOne()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text() = 'Dr.']"))).Click();
        }
        public void Multiselect()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'row'][2]//descendant::div[@class = ' css-2b097c-container']"))).Click();
        }
        public void PickMultiSelect()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text() = 'Blue']"))).Click();
        }
        public void StandardMultiSelect()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'cars']"))).
                SendKeys(Keys.Control + "A");
        }
        public void CloseWidgets()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(closeWidgets)).Click();
        }
        public void OpenInteractions()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(openInteractions)).Click();
        }
        public void InteractionsSortable()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(sortableInteractions)).Click();
        }

    }
}
