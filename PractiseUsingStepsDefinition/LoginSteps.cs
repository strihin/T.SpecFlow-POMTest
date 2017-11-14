using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PractiseUsingStepsDefinition
{
    [Binding]
    public sealed class LoginSteps
    {
        [Given(@"I have navigated to the app")]
        public void GivenIHaveNavigatedToTheApp()
        {
            Console.WriteLine("Dummy Step");
        }

        [Given(@"I see app opened")]
        public void GivenISeeAppOpened()
        {
            Console.WriteLine("Dummy Step");
        }

        [Then(@"I click login link")]
        public void ThenIClickLoginLink()
        {
            Console.WriteLine("Dummy Step");
        }

        [When(@"I enter username and password")]
        public void WhenIEnterUsernameAndPassword(Table table)
        {
            Console.WriteLine("Dummy Step");
        }

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            Console.WriteLine("Dummy Step");
        }

        [Then(@"I should see username with hello")]
        public void ThenIShouldSeeUsernameWithHello()
        {
            Console.WriteLine("Dummy Step");
        }

        [Then(@"I click logout")]
        public void ThenIClickLogout()
        {
            Console.WriteLine("Dummy Step");
        }

    }
}
