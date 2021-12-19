using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class _2_LoginSteps:Login
    {
        [Given(@"I enter login credentials (.*),(.*),(.*)")]
        public void GivenIEnterLoginCredentials(string data, string username, string password)
        {
            SignIn(data, username, password);
        }
        
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            LoginButton.Click();
            WaitHelpers.TurnOnWait();
        }
        
        [When(@"I click on Logout button")]
        public void WhenIClickOnLogoutButton()
        {
            LogoutButton.Click();
        }
        
        [Then(@"I should be successfully logged in (.*),(.*)")]
        public void ThenIShouldBeSuccessfullyLoggedIn(string data, string firstname)
        {
            LoginAssertion(data, firstname);
            Drivers.CloseBrowser();
        }
        
        [Then(@"I should be successfully logged out from the application")]
        public void ThenIShouldBeSuccessfullyLoggedOutFromTheApplication()
        {
            LogOutAssertion();
            Drivers.CloseBrowser();
        }
    }
}
