using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet.Utilities
{
    public class AutomationPractice:BasePage
    {
        public string LoginButton = "//a[@class='login']";
        public string EmailInputField = "//input[@id='email']";
        public string PasswordInputFiled = "//input[@id='passwd']";
        public string SubmitButton = "//p[@class='submit']//span[1]";
        public void Clickon(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
        public void Passkeys(string xpath,string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }
    }
}
