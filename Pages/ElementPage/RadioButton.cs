using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.ElementPage
{
    public class RadioButton : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        By webTablesElement = By.XPath("//*[@class = 'element-group'][1]//child::li[4]");

        public RadioButton(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        public void PressYesButton()
        {
            wait.Until(ExpectedConditions.ElementIsVisible
                (By.XPath("//*[@class='custom-control custom-radio custom-control-inline'][2]"))).Click();
        }
        public void ElementWebTables()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(webTablesElement)).Click();
        }
    }
}
