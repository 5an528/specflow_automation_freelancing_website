using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.PageObjects
{
    public class LogInAsFreelancerPage
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        private By EmailInputId => By.Id("txtLoginEmail");
        private By PasswordInputId => By.Id("txtLoginPassword");
        private By LoginButtonId => By.Id("btnLogin");
        private By LogInXpath => By.XPath("//a[@id='signIn']");

        public LogInAsFreelancerPage(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }

        private IWebElement EmailInput => _browserInteractions.WaitAndReturnElement(EmailInputId);
        private IWebElement PasswordInput => _browserInteractions.WaitAndReturnElement(PasswordInputId);
        private IWebElement LoginButton => _browserInteractions.WaitAndReturnElement(LoginButtonId);
        private IWebElement LogIn => _browserInteractions.WaitAndReturnElement(LogInXpath);

        public void SetEmailInput()
        {
            LogIn.Click();
            EmailInput.SendKeysWithClear("Yourmail@gmail.com");
        }

        public void SetPasswordInput()
        {
            PasswordInput.SendKeysWithClear("ASDFGHqwerty#12");
        }

        public HomePage ClickLoginButton()
        {
            LoginButton.Click();

            return new HomePage(_browserInteractions, _browserDriver);
        }

    }
}