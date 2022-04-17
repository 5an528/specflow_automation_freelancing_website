using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.PageObjects
{
    public class DashBoardPage
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        private By ContactDetailsXpath => By.XPath("//*[@id='contactDetails']/div[1]");
        private By ContactNumberXpath => By.XPath("//a[@id='ContactNumber']");

        public DashBoardPage(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }

        private IWebElement ContactDetails => _browserInteractions.WaitAndReturnElement(ContactDetailsXpath);
        private IWebElement ContactNumber => _browserInteractions.WaitAndReturnElement(ContactNumberXpath);

        public void clickOnContactDetails()
        {
            ContactDetails.Click();
        }

        public string getContactNumber()
        {
            return ContactNumber.Text;
        }
    }
}
