using EdNunit.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdNunit.Tests
{
    class Login
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [Test]
        public void Login1()
        {

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            HomePage homePage = new(webDriver);
            homePage.ClickLogin();
            homePage.txtsendKeys();
            homePage.txtsendKeys2();
            homePage.ClickSignIn();

            AddToCart addcart = new(webDriver);
            addcart.actionHover();
            addcart.addTocart();
            // homePage.ClickCreate();
            //LoginPage loginPage = new(webDriver);

            LoginPage loginPage = new(webDriver);
            //loginPage.DeleteProducts();




            Console.WriteLine("executing 3");
            // Assert.That(homePage.BtnCreate, Is.True);
            // webDriver.Quit();

            ITakesScreenshot screenshot = ((ITakesScreenshot)webDriver);
            Screenshot ss=screenshot.GetScreenshot();
            string filepath = "D:\\sel\\";
            ss.SaveAsFile(filepath + "screenshot"+".png",ScreenshotImageFormat.Png);

        }
        [Test]
        public void LoginExplicitWait()
        {

            // webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            HomePage homePage = new(webDriver);
            homePage.ClickLogin();
            homePage.txtsendKeys();
            homePage.txtsendKeys2();
            homePage.ClickSignIn();

           // WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(18));
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"center_column\"]/div[1]")));

             WaitersPage waitUntil = new WaitersPage(webDriver);

            waitUntil.Waiters();
            //waitUntil.Waiters();

            Console.WriteLine("executing 6");
            // Assert.That(homePage.BtnCreate, Is.True);
            //webDriver.Close();
            LoginPage log = new LoginPage(webDriver);
            log.PrintingProducts();

            Screenshots screen=new (webDriver);
            screen.screenshots();
        }

        [Test]
        public void LoginScreenshot()
        {
            //Highlight Web Elements Using JavascriptExecutor In Selenium WebDriver



            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            webDriver.Manage().Window.Maximize();

            HomePage homePage = new(webDriver);
            homePage.ClickLogin();
            homePage.txtsendKeys();
           // homePage.txtsendKeys2();
            //homePage.ClickSignIn();

            // WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(18));
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"center_column\"]/div[1]")));

           

            Screenshots screen = new(webDriver);
            screen.screenshotsHiglight();
        }

        [Test]
        public void LoginWithIncorrectPassword()
        {
            //Highlight Web Elements Using JavascriptExecutor In Selenium WebDriver



            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            webDriver.Manage().Window.Maximize();

            HomePage homePage = new(webDriver);
            homePage.ClickLogin();
            homePage.txtsendKeys();

            //incoreect password
            IWebElement password = webDriver.FindElement(By.Name("passwd"));
            password.SendKeys("wertyui");
            // homePage.txtsendKeys2();
            homePage.ClickSignIn();

            // WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(18));
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"center_column\"]/div[1]")));



            Screenshots screen = new(webDriver);
            screen.screenshotsHiglight();
        }



    }
}
