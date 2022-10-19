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
    public class Screenshots
    {
        public Screenshots(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }



        
        public void screenshots()
        {

            ITakesScreenshot screenshot = ((ITakesScreenshot)Driver);
            Screenshot ss = screenshot.GetScreenshot();
            string filepath = "D:\\sel\\";
            ss.SaveAsFile(filepath + "screenshot123" + ".png", ScreenshotImageFormat.Png);

        }
        //*[@id="login_form"]

        public void screenshotsHiglight()
        {

            //Highlight Web Elements Using JavascriptExecutor In Selenium WebDriver


            ITakesScreenshot screenshot = ((ITakesScreenshot)Driver);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            IWebElement emailText = Driver.FindElement(By.Name("email"));
            IWebElement password = Driver.FindElement(By.Name("passwd"));
            // password.SendKeys("wertyui");

            IWebElement errorMessage = Driver.FindElement(By.ClassName("alert-danger"));

            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;

           // jse.ExecuteScript("arguments[0].style.border='2px solid red'", emailText);
            Thread.Sleep(2000);
           // Screenshot ss1=screenshot.GetScreenshot();
            string filepath = "D:\\sel\\";
           // ss1.SaveAsFile(filepath + timestamp + ".png", ScreenshotImageFormat.Png);

            //Change the background color of the web element

            jse.ExecuteScript("arguments[0].setAttribute('style', 'border:2px solid red; background:red')", password);

            Screenshot ss2 = screenshot.GetScreenshot();

            ss2.SaveAsFile(filepath + timestamp + ".png", ScreenshotImageFormat.Png);

            // highligt error message

            jse.ExecuteScript("arguments[0].style.border='2px solid black'", errorMessage);
            Thread.Sleep(2000);
            Screenshot ss3 = screenshot.GetScreenshot();
           // string filepath = "D:\\sel\\";
            ss3.SaveAsFile(filepath + timestamp + ".png", ScreenshotImageFormat.Png);


            //*[@id="country"]
        }



        public void screenshotForE2ETest()
        {

            //Highlight Web Elements Using JavascriptExecutor In Selenium WebDriver


            ITakesScreenshot screenshot = ((ITakesScreenshot)Driver);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            IWebElement country = Driver.FindElement(By.XPath("//*[@id=\"country\"]"));
           

           

            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;

            jse.ExecuteScript("arguments[0].style.border='2px solid red'", country);
            Thread.Sleep(2000);
            Screenshot ss6=screenshot.GetScreenshot();
            string filepath = "D:\\sel\\";
            ss6.SaveAsFile(filepath + timestamp + ".png", ScreenshotImageFormat.Png);

           
        }





    }
}
