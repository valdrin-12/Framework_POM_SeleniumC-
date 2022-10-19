using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports.Reporter;

namespace EdNunit
{

    [TestFixture]
    public class SeleniumCSharp


    {
        ExtentReports extent = null;


        [OneTimeSetUp]
        public void ExttentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Lenovo\Desktop\selenium3\EdNunit\EdNunit\ExtentReports\SeleniumCSharp.html");
            extent.AttachReporter(htmlReporter);

        }

        [OneTimeTearDown]
        public void ExttentClose()
        {
            extent.Flush();
        }

        [Test]

        public void LogIn1()

        {
            IWebDriver driver = null;
            ExtentTest test;
            try
            {
                

                test = extent.CreateTest("LogIn1").Info("Test Started");
                driver = new ChromeDriver();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                test.Log(Status.Info, "chrome browser launched");

                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                driver.FindElement(By.Name("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Name("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Name("login-button")).Click();
                driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
                test.Log(Status.Info, "signin in your account");
                driver.Quit();

                test.Log(Status.Pass,"test 1 passed");


                //*[@id="add-to-cart-sauce-labs-backpack"]
            }
            catch (Exception e)
            {
                throw;

            }

            finally
            {
                if (driver !=null)
                {
                    driver.Quit();
                }
            }


            




        }



        [Test]

        public void LogIn2()

        {
            IWebDriver driver = null;
            ExtentTest test=null;
            try
            {


                test = extent.CreateTest("LogIn1").Info("Test Started");
                driver = new ChromeDriver();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                test.Log(Status.Info, "chrome browser launched");

                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                driver.FindElement(By.Name("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Name("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Name("login-button")).Click();
                driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
                test.Log(Status.Info, "signin in your account");
                driver.Quit();

                test.Log(Status.Pass, "test 1 passed");


                //*[@id="add-to-cart-sauce-labs-backpack"]
            }
            catch (Exception e)
            {

                test.Log(Status.Fail, e.ToString());
                throw;

            }

            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }







        }




    }



}
