using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AventStack.ExtentReports;
using Assignmnet.Utilities;

namespace Assignmnet.StepDefinationFile
{
  
    [Binding]
    public class CheckTheLoginFunctionalityOfAutomationPractice_ComSteps:BasePage
    {
        string Weburl = "http://automationpractice.com/index.php";

        [Given(@"I have navigated to the website")]
        public void GivenIHaveNavigatedToTheWebsite()
        {

                invokeDriver();
                driver.Navigate().GoToUrl(Weburl);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                string title = driver.Title;
                
           
        }
        
        [Given(@"click on login button")]
        public void GivenClickOnLoginButton()
        {
            driver.FindElement(By.XPath("//a[@class='login']")).Click();
        }
        
        [When(@"Pass the parameter")]
        public void WhenPassTheParameter()
        {
            driver.FindElement(By.XPath("//input[@id='email']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@id='passwd']")).Click();
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("gauravrajpoot.com");
            
            driver.FindElement(By.XPath("//p[@class='submit']//span[1]")).Click();
        }

        [When(@"Pass the parameters")]
        public void WhenPassTheParameters()
        {
            driver.FindElement(By.XPath("//input[@id='email']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("gaurav@gmail.com");
            driver.FindElement(By.XPath("//input[@id='passwd']")).Click();
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("");
            driver.FindElement(By.XPath("//p[@class='submit']//span[1]")).Click();

        }

        [When(@"Pass the Arguments")]
        public void WhenPassTheArguments()
        {
            driver.FindElement(By.XPath("//input[@id='email']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("gaurav");
            driver.FindElement(By.XPath("//input[@id='passwd']")).Click();
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("rajpoot");            driver.FindElement(By.XPath("//p[@class='submit']//span[1]")).Click();
            driver.FindElement(By.XPath("//p[@class='submit']//span[1]")).Click();


        }

        [When(@"No Argument is passed")]
        public void WhenNoArgumentIsPassed()
        {
            driver.FindElement(By.XPath("//input[@id='email']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@id='passwd']")).Click();
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("");
            driver.FindElement(By.XPath("//p[@class='submit']//span[1]")).Click();

        }

        [Then(@"Message is Displayed")]
        public void ThenMessageIsDisplayed()
        {
            Console.WriteLine("An email address required.");
        }
        
        [Then(@"Unsucessfull Message is displayed")]
        public void ThenUnsucessfullMessageIsDisplayed()
        {
            Console.WriteLine("Password is required.");
        }
        
        [Then(@"Unsucessfull Message is shown")]
        public void ThenUnsucessfullMessageIsShown()
        {
            Console.WriteLine("Invalid email address.");
        }
        
        [Then(@"Message is displayed accordingly")]
        public void ThenMessageIsDisplayedAccordingly()
        {
            Console.WriteLine("An email address required.");
        }


        [Then(@"Close th Browser")]
        public void ThenCloseThBrowser()
        {
            driver.Quit();
        }
    }

}
