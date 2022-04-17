using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.PageObjects
{
    public class AccountSettings
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        private By UserPhoneNumberId => By.Id("userPhoneNumber");
        private By ProfileNameClass => By.ClassName("names");

        public AccountSettings(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }

        private IWebElement Profilename => _browserInteractions.WaitAndReturnElement(ProfileNameClass);
        private IWebElement UserPhoneNumber => _browserInteractions.WaitAndReturnElement(UserPhoneNumberId);

        public string getUserPhoneNumber()
        {
            return UserPhoneNumber.Text;
        }

        public string getUserProfilename()
        {
            return Profilename.Text;
        }
    }
}
