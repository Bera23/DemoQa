using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace DemoQa.Driver
{
    public class SwitchDriver
    {
        public WebDriver driver;
        public void Switch(string browser)
        {
            {
                switch (browser)
                {
                    case "chrome":
                        driver = new ChromeDriver();
                        break;
                    case "fireFox":
                        driver = new FirefoxDriver();
                        break;
                    case "edge":
                        driver = new EdgeDriver();
                        break;
                    case "internetExplorer":
                        driver = new InternetExplorerDriver();
                        break;
                }

            }
        }
    }
}
