using System;
using System.Threading;
using TechTalk.SpecFlow;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class VoteThroughPopularMakeSteps:Vote
    {
        [Given(@"I click on Popular Make category")]
        public void GivenIClickOnPopularMakeCategory()
        {
            WaitHelpers.TurnOnWait();
            PopularMake.Click();
        }
        
        [Given(@"I click on the favourite car model")]
        public void GivenIClickOnTheFavouriteCarModel()
        {
            WaitHelpers.TurnOnWait();
            CarInPopularMake.Click();
        }
        
        [When(@"I cast my vote")]
        public void WhenICastMyVote()
        {
            Thread.Sleep(2000);
            VoteButton.Click();
        }
        
        [Then(@"Voting has been casted successfully")]
        public void ThenVotingHasBeenCastedSuccessfully()
        {
            AssertVoteCast();
            Drivers.CloseBrowser();
        }
    }
}
