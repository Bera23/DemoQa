using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.PracticeForm
{
    public class PracticeForm : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public PracticeForm(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By alertsFrameWindows = (By.XPath("//*[@class='element-group'][3]"));

        By browserWindowAlerts = (By.XPath("//*[@class = 'element-group'][3]//child::li[1]"));

        public void FirstName(string firstName)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("firstName"))).SendKeys(firstName);
        }
        public void LastName(string lastName)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("lastName"))).SendKeys(lastName);
        }
        public void Email(string email)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("userEmail"))).SendKeys(email);
        }
        public void PressMaleButton()
        {
            wait.Until(ExpectedConditions.ElementIsVisible
                (By.XPath("//*[@class='custom-control custom-radio custom-control-inline'][1]")))
                .Click();
        }
        public void MobileNumber(string number)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("userNumber"))).SendKeys(number);
        }
        public void DateOfBirth()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dateOfBirthInput"))).Click();
        }
        public void YearOfBirth()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class='react-datepicker__year-dropdown-container react-datepicker__year-dropdown-container--select']"))).Click();
        }
        public void PickYear()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class='react-datepicker__year-select']//child::option[96]"))).Click();
        }
        public void MonthOfBirth()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class='react-datepicker__month-dropdown-container react-datepicker__month-dropdown-container--select']"))).Click();
        }
        public void PickMonth()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                  (By.XPath("//*[@class='react-datepicker__month-select']//child::option[6]"))).Click();
        }
        public void PickDay()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                  (By.XPath("//*[@class='react-datepicker__week'][4]//child::div[4]"))).Click();
        }

        /* public void Subject(string subject)
         {
             wait.Until(ExpectedConditions.ElementIsVisible(By.Id("subjectsContainer"))).SendKeys(subject);
         }
         public void SubjectEnter()
         {
             wait.Until(ExpectedConditions.ElementIsVisible(By.Id("subjectsContainer"))).SendKeys(Keys.Enter);
         }*/
        public void Hobbies()
        {
            wait.Until(ExpectedConditions.ElementIsVisible
                (By.XPath("//*[@class = 'custom-control custom-checkbox custom-control-inline']//descendant::label[1]"))).Click();
        }
        public void SubmitBtn()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id= 'submit']"))).Click();
        }
        public void AlertsFrameWindows()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(alertsFrameWindows)).Click();
        }

        public void CloseBtn()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='closeLargeModal']"))).Click();
        }

        public void AlertsBrowserWindows()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(browserWindowAlerts)).Click();
        }

    }
}
