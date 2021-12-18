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
    public class Login
    {
        public static String _username;
        public static String _password;

        string firstName = "test3";
     
        #region Initialize Web Elements 
        // Login textbox
        public IWebElement LoginTextbox => Drivers.driver.FindElement(By.XPath("//input[@name='login']"));

        // Password Textbox
        public IWebElement PasswordTextbox => Drivers.driver.FindElement(By.XPath("//input[@name='password']"));

        //Login button
        public IWebElement LoginButton => Drivers.driver.FindElement(By.XPath("//button[@class='btn btn-success']"));

        // Logout button
        public IWebElement LogoutButton => Drivers.driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));

        #endregion

        // Login method
        public void SignIn(string data, string username, string password)
        {
            switch (data)
            {
                case "valid":
                    _username = username;
                    _password = password;
                    break;
                case "invalid":
                    _username = username;
                    _password = password;
                    break;
                case "null":
                    _username = username;
                    _password = password;
                    break;
            }
            // Enter user name
            Assert.AreEqual(LoginTextbox.Displayed, true);
            LoginTextbox.SendKeys(_username);

            // Enter password
            Assert.AreEqual(PasswordTextbox.Displayed, true);
            PasswordTextbox.SendKeys(_password);
        }

        // Login Assertion
        public void LoginAssertion(String data, string username)
        {
            switch (data)
            {
                case "valid":
                    string name ="Hi, " + firstName;
                    string actualName = Drivers.driver.FindElement(By.XPath("//*[@class=\"pull-xs-right\"]//*[@class=\"nav-link disabled\"]")).Text;
                    Assert.AreEqual(name, actualName);
                    Console.WriteLine("Test Passed");
                    break;

                case "invalid":
                    WaitHelpers.TurnOnWait();
                    Assert.AreEqual(Drivers.driver.FindElement(By.XPath("//span[contains(text(),'Invalid username/password')]")).Displayed, true);
                    Console.WriteLine("Test Passed");
                    break;

                case "null":
                    Assert.AreEqual(LoginTextbox.Displayed, true);
                    Console.WriteLine("Test Passed");
                    break;
            }

        }

        // Logout Assertion
        public void LogOutAssertion()
        {
            // Wait untill the login button
            WaitHelpers.WaitClickableElement(Drivers.driver, "XPath", "//button[@class='btn btn-success']");
            Assert.AreEqual(LoginButton.Displayed, true);
        }
    }
}
