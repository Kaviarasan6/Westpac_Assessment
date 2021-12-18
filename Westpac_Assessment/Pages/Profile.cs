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
        public void SelectGender()
        {
            GenderTextbox.Clear();
            GenderTextbox.SendKeys("");
        }

        // Select Hobby 
        public void SelectHobby()
        {
            new SelectElement(HobbyTextbox).SelectByText("");
        }

        // Update profile method
        public void UpdateProfile()
        {
            //Click on Profile button
            WaitHelpers.TurnOnWait();
            ProfileButton.Click();

            //Update FirstName
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//input[@id='firstName']");
            FirstNameTextbox.Clear();
            FirstNameTextbox.SendKeys("");

            //Update Last Name
            LastNameTextBox.Clear();
            LastNameTextBox.SendKeys("");

            //Select gender from dropdown
            SelectGender();

            //Enter age into the age field
            AgeTextBox.Clear();
            AgeTextBox.SendKeys("");

            //Enter Address detail into the address field
            AddressTextBox.Clear();
            AddressTextBox.SendKeys("");

            //Enter Phone number into the phone field
            PhonetextBox.Clear();
            PhonetextBox.SendKeys("");

            //Select hobby from the dropdown
            SelectHobby();
        }

        // Update Password
        public void ChangePassword()
        {
            // Wait untill the profile button is found
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//a[contains(text(),'Profile')]");

            // Click Profile buttton
            ProfileButton.Click();

            WaitHelpers.TurnOnWait();

            // Entering current password
            CurrentPassword.SendKeys("");

            // Entering New password
            NewPassword.SendKeys("");

            // Entering Confirm password
            ConfirmPassword.SendKeys("");
        }

        // Update Assertion
        public void AssertUpdate()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Drivers.driver.PageSource.Contains("The profile has been saved successful"));
        }
    }
}
