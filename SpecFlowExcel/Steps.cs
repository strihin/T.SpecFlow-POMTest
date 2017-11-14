using System;
using TechTalk.SpecFlow;

namespace SpecFlowExcel
{
    [Binding]
    public sealed class Steps
    {
        [Given(@"Input sum(.*) and input sum(.*)")]
        public void GivenInputSumAndInputSum(string p0, string p1)
        {
            Console.WriteLine("Number {0} + {1}", p0, p1);
        }

        [Then(@"Result should be (.*)")]
        public void ResultShouldBe(int p0)
        {
            Console.WriteLine("Result: {0}", p0);
        }

        [When(@"Table with data for sum there")]
        public void ExcelImport()
        {
            Console.WriteLine("Adding values");
        }

    }
}
