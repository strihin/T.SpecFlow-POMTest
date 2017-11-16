using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using SFplusPOM.Pages;
using TechTalk.SpecFlow;

namespace SFplusPOM.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private IWebDriver currentDriver = null;
        LoginPage loginPage = new LoginPage();
        [Given(@"I have navigated to my app")]
        public void GivenIHaveNavigatedToMyApp()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            currentDriver = Browser.Current;
        }
        [Given(@"I typed the (.*) and (.*)")]
        public void GivenITypedTheAnd(string username, string password)
        {
            loginPage.Login(username, password);
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
