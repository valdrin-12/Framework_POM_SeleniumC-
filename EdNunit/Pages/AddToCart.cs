using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdNunit.Pages
{
    public class AddToCart
    {
        // home page
        public AddToCart(IWebDriver webdriver)
        {
            Driver = webdriver;
        }

        //create account
        public IWebDriver Driver { get; }
        //public IWebElement lnkSignIn => Driver.FindElement(By.LinkText("Sign in"));

      //  Driver.Manage().Window.Maximize();

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

          

        public void actionHover()
        {

            IWebElement element = Driver.FindElement(By.XPath("//*[@id=\"block_top_menu\"]/ ul/li[1]/a"));

            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();

            IWebElement EveningDress = Driver.FindElement(By.XPath("//*[@id=\"block_top_menu\"]/ ul/li[1]/ul/li[2]/ul/li[2]/a"));

            EveningDress.Click();


        }
        public void addTocart()
        {


            //*[@id="center_column"]/ul/li/div/div[1]/div/a[1]/img

            IWebElement element = Driver.FindElement(By.XPath("//*[@id=\"center_column\"]/ul/li/div/div[1]/div/a[1]/img"));

            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();

            IWebElement DressAdd = Driver.FindElement(By.XPath("//*[@id=\"center_column\"]/ ul/li/div/div[2]/div[2]/a[1]"));

            DressAdd.Click();

            IWebElement Proceedtocheckout = Driver.FindElement(By.XPath("//*[@id=\"layer_cart\"]/ div[1]/div[2]/div[4]/a"));
            Proceedtocheckout.Click();
            //*[@id="layer_cart"]/div[1]/div[2]/div[4]/a

            IWebElement IncreaseUnitofProduct = Driver.FindElement(By.XPath("//*[@id=\"product_4_16_0_754920\"]/ td[5]/input[2]"));
            IncreaseUnitofProduct.Clear();
            IncreaseUnitofProduct.SendKeys("6");

            IWebElement Proceedtocheckout1 = Driver.FindElement(By.XPath("//*[@id=\"center_column\"]/ p[2]/a[1]"));
            Proceedtocheckout1.Click();


            IWebElement Proceedtocheckout2 = Driver.FindElement(By.XPath("//*[@id=\"center_column\"]/ form/p/button"));
            Proceedtocheckout2.Click();
            Thread.Sleep(2000);
            IWebElement checkBoxAgree = Driver.FindElement(By.XPath("//*[@id=\"cgv\"]"));
            checkBoxAgree.Click();
            IWebElement Proceedtocheckout3 = Driver.FindElement(By.XPath("//*[@id=\"form\"]/p/button"));
            Proceedtocheckout3.Click();

            IWebElement choosePayment = Driver.FindElement(By.XPath("//*[@id=\"HOOK_PAYMENT\"]/ div[1]/div/p/a"));
            choosePayment.Click();

             //.....................................

           // IWebElement confirmOrder = Driver.FindElement(By.XPath("//*[@id=\"cart_navigation\"]/ button"));

           // confirmOrder.Click();


            //......................................



            //*[@id="HOOK_PAYMENT"]/div[1]/div/p/a



            //*[@id="cgv"]                           //*[@id="form"]/p/button

            //*[@id="form"]/p/button

        }

        public void addToWishList()
        {



            IWebElement element = Driver.FindElement(By.XPath("//*[@id=\"block_top_menu\"]/ ul/li[1]/a"));

            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();

            IWebElement SummerDress = Driver.FindElement(By.XPath("//*[@id=\"block_top_menu\"]/ ul/li[1]/ul/li[2]/ul/li[3]/a"));

            SummerDress.Click();

            IWebElement WomanDress = Driver.FindElement(By.XPath("//*[@id=\"center_column\"]/ ul/li[2]/div/div[1]/div/a[1]/img"));

            WomanDress.Click();

            IWebElement WishList = Driver.FindElement(By.XPath("//*[@id=\"wishlist_button\"]"));

            WishList.Click();

            

            
            

        }




    }
}