using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages
{
    public class HomePage
    {
        private WebDriver driver;
        private WebDriverWait wait;
        
        By elementsHomePage = By.XPath("//*[@class='category-cards']//child::div[@class = 'card mt-4 top-card'][1]");
        By textBoxElement = By.XPath("//*[@class='element-group'][1]//child::li[1]");

        public HomePage(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ElementsHomePage()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(elementsHomePage)).Click();
        }

        public void ElementTextBox()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(textBoxElement)).Click();
        }

        public string GetHeader()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'main-header']"))).Text;
        }
    }
}
