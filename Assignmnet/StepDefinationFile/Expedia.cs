using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using Assignmnet.Utilities;
namespace Assignmnet.StepDefinationFile
{
    [Binding]
    public class CheckingTheFunctionalityOfFlightBookingAtExpedia_ComSteps:ExpediaUtilities
    {
       [Given(@"Open Chrome WebBrowser")]
        public void GivenOpenChromeWebBrowser()
        {
            BasePage webintializer = new BasePage();
            webintializer.invokeDriver();
        }
        
        [When(@"Report are generate")]
        public void WhenReportAreGenerate()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"Pass the URL of Website")]
        public void ThenPassTheURLOfWebsite()
        {
            Expediainvoked();
        }
        
        [Then(@"Click on flight tab")]
        public void ThenClickOnFlightTab()
        {
            Clickonicon(flighticon);
        }
        
        [Then(@"Choose MultiCity OPtion")]
        public void ThenChooseMultiCityOPtion()
        {
            Clickonicon(multicity);
        }
        
        [Then(@"Pass Source and Destination Place")]
        public void ThenPassSourceAndDestinationPlace()
        {

            Clickonicon(sourcefirst);
            Passkeys(sourcefirst, "Delhi, India");
            Clickonicon(destinationfirst);
            Passkeys(destinationfirst, "Mumbai, India");
            
        }
        
        [Then(@"Choose DateOfJourney and Choose Number of Passengers")]
        public void ThenChooseDateOfJourneyAndChooseNumberOfPassengers()
        {
            
            Clickonicon(Date);
            Passkeys(Date, "19/07/2019");
            IncrementingPassengerCount();

        }

        [Then(@"Again choose Source and Destination for second time")]
        public void ThenAgainChooseSourceAndDestinationForSecondTime()
        {
            Clickonicon(sourcesecond);
            Passkeys(sourcesecond, "Mumbai, India");
            Clickonicon(destinationsecond);
            Passkeys(destinationsecond, "Chennai, India");
           
        }

        [Then(@"Choose DateOfJourney")]
        public void ThenChooseDateOfJourney()
        {
            Clickonicon(Datesecond);
            Passkeys(Datesecond, "21/07/2019");

        }
        
        [Then(@"Again choose Source  and Destination for third time")]
        public void ThenAgainChooseSourceAndDestinationForThirdTime()
        {

            Clickonicon(addmoreflight);
            Clickonicon(sourcethird);
            Passkeys(sourcethird, "Chennai, India");
            Clickonicon(destinationthird);
            Passkeys(destinationthird, "Delhi, India");
        }

        [Then(@"Choose DateOfJourney  for return")]
        public void ThenChooseDateOfJourneyForReturn()
        {
            Clickonicon(Datethird);
            Passkeys(Datethird, "23/07/2019");
        }

        [Then(@"Click On the Search BUtton")]
        public void ThenClickOnTheSearchBUtton()
        {
            Clickonicon(searchbutton);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Then(@"Display the successfull message")]
        public void ThenDisplayTheSuccessfullMessage()
        {
           // ScenarioContext.Current.Pending();
        }
        [When(@"ENsuring correct information of all three flights")]
        public void WhenENsuringCorrectInformationOfAllThreeFlights()
        {
          // bool correctinfo= driver.FindElement(By.XPath("//form[@id='gcw-flights-form-hp-flight']//button[@class='btn-primary btn-action gcw-submit']")).Displayed;
           // Assert.IsTrue(correctinfo);
        }

        [Then(@"Ensuring the correct amount per person")]
        public void ThenEnsuringTheCorrectAmountPerPerson()
        {
            //string amountPerPerson = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[7]/section[1]/div[1]/div[10]/ul[1]/li[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/span[1]")).Text;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          string amount1=  driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[7]/section[1]/div[1]/div[10]/ul[1]/li[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/span[1]")).Text;
            string amount2 = amount1.Substring(2);
            string[] amt = amount2.Split(',');
            string totalAmt="";
            foreach(var item in amt)
            {
                totalAmt = totalAmt + item;
            }
            totalAmt = totalAmt.Split('.')[0];
            int amount = Int32.Parse(totalAmt);
            int PerPersonAmount = amount * 4;

            driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[7]/section[1]/div[1]/div[10]/ul[1]/li[1]/div[1]/div[1]/div[2]/div[1]/div[2]/button[1]")).Click();
            
            string Finalamount = driver.FindElement(By.XPath("//span[@class='packagePriceTotal']")).Text;

            string Finalamount1 = Finalamount.Substring(2);
            string[] finalamount2 = Finalamount1.Split(',');
            string totalamount = "";
            foreach(var item in finalamount2)
            {
                totalamount = totalamount + item;
            }
            totalamount = totalamount.Split('.')[0];
            int FinalElement = Int32.Parse(totalamount);


            if(PerPersonAmount==FinalElement)
            {
                Console.WriteLine("Total Amount is matched");
            }
        }
        [Then(@"dismis browser")]
        public void ThenDismisBrowser()
        {
           driver.Quit();
        }
    }
}
