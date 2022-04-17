using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.PageObjects
{
    public class LoginPage
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        private By EmailInputId => By.Id("txtLoginEmail");
        private By PasswordInputId => By.Id("txtLoginPassword");
        private By LoginButtonId => By.Id("btnLogin");
        private By CreateAccountXpath => By.XPath("//a[contains(text(),'Create account')]");
        private By BrowserNotificationAlertXpath => By.XPath("//button[contains(text(),'OK')]");

        //..
        private By EmailField => By.Id("txtLoginEmail");
        private By PasswordField => By.Id("txtLoginPassword");
        private By LoginBtnField => By.Id("btnLogin");



        public LoginPage(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }

        private IWebElement CreateAccount => _browserInteractions.WaitAndReturnElement(CreateAccountXpath);
        private IWebElement EmailInput => _browserInteractions.WaitAndReturnElement(EmailInputId);
        private IWebElement PasswordInput => _browserInteractions.WaitAndReturnElement(PasswordInputId);
        private IWebElement LoginButton => _browserInteractions.WaitAndReturnElement(LoginButtonId);

        //..
        private IWebElement EnterEmailField => _browserInteractions.WaitAndReturnElement(EmailField);
        private IWebElement EnterPasswordField => _browserInteractions.WaitAndReturnElement(PasswordField);
        private IWebElement EnterLoginBtn => _browserInteractions.WaitAndReturnElement(LoginBtnField);
        private IWebElement BrowserNotificationAlert => _browserInteractions.WaitAndReturnElement(BrowserNotificationAlertXpath);

        public void ClickOnBrowserNotificationAlert()
        {
            BrowserNotificationAlert.Click();
        }

        public void SetEmailInput(string email)
        {
            EmailInput.SendKeysWithClear(email);
        }

        public void SetPasswordInput(string pass)
        {
            PasswordInput.SendKeysWithClear(pass);
        }

        public HomePage ClickLoginButton()
        {
            LoginButton.Click();

            return new HomePage(_browserInteractions, _browserDriver);
        }

        public CreateAccountPage ClickOnCreateAccountPage()
        {
            CreateAccount.Click();

            return new CreateAccountPage(_browserInteractions, _browserDriver);
        }

        //..

        public void ClickOnEnterEmail(string eMail)
        {
            EnterEmailField.SendKeysWithClear(eMail);
        }

        public void ClickOnEnterPass(string passWord)
        {
            EnterPasswordField.SendKeysWithClear(passWord);
        }

        public void ClickOnLoginButton()
        {
            EnterLoginBtn.Click();
        }




    }
}
