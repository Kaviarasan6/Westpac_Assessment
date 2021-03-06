using System;
using TechTalk.SpecFlow;
using Westpac_Assessment.Base;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class RegistrationSteps:Registration
    {
        [Given(@"I Navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            BaseClass start = new BaseClass();
            start.Initialize();
        }
        
        [Given(@"I click on Register button")]
        public void GivenIClickOnRegisterButton()
        {
            RegButton.Click();
        }

        [Given(@"I fill registration details (.*), (.*), (.*), (.*), (.*)")]
        public void GivenIFillRegistrationDetails(string username, string firstname, string lastname, string password, string confirmPassword)
        {
            Register(username,firstname,lastname,password,confirmPassword);
        }

        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            RegisterButton.Click();
        }

        [Then(@"I should be registered successfully")]
        public void ThenIShouldBeRegisteredSuccessfully()
        {
            RegAssertion();
            Drivers.CloseBrowser();
        }
    }
}
