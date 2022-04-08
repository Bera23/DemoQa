using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.BookStore
{
    public class Login : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        public Login(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By bookStoreBS = By.XPath("//*[@class='element-group'][6] ");

        public void NewUserBtn()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'newUser']"))).Click();
        }

        public void UserName(string userName)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'userName']"))).SendKeys(userName);
        }
        public void Password(string password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'password']"))).SendKeys(password);
        }

        public void LoginBtn()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'login']"))).Click();
        }

    }
}
