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
    class CreateAcc
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [Test]
        public void Login()
        {

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            HomePage homePage = new(webDriver);

            homePage.ClickLogin();
            homePage.BtnSendKeys();
            homePage.ClickCreate();
            //LoginPage loginPage = new(webDriver);


            LoginPage loginPage = new(webDriver);
           loginPage.DropDownSelectGender();

            loginPage.Login("valdrin", "qerimi", "rtrtrryyr9", "VALDRIN","qerimi","VAG","gjilan",
                "prishtine","New York", "10000","USER i RI","038 123345","04441234","Frankfurt");

            loginPage.DropDownSelectionDays();
            loginPage.DropDownSelectionMonth();
            loginPage.DropDownSelectionYears();
            loginPage.DropDownSelectState();
            loginPage.Register();


            

            Console.WriteLine("executing second");
         // Assert.That(homePage.BtnCreate, Is.True);

        }


    }
}
