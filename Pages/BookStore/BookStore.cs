using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.BookStore
{
    public class BookStore : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        public BookStore(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void PickBook()
        {
            wait.Until(ExpectedConditions.ElementIsVisible
                (By.XPath("//*[@id= 'see-book-Learning JavaScript Design Patterns']"))).Click();
        }
        public void AddToCollection()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'text-right fullButton']//child::button"))).Click();
        }
        public void GoBack()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class= 'text-left fullButton']//child::button"))).Click();
        }

        public void Profil()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'element-group'][6]//child::li[3]"))).Click();
        }
    }
}
