using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EdNunit
{
    public class Tests1
    {

        public IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("setup");
            webDriver = new ChromeDriver();
            
        }

        [Test]
        public void Test1()
        {
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            IWebElement lnkSignIn = webDriver.FindElement(By.LinkText("Sign in"));

            lnkSignIn.Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            var txtEmail = webDriver.FindElement(By.Name("email_create"));
            Assert.That(txtEmail.Displayed, Is.True);

            txtEmail.SendKeys("valdrin12@gmail.com");

            IWebElement createAccount = webDriver.FindElement(By.Id("SubmitCreate"));

            createAccount.Click();



            IWebElement RadioBtn = webDriver.FindElement(By.CssSelector("#account-creation_form > div:nth-child(1) > div.clearfix > div:nth-child(3) > label"));
            RadioBtn.Click();
            IWebElement txtName = webDriver.FindElement(By.Id("customer_firstname"));
            txtName.SendKeys("valdrin");
            IWebElement txtLastName = webDriver.FindElement(By.Id("customer_lastname"));
            txtLastName.SendKeys("qerimi");
            //IWebElement txtEmail => Driver.FindElement(By.Name("email"));
            IWebElement txtPassword = webDriver.FindElement(By.Id("passwd"));
            txtPassword.SendKeys("ghhhhhhhhhhh");







            Console.WriteLine("test1");

            Assert.Pass();
        }
    }
}