using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Westpac_Assessment.Helpers;

namespace Westpac_Assessment.Pages
{
    public class Vote
    {
        #region Initialize Web Elements 
        // Popular Make category
        public IWebElement PopularMake => Drivers.driver.FindElement(By.XPath("//img[@title='Lamborghini']"));

        // Popular Model category
        public IWebElement PopularModel => Drivers.driver.FindElement(By.XPath("//img[@title='Diablo']"));

        // Overall rating category
        public IWebElement OverallRating => Drivers.driver.FindElement(By.XPath("//img[@src='/img/overall.jpg']"));

        // Car in PopularMake
        public IWebElement CarInPopularMake => Drivers.driver.FindElement(By.LinkText("Murciélago"));

        // Car in OverallRating
        public IWebElement CarInOverallRating => Drivers.driver.FindElement(By.LinkText("Guilia Quadrifoglio"));

        //Vote button
        public IWebElement VoteButton => Drivers.driver.FindElement(By.XPath("//button[contains(text(),'Vote!')]"));

        #endregion

        // Voting Assertion
        public void AssertVoteCast()
        {
            Thread.Sleep(1000);
            string voted = Drivers.driver.FindElement(By.XPath("//*[@class=\"card-text\"]")).Text;
            Assert.AreEqual("Thank you for your vote!", voted, "Not voted");
        }
    }
}
