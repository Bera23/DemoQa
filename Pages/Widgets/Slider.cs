using DemoQa.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Pages.Widgets
{
    public class Slider : BaseTest
    {
        private WebDriver driver;
        private WebDriverWait wait;
        public Slider(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By progressBarWidgets = By.XPath("//*[@class = 'element-group'][4]//child::li[5]");

        public void ClickSlider()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'range-slider range-slider--primary']"))).Click();
        }
        public void MoveSlider(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'range-slider range-slider--primary']")))
                    .SendKeys(Keys.ArrowRight);
            }
        }
        public void WidgetsProgressBar()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(progressBarWidgets)).Click();
        }
    }
}
