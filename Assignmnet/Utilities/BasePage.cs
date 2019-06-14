using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet.Utilities
{
    public class BasePage
    {
        public string Url = "https://www.expedia.co.in/";
       public string Weburl = "http://automationpractice.com/index.php";
        public static IWebDriver driver;

        public void InvokeDriver()
        {
            driver = new ChromeDriver(@"C:\Users\gauravrajpoot\source\repos\RestSharpAndExpedia\Assignmnet\Drivers");
            driver.Manage().Window.Maximize();
        }

        public void Expediainvoked()
        {
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void AutomationPractice()
        {
            driver.Navigate().GoToUrl(Weburl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void Quitdriver()
        {
            driver.Quit();
        }
    }

}
