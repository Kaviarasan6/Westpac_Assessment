using System;
using TechTalk.SpecFlow;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I open the browser and navigate to the url")]
        public void GivenIOpenTheBrowserAndNavigateToTheUrl()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I open browser and navigate to the url")]
        public void GivenIOpenBrowserAndNavigateToTheUrl()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter login credentials and click login button")]
        public void WhenIEnterLoginCredentialsAndClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Logout button")]
        public void WhenIClickOnLogoutButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I validate successfull login")]
        public void ThenIValidateSuccessfullLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be successfully logged out from the application")]
        public void ThenIShouldBeSuccessfullyLoggedOutFromTheApplication()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
