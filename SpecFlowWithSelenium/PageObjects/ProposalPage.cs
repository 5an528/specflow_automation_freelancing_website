using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.PageObjects
{
    public class ProposalPage
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        private By FixedFeeTypeId => By.XPath("//span[contains(text(),'Fixed fee')]");
        private By HourlyFeeTypeId => By.XPath("//span[contains(text(), 'Hourly fee')]");
        private By ProjectTitleId => By.XPath("//*[@id='project-title']");
        private By ProjectServiceId => By.XPath("//label[@id='project-service']");
        private By ProjectExpertiseId => By.Id("project-expertise");
        private By PerWeekTypeXpath => By.XPath("//*[@id='EstimatedHoursTypeMaster']");

        public ProposalPage(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }

        private IWebElement PerWeekType => _browserInteractions.WaitAndReturnElement(PerWeekTypeXpath);
        private IWebElement HourlyFeeType => _browserInteractions.WaitAndReturnElement(HourlyFeeTypeId);
        private IWebElement FixedFeeType => _browserInteractions.WaitAndReturnElement(FixedFeeTypeId);
        private IWebElement ProjectTitle => _browserInteractions.WaitAndReturnElement(ProjectTitleId);
        private IWebElement ProjectService => _browserInteractions.WaitAndReturnElement(ProjectServiceId);
        private IWebElement ProjectExpertise => _browserInteractions.WaitAndReturnElement(ProjectExpertiseId);

        public string GetPerWeekType()
        {
            return PerWeekType.Text;
        }

        public string GetFixedFeeType()
        {
            return FixedFeeType.Text;
        }

        public string GetHourlyFeeType()
        {
            return HourlyFeeType.Text;
        }

        public string GetProjectService()
        {
            return ProjectService.Text;
        }

        public string GetProjectTitle()
        {
            return ProjectTitle.Text;
        }

        public string GetProjectExpertise()
        {
            return ProjectExpertise.Text;
        }
    }
}
