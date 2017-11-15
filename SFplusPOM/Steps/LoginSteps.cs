using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SFplusPOM.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        [Given(@"I have navigated to my app")]
        public void GivenIHaveNavigatedToMyApp()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I typed the admin and admin")]
        public void GivenITypedTheAdminAndAdmin()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the EA page")]
        public void ThenIShouldSeeTheEAPage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
