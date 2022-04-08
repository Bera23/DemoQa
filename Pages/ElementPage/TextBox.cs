using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.ElementPage
{
    public class TextBox : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        By checkBoxElement = By.XPath("//*[@class = 'element-group'][1]//child::li[2]");

        public TextBox(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void FullName(string fullName)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("userName"))).SendKeys(fullName);
        }

        public void Email(string email)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("userEmail"))).SendKeys(email);
        }

        public void CurrentAddress(string currentAddress)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("currentAddress"))).SendKeys(currentAddress);
        }

        public void PermanentAddress(string permanentAddress)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("permanentAddress"))).SendKeys(permanentAddress);
        }

        public void SubmitButton()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@class='btn btn-primary']"))).
             Click();
        }
        public void ElementCheckBox()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(checkBoxElement)).Click();
        }
    }
}
