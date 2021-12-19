using System;
using TechTalk.SpecFlow;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class UpdateProfileSteps : Profile
    {
        [Given(@"I login to the application using valid credentials (.*),(.*),(.*)")]
        public void GivenILoginToTheApplicationUsingValidCredentials(string data, string username, string password)
        {
            Login login = new Login();
            login.SignIn(data, username, password);
            login.LoginButton.Click();
        }


        [Given(@"I enter data to all fields (.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
        public void GivenIEnterDataToAllFields(string firstname, string lastname, string gender, string age, string address, string phone, string hobby)
        {
            UpdateProfile(firstname, lastname, gender, age, address, phone, hobby);
        }

        [Given(@"I enter data to the password fields (.*),(.*),(.*)")]
        public void GivenIEnterDataToThePasswordFields(string currentPassword, string newPassword, string confirmPassword)
        {
            ChangePassword(currentPassword,newPassword,confirmPassword);
        }


        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            SaveButton.Click();
        }

        [Then(@"The profile should be saved successfully")]
        public void ThenTheProfileShouldBeSavedSuccessfully()
        {
            AssertUpdate();
            Drivers.CloseBrowser();
        }

        [Then(@"The password should be changed successfully")]
        public void ThenThePasswordShouldBeChangedSuccessfully()
        {
            AssertUpdate();
            Drivers.CloseBrowser();
        }
    }
}
