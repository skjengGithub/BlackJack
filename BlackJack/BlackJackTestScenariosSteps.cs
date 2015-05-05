using System;
using TechTalk.SpecFlow;

namespace BlackJack
{
    [Binding]
    public class BlackJackTestScenariosSteps
    {
        int scenario; 

        [Given(@"the scenario (.*) card deck")]
        public void GivenTheScenarioCardDeck(int p0)
        {
            scenario = p0;
        }
        
        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            Console.WriteLine("\"enter\" is pressed");
        }
        
        [Then(@"the result should be ""(.*)"" on the console screen")]
        public void ThenTheResultShouldBeOnTheConsoleScreen(string p0)
        {
            bool success;
            switch(scenario)
            {
                case 1:
                    success = (p0 == BlackJackTest.Scenario_1_Result());
                    break;
                case 2:
                    success = (p0 == BlackJackTest.Scenario_2_Result());
                    break;
                case 3:
                    success = (p0 == BlackJackTest.Scenario_3_Result());
                    break;
                case 4:
                    success = (p0 == BlackJackTest.Scenario_4_Result());
                    break;
                case 5:
                    success = (p0 == BlackJackTest.Scenario_5_Result());
                    break;
                case 6:
                    success = (p0 == BlackJackTest.Scenario_6_Result());
                    break;
                default:
                    success = (p0 == BlackJackTest.Scenario_1_Result());
                    break;
            }
            if(success)
            {
                Console.WriteLine("Test Scenario {0}: Passed", scenario);
            }
            else
            {
                Console.WriteLine("Test Scenario {0}: Failed", scenario);
            }

        }
        
    }
}
