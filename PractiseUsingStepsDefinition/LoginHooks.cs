using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PractiseUsingStepsDefinition
{
    [Binding]
    public sealed class LoginHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {
            var featureTitle = FeatureContext.Current.FeatureInfo.Title;
            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;

            Console.WriteLine("Feature title: {0} and Scenario title {1}", featureTitle, scenarioTitle);
        }

        [AfterStep]
        public void AfterStep()
        {
            var stepInfo = ScenarioContext.Current.StepContext.StepInfo;
            Console.WriteLine("Steps: "+ stepInfo);
            
        }
    }
}
