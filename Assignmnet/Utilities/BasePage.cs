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


        public static IWebDriver driver;

        public void invokeDriver()
        {
            driver = new ChromeDriver(@"C:\Users\gauravrajpoot\source\repos\RestSharpAndExpedia\Assignmnet\Drivers");
            driver.Manage().Window.Maximize();
        }
    }
}
