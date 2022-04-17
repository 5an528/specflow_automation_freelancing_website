using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using SpecFlowWithSelenium.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;
        private readonly HomePage _homePage;

        public LoginSteps(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _loginPage = new LoginPage(browserInteractions, browserDriver);
            _homePage = new HomePage(browserInteractions, browserDriver);
        }

        [Given(@"User will go to Kolabtree Website")]
        public void GivenUserWillGoToKolabtreeWebsite()
        {

        }

        [When(@"User click on Login")]
        public void WhenUserClickOnLogin()
        {
            _loginPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(2000);
            _homePage.ClickOnLogin();
        }

        [When(@"User fill username")]
        public void WhenUserFillUsername()
        {
            _loginPage.SetEmailInput("Yourmail");
        }

        [When(@"User fill password")]
        public void WhenUserFillPassword()
        {
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
        }

        [Then(@"User can click on login and go to home page")]
        public void ThenUserCanClickOnLoginAndGoToHomePage()
        {
            _loginPage.ClickLoginButton();
        }
    }
}
