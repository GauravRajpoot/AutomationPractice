using System;
using TechTalk.SpecFlow;

namespace Assignmnet....StepDefination
{
    [Binding]
    public class WeHaveToCheckProperFunctionalityOfWebsiteAsAUserSteps
    {
        [When(@"I register a new User with '(.*)' Username and '(.*)' Password")]
        public void WhenIRegisterANewUserWithUsernameAndPassword(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I abc  register a new User with '(.*)' User and '(.*)' Passcode")]
        public void WhenIAbcRegisterANewUserWithUserAndPasscode(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Registration is not sucessfull")]
        public void ThenRegistrationIsNotSucessfull()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Token is generated Sucessfuly")]
        public void ThenTokenIsGeneratedSucessfuly()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Sucessfull Registration is performed")]
        public void ThenSucessfullRegistrationIsPerformed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Token is generated")]
        public void ThenTokenIsGenerated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
