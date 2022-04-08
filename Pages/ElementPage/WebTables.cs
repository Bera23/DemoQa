using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.ElementPage
{
    public class Webtables : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;

        By buttonElement = By.XPath("//*[@class = 'element-group'][1]//child::li[5]");

        public Webtables(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void AddNewRecordButton()
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("addNewRecordButton"))).Click();
        }
        public void FirstName(string firstName)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("firstName"))).SendKeys(firstName);
        }
        public void LastName(string lastName)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("lastName"))).SendKeys(lastName);
        }
        public void Email(string email)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("userEmail"))).SendKeys(email);
        }
        public void Age(string age)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("age"))).SendKeys(age);
        }
        public void Salary(string salary)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("salary"))).SendKeys(salary);
        }
        public void Department(string department)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("department"))).SendKeys(department);
        }
        public void SubmitBtn()
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("submit"))).Click();
        }
        /*public void RowsBtn()
        {
            wait.Until(ExpectedConditions.ElementIsVisible
                (By.XPath("//*[@id='app']//descendant::span[@class='select-wrap -pageSizeOptions']::options[@value='5']")))
                .Click();
        }*/
        public void DeleteRecord()
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("delete-record-1"))).Click();
        }

        public void SearchBox(string searchBox)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("searchBox"))).SendKeys(searchBox);
        }

        public void EditRecord()
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("edit-record-4"))).Click();
        }

        public void ClearSalary()
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("salary"))).Clear();
        }

        public void EditSalary(string salary)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("salary"))).SendKeys(salary);
        }

        public void SubmitBtnEdit()
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id("submit"))).Click();
        }
        public void ElementButtons()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(buttonElement)).Click();
        }
    }
}
