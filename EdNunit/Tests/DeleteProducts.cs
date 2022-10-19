using EdNunit.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdNunit.Tests
{
    class DeleteProducts
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [Test]
        public void deletePro()
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
            loginPage.DeleteProducts();




            Console.WriteLine("executing 3");
            // Assert.That(homePage.BtnCreate, Is.True);

        }
        [Test]
        public void Login12()
        {

           // webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            HomePage homePage = new(webDriver);
            homePage.ClickLogin();
            homePage.txtsendKeys();
            homePage.txtsendKeys2();
            homePage.ClickSignIn();

            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(18));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"center_column\"]/div[1]")));

            //  WaitersPage waitUntil = new WaitersPage(webDriver);

            //waitUntil.Waiters();

            Console.WriteLine("executing 6");
            // Assert.That(homePage.BtnCreate, Is.True);
            //webDriver.Close();



        }
        [Test]
        public void PrintingProductNAmes2()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://www.amazon.com/b?node=24230809011&ref=dlx_deals_gd_dcl_img_0_0de5fc54_dt_sl15_b4");
            IList<IWebElement> elements = driver.FindElements(By.CssSelector("#a-page > div.a-container > div.a-row.apb-browse-two-col-center-pad > div.a-column.a-span12.aok-float-right.apb-browse-col-pad-left.apb-browse-two-col-center-margin-right > div:nth-child(2) > div"));
            foreach (IWebElement element in elements)
            {
                Console.WriteLine(element.Text);
            }


        }
    }
}
