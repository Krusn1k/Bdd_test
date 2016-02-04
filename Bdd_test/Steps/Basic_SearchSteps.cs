using System;
using TechTalk.SpecFlow;

namespace Bdd_test.Steps
{
    [Binding]
    public class Basic_SearchSteps
    {
        [Given(@"I set search rquest ""(.*)""")]
        public void GivenISetSearchRquest(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I perform search")]
        public void WhenIPerformSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the search query ""(.*)"" should be the first in the Search Result grid")]
        public void ThenTheSearchQueryShouldBeTheFirstInTheSearchResultGrid(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
