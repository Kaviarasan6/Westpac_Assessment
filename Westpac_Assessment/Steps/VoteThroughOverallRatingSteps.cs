using System;
using TechTalk.SpecFlow;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class VoteThroughOverallRatingSteps:Vote
    {
        [Given(@"I click on Overall rating")]
        public void GivenIClickOnOverallRating()
        {
            WaitHelpers.TurnOnWait();
            OverallRating.Click();
        }

        [Given(@"I click on the favourite car in Overall Rating category")]
        public void GivenIClickOnTheFavouriteCarInOverallRatingCategory()
        {
            WaitHelpers.TurnOnWait();
            CarInOverallRating.Click();
        }

    }
}
