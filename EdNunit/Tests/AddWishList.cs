using EdNunit.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdNunit.Tests
{
    class AddWishList
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [Test]
        public void Add()
        {

           webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            HomePage homePage = new(webDriver);
            homePage.ClickLogin();
            homePage.txtsendKeys();
            homePage.txtsendKeys2();
            homePage.ClickSignIn();
            AddToCart addcart = new(webDriver);
            addcart.addToWishList();


            Console.WriteLine("executing 4");
            // Assert.That(homePage.BtnCreate, Is.True);

        }


    }
}

