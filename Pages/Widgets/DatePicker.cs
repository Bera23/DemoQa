using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Alerts
{
    public class DatePicker : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public DatePicker(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By sliderWidgets = By.XPath("//*[@class = 'element-group'][4]//child::li[4]");

        public void SelectDate()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("datePickerMonthYearInput"))).Click();
        }
        public void SelectYear()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class='react-datepicker__year-dropdown-container react-datepicker__year-dropdown-container--select']"))).Click();
        }
        public void PickYear()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                (By.XPath("//*[@class='react-datepicker__year-select']//child::option[96]"))).Click();
        }
        public void SelectMonth()
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

        public void DateAndTimePickerInput()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                  (By.Id("dateAndTimePickerInput"))).Click();
        }

        public void SelectYearDateTime()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                  (By.XPath("//*[@class = 'react-datepicker__year-read-view']"))).Click();
        }

        public void PickYearDateTime()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                  (By.XPath
                  ("//*[@class = 'react-datepicker__year-dropdown-container react-datepicker__year-dropdown-container--scroll']" +
                  "//child::div[@class = 'react-datepicker__year-option'][10]")))
                .Click();
        }
        public void PickTIme()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable
                  (By.XPath("//*[@class = 'react-datepicker__time-box']//child::li[10]"))).Click();
        }

        public void WidgetsSlider()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(sliderWidgets)).Click();
        }
    }
}
