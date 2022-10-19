using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdNunit.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }



        IWebElement RadioBtn => Driver.FindElement(By.CssSelector("#account-creation_form > div:nth-child(1) > div.clearfix > div:nth-child(3) > label"));

        IWebElement txtName => Driver.FindElement(By.XPath("//*[@id=\"customer_firstname\"]"));
        IWebElement txtLastName => Driver.FindElement(By.XPath("//*[@id=\"customer_lastname\"]"));
        //IWebElement txtEmail => Driver.FindElement(By.Name("email"));
        IWebElement txtPassword => Driver.FindElement(By.XPath("//*[@id=\"passwd\"]"));

        IWebElement checkboxnewsletter => Driver.FindElement(By.Id("uniform-newsletter"));
        //IWebElement checkboxUniform => Driver.FindElement(By.XPath("uniform-optin"));
        IWebElement txtNameF => Driver.FindElement(By.XPath("//*[@id=\"firstname\"]"));
        IWebElement txtNameL => Driver.FindElement(By.XPath("//*[@id=\"lastname\"]"));  //*[@id="company"]

        IWebElement txtCompany => Driver.FindElement(By.XPath("//*[@id=\"company\"]"));
        IWebElement txtAddress => Driver.FindElement(By.XPath("//*[@id=\"address1\"]")); //*[@id="address2"]
        IWebElement txtAddress2 => Driver.FindElement(By.XPath("//*[@id=\"address2\"]")); //*[@id="city"]
        IWebElement txtCity => Driver.FindElement(By.XPath("//*[@id=\"city\"]"));
        IWebElement txtPstalCode => Driver.FindElement(By.XPath("//*[@id=\"postcode\"]"));  //*[@id="other"]

        IWebElement txtAdditionaltext => Driver.FindElement(By.XPath("//*[@id=\"other\"]"));  //*[@id="phone"]
        IWebElement txtPhone => Driver.FindElement(By.XPath("//*[@id=\"phone\"]"));  //*[@id="phone_mobile"]
        IWebElement txtMobilePhone => Driver.FindElement(By.XPath("//*[@id=\"phone_mobile\"]"));  //*[@id="alias"]
        IWebElement txtAliasAddress => Driver.FindElement(By.XPath("//*[@id=\"alias\"]"));
        IWebElement btnRegister => Driver.FindElement(By.XPath("//*[@id=\"submitAccount\"]"));

      // IWebElement delete=> SelectElement(Driver.FindElement(By.XPath("//*[@id=\"4_16_0_754920\"]")));














        // IWebElement DropdownDay => Driver.FindElement(By.Name("days"));
        // IWebElement Dropmonths => Driver.FindElement(By.Name("months"));
        // IWebElement Dropyears => Driver.FindElement(By.Name("years"));

        public void Login(string userName, string lastName, string 
            password,string nameF ,string Lname,string company,string address,
            string address2,string city,string postalcode,string additionalText,string phone,string phoneMobile,string aliasAddres)
        {

            //RadioBtn.Click();

            txtName.SendKeys(userName);
            txtLastName.SendKeys(lastName); 
            txtPassword.SendKeys(password);
            checkboxnewsletter.Click();
            //checkboxUniform.Click();
            txtNameF.Clear();
            txtNameF.SendKeys(nameF);
            txtNameL.Clear();
            txtNameL.SendKeys(Lname);
            txtCompany.SendKeys(company);
            txtAddress.SendKeys(address);
            txtAddress2.SendKeys(address2);
            txtCity.SendKeys(city);
            txtPstalCode.SendKeys(postalcode);
            txtAdditionaltext.SendKeys(additionalText);
            txtPhone.SendKeys(phone);
            txtMobilePhone.SendKeys(phoneMobile);
            txtAliasAddress.Clear();
            txtAliasAddress.SendKeys(aliasAddres);
            // btnLogin.Submit();



        }

        public void DropDownSelectState()
        {

            SelectElement dropDownState = new SelectElement(Driver.FindElement(By.XPath("//*[@id=\"id_state\"]")));
            dropDownState.SelectByValue("4");                              //*[@id="id_state"]


        }

        public void DropDownSelectGender()
        {

            RadioBtn.Click();


        }
        public void DropDownSelectionDays()
        {

            SelectElement dropDown = new SelectElement(Driver.FindElement(By.Name("days")));
            dropDown.SelectByValue("4");


        }

        public void DropDownSelectionMonth()
        {

            SelectElement dropDown = new SelectElement(Driver.FindElement(By.Name("months")));
            dropDown.SelectByValue("8");


        }

        public void DropDownSelectionYears()
        {

            SelectElement dropDown = new SelectElement(Driver.FindElement(By.Name("years")));

            dropDown.SelectByValue("1990");


        }
        public void Register()
        {
            btnRegister.Submit();



        }
        public void DeleteProducts()
        {
            IWebElement elements = Driver.FindElement(By.XPath("//*[@id=\"header\"]/ div[3]/div/div/div[3]/div/a"));

            Actions action = new Actions(Driver);
            action.MoveToElement(elements).Perform();

            elements.Click();


            IWebElement deleteP= Driver.FindElement(By.XPath("//*[@id=\"4_16_0_754920\"]"));

            //IWebElement deleteP = Driver.(FindElement.By.XPath("//*[@id=\"4_16_0_754920\"]")));
            deleteP.Click();
                                      


        }
        public void PrintingProducts()
        {
            IWebElement element = Driver.FindElement(By.XPath("//*[@id=\"block_top_menu\"]/ ul/li[1]/a"));

            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();

            IWebElement SummerDress = Driver.FindElement(By.XPath("//*[@id=\"block_top_menu\"]/ ul/li[1]/ul/li[2]/ul/li[3]/a"));

            SummerDress.Click();

            IList<IWebElement> elements = Driver.FindElements(By.CssSelector("#center_column > ul > li.ajax_block_product.col-xs-12.col-sm-6.col-md-4.first-in-line.last-line.first-item-of-tablet-line.first-item-of-mobile-line.last-mobile-line > div > div.right-block > h5"));
            foreach (IWebElement element2 in elements)
            {
                Console.WriteLine(element2.Text);
            }


        }
       





    }
}
