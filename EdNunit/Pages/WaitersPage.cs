using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdNunit.Pages
{
    public class WaitersPage
    {
        public WaitersPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }



        IWebElement RadioBtn => Driver.FindElement(By.CssSelector("#account-creation_form > div:nth-child(1) > div.clearfix > div:nth-child(3) > label"));

        public void Waiters()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(18));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"center_column\"]/div/div[1]/ul/li[1]/a")));





        }
        public void Waiters2()
        {

            //waits for E2ETest
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));





        }

        public void Waiters3()
        {

            //waits for E2ETest
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(8));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("India")));
            Driver.FindElement(By.LinkText("India")).Click();




        }
       

    }
}
