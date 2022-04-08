using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Widgets
{
    public class Tabs : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public Tabs(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By toolTipsWidgets = By.XPath("//*[@class = 'element-group'][4]//child::li[7]");

        public void OriginTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'demo-tab-origin']"))).Click();
        }
        public void UseTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'demo-tab-use']"))).Click();
        }
        public void WhatTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id= 'demo-tab-what']"))).Click();
        }
        public void WidgetsToolTip()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(toolTipsWidgets)).Click();
        }
    }
}
