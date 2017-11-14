using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("Before Feature"); 
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before Scenario");   
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Scenario"); 
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("After Feature");
        }
    }
}
