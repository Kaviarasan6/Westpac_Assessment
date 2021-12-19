using System;
using TechTalk.SpecFlow;
using Westpac_Assessment.Helpers;
using Westpac_Assessment.Pages;

namespace Westpac_Assessment.Steps
{
    [Binding]
    public class VoteThroughPopularModelSteps:Vote
    {
        [Given(@"I click on Popular Model category")]
        public void GivenIClickOnPopularModelCategory()
        {
            WaitHelpers.TurnOnWait();
            PopularModel.Click();
        }

    }
}
