using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Widgets
{
    public class Menu : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public Menu(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By selectMenuWidgets = By.XPath("//*[@class = 'element-group'][4]//child::li[9]");
        public void MainItem2()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Main Item 2"))).Click();
        }
        public void SubList()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text() = 'SUB SUB LIST »']"))).Click();
        }
        public void SubItem2()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text() = 'SUB SUB LIST »']"))).Click();
        }
        public void WidgetsSelectMeny()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(selectMenuWidgets)).Click();
        }
    }
}
