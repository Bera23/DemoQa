using System;
using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Widgets
{
    public class ToolTips : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public ToolTips(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        private String javaScript = "var evObj = document.createEvent('MouseEvents');" +
                 "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, " +
                 "false, false, false, false, 0, null);" +
                 "arguments[0].dispatchEvent(evObj);";

        By menuWidgets = By.XPath("//*[@class = 'element-group'][4]//child::li[8]");

        public void HoverButton()
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, wait.Until
                (ExpectedConditions.ElementIsVisible
                (By.XPath("//*[@id= 'toolTipButton']"))));
        }
        public void HoverTextField()
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, wait.Until
                (ExpectedConditions.ElementIsVisible
                (By.XPath("//*[@id= 'toolTipTextField']"))));
        }
        public void HoverText()
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript
                (javaScript, wait.Until
                (ExpectedConditions.ElementIsVisible
                (By.XPath("//*[@id= 'texToolTopContainer']//child::a[1]"))));
        }

        public void WidgetsMenu()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(menuWidgets)).Click();
        }
    }
}
