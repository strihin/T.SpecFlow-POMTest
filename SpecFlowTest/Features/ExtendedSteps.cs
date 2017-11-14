using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpecFlowTest.Step_Definitions;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
    [Binding]
    public sealed class ExtendedSteps
    {
        public readonly EmployeeDetails employee;

        public ExtendedSteps(EmployeeDetails emp)
        {
            employee = emp;
        }
        [Then(@"the result should be on the screens")]
        public void ThenTheResultShouldBeOnTheScreens()
        {
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Email);
            Console.WriteLine(employee.Phone);
        }
    }
}
