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
    public class CheckingTheFunctionalityOfFlightBookingAtExpedia_ComSteps:BasePage
    {
        public string Url = "https://www.expedia.co.in/";



        [Given(@"Open Chrome WebBrowser")]
        public void GivenOpenChromeWebBrowser()
        {
            invokeDriver();
        }
        
        [When(@"Report are generate")]
        public void WhenReportAreGenerate()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"Pass the URL of Website")]
        public void ThenPassTheURLOfWebsite()
        {
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Then(@"Click on flight tab")]
        public void ThenClickOnFlightTab()
        {
            driver.FindElement(By.XPath("//*[@id='tab-flight-tab-hp']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        
        [Then(@"Choose MultiCity OPtion")]
        public void ThenChooseMultiCityOPtion()
        {
            driver.FindElement(By.XPath("//*[@id='flight-type-multi-dest-label-hp-flight']")).Click();
        }
        
        [Then(@"Pass Source and Destination Place")]
        public void ThenPassSourceAndDestinationPlace()
        {
            driver.FindElement(By.XPath("//*[@id='flight-origin-hp-flight']")).Click();

            driver.FindElement(By.XPath("//*[@id='flight-origin-hp-flight']")).SendKeys("Delhi, India");

            driver.FindElement(By.XPath("//*[@id='flight-destination-hp-flight']")).Click();

            driver.FindElement(By.XPath("//*[@id='flight-destination-hp-flight']")).SendKeys("Mumbai, India");
        }
        
        [Then(@"Choose DateOfJourney and Choose Number of Passengers")]
        public void ThenChooseDateOfJourneyAndChooseNumberOfPassengers()
        {
            driver.FindElement(By.XPath("//*[@id='flight-departing-single-hp-flight']")).Click();

            driver.FindElement(By.XPath("//*[@id='flight-departing-single-hp-flight']")).SendKeys("19/07/2019");


            driver.FindElement(By.XPath("/html/body/meso-native-marquee/section/div/div/div[1]/section/div[1]/div[2]/div[2]/section[1]/form/fieldset[2]/div/div[4]/div/div/ul/li/button")).Click();

            for (int i = 1; i <= 3; i++)

            {

                driver.FindElement(By.XPath("//body[contains(@class,'wrap cf aoa-enabled')]/meso-native-marquee/section[@id='WizardHero']/div[@id='hero-banner']/div[contains(@class,'hero-banner-gradient native-marquee')]/div[contains(@class,'cols-row hero-banner-inner')]/section[@id='wizardSection']/div[contains(@class,'hero-banner-box siteId-27 cf hideClassicDcol')]/div[@id='wizard-tabs']/div[contains(@class,'tabs-container col')]/section[@id='section-flight-tab-hp']/form[@id='gcw-flights-form-hp-flight']/fieldset[contains(@class,'room-data')]/div[contains(@class,'cols-nested')]/div[contains(@class,'ab25184-traveler-wrapper-flight available-for-flights gcw-clear-both')]/div[@id='traveler-selector-hp-flight']/div[contains(@class,'menu-bar gcw-travel-selector-wrapper')]/ul[contains(@class,'menu-bar-inner')]/li[contains(@class,'open')]/div[contains(@class,'menu sticky gcw-menu')]/div[contains(@class,'menu-main')]/div[contains(@class,'traveler-selector-sinlge-room-data traveler-selector-room-data')]/div[contains(@class,'uitk-grid step-input-outside gcw-component gcw-component-step-input gcw-step-input gcw-component-initialized')]/div[contains(@class,'uitk-col all-col-shrink')]/button[contains(@class,'uitk-step-input-button uitk-step-input-plus')]/span[contains(@class,'uitk-icon')]/*[1]")).Click();

            }

        }

        [Then(@"Again choose Source and Destination for second time")]
        public void ThenAgainChooseSourceAndDestinationForSecondTime()
        {
            driver.FindElement(By.XPath("//input[@id='flight-2-origin-hp-flight']")).Click();

            driver.FindElement(By.XPath("//input[@id='flight-2-origin-hp-flight']")).SendKeys("Mumbai, India");

            driver.FindElement(By.XPath("//input[@id='flight-2-destination-hp-flight']")).Click();

            driver.FindElement(By.XPath("//input[@id='flight-2-destination-hp-flight']")).SendKeys("Chennai, India");

        }

        [Then(@"Choose DateOfJourney")]
        public void ThenChooseDateOfJourney()
        {
            driver.FindElement(By.XPath("//input[@id='flight-2-departing-hp-flight']")).Click();

            driver.FindElement(By.XPath("//input[@id='flight-2-departing-hp-flight']")).SendKeys("21/07/2019");
        }
        
        [Then(@"Again choose Source  and Destination for third time")]
        public void ThenAgainChooseSourceAndDestinationForThirdTime()
        {
            driver.FindElement(By.XPath("//a[@id='add-flight-leg-hp-flight']")).Click();

            driver.FindElement(By.XPath("//input[@id='flight-3-origin-hp-flight']")).Click();

            driver.FindElement(By.XPath("//input[@id='flight-3-origin-hp-flight']")).SendKeys("Chennai, India");

            driver.FindElement(By.XPath("//input[@id='flight-3-destination-hp-flight']")).Click();

            driver.FindElement(By.XPath("//input[@id='flight-3-destination-hp-flight']")).SendKeys("Delhi, India");

        }

        [Then(@"Choose DateOfJourney  for return")]
        public void ThenChooseDateOfJourneyForReturn()
        {
            driver.FindElement(By.XPath("//input[@id='flight-3-departing-hp-flight']")).Click();

            driver.FindElement(By.XPath("//input[@id='flight-3-departing-hp-flight']")).SendKeys("23/07/2019");

        }

        [Then(@"Click On the Search BUtton")]
        public void ThenClickOnTheSearchBUtton()
        {
            driver.FindElement(By.XPath("//form[@id='gcw-flights-form-hp-flight']//button[@class='btn-primary btn-action gcw-submit']")).Click();

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
                driver.Quit();
            }
        }
        [Then(@"dismis browser")]
        public void ThenDismisBrowser()
        {
           //river.Quit();
        }
    }
}
