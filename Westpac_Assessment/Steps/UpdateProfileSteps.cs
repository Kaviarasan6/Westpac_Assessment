using System;
using TechTalk.SpecFlow;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class UpdateProfileSteps
    {
        [Given(@"I login to the application using ""(.*)"" credentials")]
        public void GivenILoginToTheApplicationUsingCredentials(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter data to all fields")]
        public void GivenIEnterDataToAllFields()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter data to the password fields")]
        public void GivenIEnterDataToThePasswordFields()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The profile should be saved successfully")]
        public void ThenTheProfileShouldBeSavedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The password should be changed successfully")]
        public void ThenThePasswordShouldBeChangedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
