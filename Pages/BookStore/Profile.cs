using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.BookStore
{
    public class Profile : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        public Profile(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        public void GoToStore()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id = 'gotoStore']"))).Click();
        }
    }
}
