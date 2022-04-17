using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowWithSelenium.Utils;
using System.Threading;

namespace SpecFlowWithSelenium.PageObjects
{
    public class HomePage
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        private By LoginButtonId => By.Id("signIn");
        private By ToggleProjectOwnerXpath => By.XPath("//*[@id='pageMainHeader']/div/ul[2]/li[3]/div/div/label/span[1]");
        private By CreateProjectXpath => By.XPath("//*[@id='sidebar-wrapper']/ul/li[4]/a");
        private By DashBoardXpath => By.XPath("//*[@id='sidebar-wrapper']/ul/li[3]/a");
        private By AccountSettingXpath => By.XPath("//span[contains(text(),'Account Settings')]");
        private By BrowseExpertXpath => By.XPath("//*[@id='findAnExpertMenu']");
        //private By ProposalXpath => By.XPath("//*[@id='sidebar-wrapper']/ul/li[6]/a");
        private By Browse_ExpertXpath => By.XPath("//span[contains(text(),'Browse Experts')]");
        private By ReplyXpath => By.XPath("//*[@id='ShowReplyButton']/div[2]/div");
        private By BrowseFilesXpath => By.XPath("//*[@id='ajax-upload-id-1643255920801']");
        private By TextAssertXpath => By.XPath("//*[@id='Messages']/div[1]/div/div[2]/div[1]/div[2]/a");


        //..
        private By UserLogin = By.XPath("//a[@id='signIn']");
        private By DragOnToggle => By.XPath("//*[@id='pageMainHeader']/div/ul[2]/li[3]/div/div/label/span[1]");


        public HomePage (IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }




        private IWebElement AccountSetting => _browserInteractions.WaitAndReturnElement(AccountSettingXpath);
        private IWebElement Dashboard => _browserInteractions.WaitAndReturnElement(DashBoardXpath);
        private IWebElement LoginButton => _browserInteractions.WaitAndReturnElement(LoginButtonId);
        private IWebElement ToggleProjectOwner => _browserInteractions.WaitAndReturnElement(ToggleProjectOwnerXpath);
        private IWebElement CreateProject => _browserInteractions.WaitAndReturnElement(CreateProjectXpath);
        private IWebElement BrowseExpert => _browserInteractions.WaitAndReturnElement(BrowseExpertXpath);
        private IWebElement Browse_Expert => _browserInteractions.WaitAndReturnElement(Browse_ExpertXpath);
        private IWebElement Reply => _browserInteractions.WaitAndReturnElement(ReplyXpath);
        private IWebElement BrowseFiles => _browserInteractions.WaitAndReturnElement(BrowseFilesXpath);
        private IWebElement TextAssert => _browserInteractions.WaitAndReturnElement(TextAssertXpath);

        //..
        private IWebElement ClkOnUserLogin => _browserInteractions.WaitAndReturnElement(UserLogin);
        private IWebElement DragOnToggleBar => _browserInteractions.WaitAndReturnElement(DragOnToggle);


        public DashBoardPage clickOnDashboard()
        {
            Dashboard.Click();

            return new DashBoardPage(_browserInteractions, _browserDriver);
        }

        public AccountSettings clickOnAccountSetting()
        {
            Thread.Sleep(utils.timeDelay);
            AccountSetting.Click();

            return new AccountSettings(_browserInteractions, _browserDriver);
        }

        public LoginPage ClickOnLogin()
        {
            LoginButton.Click();

            return new LoginPage(_browserInteractions, _browserDriver);
        }

        public void ClickOnToggleProjectOwner()
        {
            ToggleProjectOwner.Click();
        }

        public CreateProjectPage ClickOnCreateProject()
        {
            CreateProject.Click();

            return new CreateProjectPage(_browserInteractions, _browserDriver);
        }

        public BrowseExpertPage ClickOnBrowseExpert()
        {
            BrowseExpert.Click();

            return new BrowseExpertPage(_browserInteractions, _browserDriver);
        }

        public void ClickOnBrowse_Expert()
        {
            Browse_Expert.Click();
        }

        public void ReplyClickeProjectClick()
        {
            Reply.Click();
        }
        public void BrowseFilesClick()
        {
            BrowseFiles.Click();
        }

        public string GetText()
        {
            return TextAssert.Text;
        }



        //..

        public void UserClickOnLoginBtn()
        {
            ClkOnUserLogin.Click();
        }

        public void ClickDragOnToggle()
        {
            DragOnToggleBar.Click();
        }




    }
}
