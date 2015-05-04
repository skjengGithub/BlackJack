using System;
using TechTalk.SpecFlow;

namespace BlackJack
{
    [Binding]
    public class BlackJackTestScenario_1Steps
    {
        [Given(@"the default card deck")]
        public void GivenTheDefaultCardDeck()
        {
        }
        
        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            Console.WriteLine("\"enter\" is pressed");
        }
        
        [Then(@"the result should be ""(.*)"" on the console screen")]
        public void ThenTheResultShouldBeOnTheConsoleScreen(string p0)
        {
            if (p0 == BlackJackTest.Scenario_1_Result())
            {
                Console.WriteLine("Test Scenario 1: Passed");
            }
            else
            {
                Console.WriteLine("Test Scenario 1: Failed");
            }
        }
    }
}
