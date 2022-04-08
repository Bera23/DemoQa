using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Alerts
{
    public class ModalDialogs : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public ModalDialogs(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By closeAlert = By.XPath("//*[@id='app']//descendant::div[@class ='icon'][3]");

        By openWidgets = By.XPath("//*[@class='element-group'][4]");

        By accordianWidgets = By.XPath("//*[@class = 'element-group'][4]//child::li[1]");


        public void SmallModal()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("showSmallModal"))).Click();
        }
        public void CloseSmall()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("closeSmallModal"))).Click();
        }
        public void LargeModal()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("showLargeModal"))).Click();
        }
        public void CloseLarge()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("closeLargeModal"))).Click();
        }

        public void CloseAlerts()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(closeAlert)).Click();
        }

        public void Widgets()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(openWidgets)).Click();

        }
        public void WidgetsAccordian()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(accordianWidgets)).Click();
        }
    }
}
