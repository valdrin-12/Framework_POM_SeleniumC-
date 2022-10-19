using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdNunit.Pages
{
    public class HomePage
    {
        // home page
        public HomePage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }

        //create account
        public IWebDriver Driver { get; }
        public IWebElement lnkSignIn => Driver.FindElement(By.LinkText("Sign in"));
        IWebElement txtEMAIL=> Driver.FindElement(By.Name("email_create"));
        IWebElement btnCreate => Driver.FindElement(By.Id("SubmitCreate"));
        // IWebElement btnSearch => Driver.FindElement(By.Name("submit_search"));

        // Login with valid account

        
        IWebElement txtemailSignIn => Driver.FindElement(By.Name("email"));

        IWebElement txtPassword => Driver.FindElement(By.XPath("//*[@id=\"passwd\"]"));

        IWebElement btnSignIn => Driver.FindElement(By.XPath("//*[@id=\"SubmitLogin\"]"));



        //*[@id="SubmitLogin"]



        public void ClickLogin() => lnkSignIn.Click();
        //public bool BtnCreate() => btnCreate.Displayed;
        public void BtnSendKeys() => txtEMAIL.SendKeys("valdrin_q12@hotmmail.com");

        public void txtsendKeys() => txtemailSignIn.SendKeys("valdrin_q12@hotmmail.com");

        public void txtsendKeys2() => txtPassword.SendKeys("rtrtrryyr9");

        public void ClickCreate() => btnCreate.Submit();

        public void ClickSignIn() => btnSignIn.Submit();

    }
}
