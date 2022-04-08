using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.BookStore
{
    public class Register : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        public Register(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void FirstName(string firstName)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'firstname']"))).SendKeys(firstName);
        }
        public void LastName(string lastName)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'lastname']"))).SendKeys(lastName);
        }
        public void UserName(string userName)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'userName']"))).SendKeys(userName);
        }
        public void Password(string password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'password']"))).SendKeys(password);
        }
        public void Captcha()
        {
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.XPath("//*[@title = 'reCAPTCHA']")));

            wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class= 'rc-anchor-content']//child::div[@class = 'recaptcha-checkbox-border']"))).
                Click();
        }

        public void RegisterBtn()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id = 'userForm']//child::button[@id = 'register']"))).Click();
        }
        public void GoToLoginBtn()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id= 'gotologin']"))).Click();
        }
    }
}
