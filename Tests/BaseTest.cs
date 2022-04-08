using System;
using DemoQa.Driver;
using DemoQa.Pages;
using DemoQa.Pages.Alerts;
using DemoQa.Pages.BookStore;
using DemoQa.Pages.ElementPage;
using DemoQa.Pages.Interactions;
using DemoQa.Pages.PracticeForm;
using DemoQa.Pages.Widgets;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQa.Tests
{
    public class BaseTest : SwitchDriver
    {
        public const string BROWSER = "fireFox";
        public const string URL = "https://demoqa.com/";
        public const int TIMEOUT = 20;

        public HomePage homePage;
        public TextBox textBox;
        public CheckBox checkBox;
        public RadioButton radioButton;
        public Webtables webtables;
        public Buttons buttons;
        public Links links;
        public BrokenLinks brokenLinks;
        public UploadDownload uploadDownload;
        public DynamicProperties dynamicProperties;
        public PracticeForm practiceForm;
        public BrowserWindows browserWindows;
        public Alerts alerts;
        public ModalDialogs modalDialogs;
        public Accordian accordian;
        public AutoComplete autoComplete;
        public DatePicker datePicker;
        public Slider slider;
        public ProgressBar progressBar;
        public Tabs tabs;
        public ToolTips toolTips;
        public Menu menu;
        public SelectMenu selectMenu;
        public Sortable sortable;
        public Selectable selectable;
        public Resizable resizable;
        public Droppable droppable;
        public Dragabble dragabble;
        public Login login;
        public Register register;
        public BookStore bookStore;
        public Profile profile;

        public WebDriverWait wait;
        public Actions actions;

        public void Scroll(int vertical, int horizontal)
        {
            IJavaScriptExecutor js = driver;
            js.ExecuteScript($"window.scrollBy({horizontal},{vertical})");
        }

        public void Zoom(double zoom)
        {
            IJavaScriptExecutor executor = driver;
            executor.ExecuteScript($"document.body.style.zoom = '{zoom}'");
        }
        public void SwitchTab(int tab)
        {
            driver.SwitchTo().Window(driver.WindowHandles[tab]);
        }

        public void GoBack()
        {
            driver.Navigate().Back();
        }

        public void PressAlert()
        {
            wait.Until(ExpectedConditions.AlertIsPresent());
            driver.SwitchTo().Alert().Accept();
        }
        public void TextAlert(string alert)
        {
            wait.Until(ExpectedConditions.AlertIsPresent());
            driver.SwitchTo().Alert().SendKeys(alert);
        }
        public void Refresh()
        {
            driver.Navigate().Refresh();
        }
        public void HideElements()
        {
            IJavaScriptExecutor executor = driver;
            executor.ExecuteScript("arguments[0].style.visibility='hidden'",
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id = 'app']//child::footer"))));
        }
        public void CloseAds()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='close-fixedban']"))).Click();
        }

        public void DefaultFrame()
        {
            driver.SwitchTo().DefaultContent();
        }

        [SetUp]
        public void SetUp()
        {
            Switch(BROWSER);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TIMEOUT));

            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();

            actions = new Actions(driver);

            homePage = new HomePage(driver, wait);
            textBox = new TextBox(driver, wait);
            checkBox = new CheckBox(driver, wait);
            radioButton = new RadioButton(driver, wait);
            webtables = new Webtables(driver, wait);
            buttons = new Buttons(driver, wait, actions);
            links = new Links(driver, wait);
            brokenLinks = new BrokenLinks(driver, wait);
            uploadDownload = new UploadDownload(driver, wait);
            dynamicProperties = new DynamicProperties(driver, wait);
            practiceForm = new PracticeForm(driver, wait);
            browserWindows = new BrowserWindows(driver, wait);
            alerts = new Alerts(driver, wait);
            modalDialogs = new ModalDialogs(driver, wait);
            accordian = new Accordian(driver, wait);
            autoComplete = new AutoComplete(driver, wait);
            datePicker = new DatePicker(driver, wait);
            slider = new Slider(driver, wait);
            progressBar = new ProgressBar(driver, wait);
            tabs = new Tabs(driver, wait);
            toolTips = new ToolTips(driver, wait);
            menu = new Menu(driver, wait);
            selectMenu = new SelectMenu(driver, wait, actions);
            sortable = new Sortable(driver, wait, actions);
            selectable = new Selectable(driver, wait);
            resizable = new Resizable(driver, wait, actions);
            droppable = new Droppable(driver, wait, actions);
            dragabble = new Dragabble(driver, wait, actions);
            login = new Login(driver, wait);
            register = new Register(driver, wait);
            bookStore = new BookStore(driver, wait);
            profile = new Profile(driver, wait);
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}
