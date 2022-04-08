using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Widgets
{
    public class AutoComplete : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public AutoComplete(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By datePickerWidgets = By.XPath("//*[@class = 'element-group'][4]//child::li[3]");

        public void MultipleColorClick()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("autoCompleteMultipleContainer"))).Click();
        }
        public void MultipleColor(string color)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("autoCompleteMultipleContainer"))).SendKeys(color);

        }
        public void MultipleColorEnter()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("autoCompleteMultipleContainer"))).SendKeys(Keys.Enter);
        }

        public void WidgetsDatePicker()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(datePickerWidgets)).Click();
        }
    }
}
