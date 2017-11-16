using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SFplusPOM.Pages
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Browser.Current, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")] public IWebElement txtUserName;
        [FindsBy(How = How.Name, Using = "Password")] public IWebElement txtPassword;
        [FindsBy(How = How.Name, Using = "Login")] public IWebElement btnLogin;

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public EAPage ClickButton()
        {
            btnLogin.Click();
            return new EAPage();
        }

    }
}
