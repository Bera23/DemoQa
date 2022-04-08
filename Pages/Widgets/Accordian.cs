using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Widgets
{
    public class Accordian : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public Accordian(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By autoCompleteWidgets = By.XPath("//*[@class = 'element-group'][4]//child::li[2]");

        public void Section2()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("section2Heading"))).Click();
        }
        public void Section3()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("section3Heading"))).Click();
        }

        public void WidgetsAutoComplete()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(autoCompleteWidgets)).Click();
        }
    }
}
