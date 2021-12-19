using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Pages
{
    public class Profile
    {
        #region Initialize Web Elements 

        public IWebElement ProfileButton => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Profile')]"));
        public IWebElement FirstNameTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='firstName']"));
        public IWebElement LastNameTextBox => Drivers.driver.FindElement(By.XPath("//input[@id='lastName']"));
        public IWebElement GenderTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='gender']"));
        public IWebElement AgeTextBox => Drivers.driver.FindElement(By.XPath("//input[@id='age']"));
        public IWebElement AddressTextBox => Drivers.driver.FindElement(By.XPath("//textarea[@id='address']"));
        public IWebElement PhonetextBox => Drivers.driver.FindElement(By.XPath("//input[@id='phone']"));
        public IWebElement HobbyTextbox => Drivers.driver.FindElement(By.XPath("//select[@id='hobby']"));
        public IWebElement CurrentPassword => Drivers.driver.FindElement(By.XPath("//input[@id='currentPassword']"));
        public IWebElement NewPassword => Drivers.driver.FindElement(By.XPath("//input[@id='newPassword']"));
        public IWebElement ConfirmPassword => Drivers.driver.FindElement(By.XPath("//input[@id='newPasswordConfirmation']"));
        public IWebElement SaveButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Save')]"));

        #endregion

        // Select Gender
        public void SelectGender(string gender)
        {
            GenderTextbox.Clear();
            GenderTextbox.SendKeys(gender);
        }

        // Select Hobby 
        public void SelectHobby(string hobby)
        {
            new SelectElement(HobbyTextbox).SelectByText(hobby);
        }

        // Update profile method
        public void UpdateProfile(string firstname, string lastname, string gender, string age, string address, string phone, string hobby)
        {
            //Click on Profile button
            WaitHelpers.TurnOnWait();
            ProfileButton.Click();

            //Update FirstName
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//input[@id='firstName']");
            FirstNameTextbox.Clear();
            FirstNameTextbox.SendKeys(firstname);

            //Update Last Name
            LastNameTextBox.Clear();
            LastNameTextBox.SendKeys(lastname);

            //Select gender from dropdown
            SelectGender(gender);

            //Enter age into the age field
            AgeTextBox.Clear();
            AgeTextBox.SendKeys(age);

            //Enter Address detail into the address field
            AddressTextBox.Clear();
            AddressTextBox.SendKeys(address);

            //Enter Phone number into the phone field
            PhonetextBox.Clear();
            PhonetextBox.SendKeys(phone);

            //Select hobby from the dropdown
            SelectHobby(hobby);
        }

        // Update Password
        public void ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            // Wait untill the profile button is found
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//a[contains(text(),'Profile')]");

            // Click Profile buttton
            ProfileButton.Click();

            WaitHelpers.TurnOnWait();

            // Entering current password
            CurrentPassword.SendKeys(currentPassword);

            // Entering New password
            NewPassword.SendKeys(newPassword);

            // Entering Confirm password
            ConfirmPassword.SendKeys(confirmPassword);
        }

        // Assertion for updating fields
        public void AssertUpdate()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Drivers.driver.PageSource.Contains("The profile has been saved successful"));
        }
    }
}
