using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Pages
{
    public class Registration
    {
        #region Initialize Web Elements 
        // Registration Button
        public static IWebElement RegButton => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));

        //Login Textbox
        public IWebElement LoginTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='username']"));

        // First Name Textbox
        public IWebElement FTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='firstName']"));

        //Last Name Textbox
        public IWebElement LTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='lastName']"));

        //Password Textbox
        public IWebElement PwdTextBox => Drivers.driver.FindElement(By.XPath("//input[@id='password']"));

        //Confirm Password Textbox
        public IWebElement ConfirmPwdTextbox => Drivers.driver.FindElement(By.XPath("//input[@id='confirmPassword']"));

        //Register Button
        public IWebElement RegisterButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Register')]"));
        #endregion

        // Registration method - Check if the element is present and then perform function
        public void Register()
        {
            // Enter login details
            LoginTextbox.SendKeys("TestLogin");

            // Enter First Name
           
            FTextbox.SendKeys("Fname");

            // Enter Last Name
            LTextbox.SendKeys("Lname");

            // Enter Password
            PwdTextBox.SendKeys("TestPassword");

            // Enter Confirm Password
            ConfirmPwdTextbox.SendKeys("TestPassword");
        }

        // Regsitration Assertion method
        public void RegAssertion()
        {
            // Wait untill the successful message 
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//div[contains(text(),'Registration is successful')]");

            Assert.AreEqual(Drivers.driver.FindElement(By.XPath("//div[contains(text(),'Registration is successful')]")).Displayed, true);
        }
    }
}
