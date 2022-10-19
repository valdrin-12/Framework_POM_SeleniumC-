using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
//using WebDriverManager.DriverConfigs.Impl;

namespace EdNunit.Pages
{
    public class SauceHomePageDemo
    {
        IWebDriver driver;

        [SetUp]

        public void StartBrowser()

        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";



        }

        [Test]

        public void LogInSauce()

        {

            driver.FindElement(By.Name("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Name("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Name("login-button")).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();

            //*[@id="add-to-cart-sauce-labs-backpack"]










        }
    }
}

