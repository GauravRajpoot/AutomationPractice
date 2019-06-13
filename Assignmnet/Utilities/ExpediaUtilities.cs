using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet.Utilities
{
   public class ExpediaUtilities:BasePage
    {

        public string flighticon = "//*[@id='tab-flight-tab-hp']";
        public string multicity = "//*[@id='flight-type-multi-dest-label-hp-flight']";   
        public string sourcefirst = "//*[@id='flight-origin-hp-flight']";
        public string destinationfirst = "//*[@id='flight-destination-hp-flight']";
        public string Date = "//*[@id='flight-departing-single-hp-flight']";
        public string sourcesecond = "//input[@id='flight-2-origin-hp-flight']";
        public string destinationsecond = "//input[@id='flight-2-destination-hp-flight']";
        public string Datesecond = "//input[@id='flight-2-departing-hp-flight']";
        public string addmoreflight = "//a[@id='add-flight-leg-hp-flight']";
        public string sourcethird = "//input[@id='flight-3-origin-hp-flight']";
        public string destinationthird = "//input[@id='flight-3-destination-hp-flight']";
        public string Datethird = "//input[@id='flight-3-departing-hp-flight']";
        public string searchbutton = "//form[@id='gcw-flights-form-hp-flight']//button[@class='btn-primary btn-action gcw-submit']";


        public void Clickonicon(string xpathvalue)
        {
            driver.FindElement(By.XPath(xpathvalue)).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public void Passkeys(string xpathvalues,string place)
        {
            driver.FindElement(By.XPath(xpathvalues)).SendKeys(place);
        }
        public void IncrementingPassengerCount()
        {
            driver.FindElement(By.XPath("/html/body/meso-native-marquee/section/div/div/div[1]/section/div[1]/div[2]/div[2]/section[1]/form/fieldset[2]/div/div[4]/div/div/ul/li/button")).Click();

            for (int i = 1; i <= 3; i++)

            {

                driver.FindElement(By.XPath("//body[contains(@class,'wrap cf aoa-enabled')]/meso-native-marquee/section[@id='WizardHero']/div[@id='hero-banner']/div[contains(@class,'hero-banner-gradient native-marquee')]/div[contains(@class,'cols-row hero-banner-inner')]/section[@id='wizardSection']/div[contains(@class,'hero-banner-box siteId-27 cf hideClassicDcol')]/div[@id='wizard-tabs']/div[contains(@class,'tabs-container col')]/section[@id='section-flight-tab-hp']/form[@id='gcw-flights-form-hp-flight']/fieldset[contains(@class,'room-data')]/div[contains(@class,'cols-nested')]/div[contains(@class,'ab25184-traveler-wrapper-flight available-for-flights gcw-clear-both')]/div[@id='traveler-selector-hp-flight']/div[contains(@class,'menu-bar gcw-travel-selector-wrapper')]/ul[contains(@class,'menu-bar-inner')]/li[contains(@class,'open')]/div[contains(@class,'menu sticky gcw-menu')]/div[contains(@class,'menu-main')]/div[contains(@class,'traveler-selector-sinlge-room-data traveler-selector-room-data')]/div[contains(@class,'uitk-grid step-input-outside gcw-component gcw-component-step-input gcw-step-input gcw-component-initialized')]/div[contains(@class,'uitk-col all-col-shrink')]/button[contains(@class,'uitk-step-input-button uitk-step-input-plus')]/span[contains(@class,'uitk-icon')]/*[1]")).Click();

            }
        }
    }
}
