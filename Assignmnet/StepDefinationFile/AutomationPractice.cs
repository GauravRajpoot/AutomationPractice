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
    public class CheckTheLoginFunctionalityOfAutomationPractice_ComSteps:AutomationPractice
    {

        BasePage chromedriver = new BasePage();

        [Given(@"I have navigated to the website")]
        public void GivenIHaveNavigatedToTheWebsite()
        {
            chromedriver.InvokeDriver();
            chromedriver.AutomationPractice();
           
        }
        
        [Given(@"click on login button")]
        public void GivenClickOnLoginButton()
        {
            Clickon(LoginButton);
        }
        /*
         In this we are passing empty email and valid password
         */
        [When(@"Pass the parameter")]
        public void WhenPassTheParameter()
        {
            Clickon(EmailInputField);
            Passkeys(EmailInputField, "");
            Clickon(PasswordInputFiled);
            Passkeys(PasswordInputFiled, "gauravrajpoot.com");
            Clickon(SubmitButton);
        }
        /*
        In this we are passing valid email and empty password
        */
        [When(@"Pass the parameters")]
        public void WhenPassTheParameters()
        {
            Clickon(EmailInputField);
            Passkeys(EmailInputField, "gaurav@gmail.com");
            Clickon(PasswordInputFiled);
            Passkeys(PasswordInputFiled, "");
            Clickon(SubmitButton);

        }
        /*
        In this we are passing invalid email and invalid password
        */
        [When(@"Pass the Arguments")]
        public void WhenPassTheArguments()
        {
            Clickon(EmailInputField);
            Passkeys(EmailInputField, "gaurav");
            Clickon(PasswordInputFiled);
            Passkeys(PasswordInputFiled, "rajpoot");
            Clickon(SubmitButton);


        }
        /*
        In this we are passing empty email and empty password
        */
        [When(@"No Argument is passed")]
        public void WhenNoArgumentIsPassed()
        {
            Clickon(EmailInputField);
            Passkeys(EmailInputField, "");
            Clickon(PasswordInputFiled);
            Passkeys(PasswordInputFiled, "");
            Clickon(SubmitButton);
        }

        /*
        Now we are printing on to the console the respective values
        */
        [Then(@"Message is Displayed")]
        public void ThenMessageIsDisplayed()
        {
            string message=driver.FindElement(By.XPath("//div/ol/li")).Text;

            Assert.AreEqual(message, "An email address required.");
        }
        
        [Then(@"Unsucessfull Message is displayed")]
        public void ThenUnsucessfullMessageIsDisplayed()
        {
            string message = driver.FindElement(By.XPath("//div/ol/li")).Text;
            Assert.AreEqual(message, "Password is required.");
        }
        
        [Then(@"Unsucessfull Message is shown")]
        public void ThenUnsucessfullMessageIsShown()
        {
            string message = driver.FindElement(By.XPath("//div/ol/li")).Text;
            Assert.AreEqual(message, "Invalid email address.");
           
        }
        
        [Then(@"Message is displayed accordingly")]
        public void ThenMessageIsDisplayedAccordingly()
        {
            string message = driver.FindElement(By.XPath("//div/ol/li")).Text;
            Assert.AreEqual(message, "An email address required.");
            
        }


        [Then(@"Close th Browser")]
        public void ThenCloseThBrowser()
        {
            chromedriver.Quitdriver();   
        }
    }

}
