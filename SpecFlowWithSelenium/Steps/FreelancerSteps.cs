using FluentAssertions;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using SpecFlowWithSelenium.PageObjects;
using SpecFlowWithSelenium.Utils;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    class FreelancerSteps
    {
        private readonly HomePage _homePage;
        private readonly FreelancerPage _freelancerPage;
        private readonly utils _utils;
        private readonly LogInAsFreelancerPage _logInAsFreelancerPage;

        public FreelancerSteps(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _homePage = new HomePage(browserInteractions, browserDriver);
            _freelancerPage = new FreelancerPage(browserInteractions, browserDriver);
            _utils = new utils(browserInteractions, browserDriver);
            _logInAsFreelancerPage = new LogInAsFreelancerPage(browserInteractions, browserDriver);

        }

        [Given(@"I login to kolabtree as freelancer")]
        public void GivenILoginToKolabtreeAsFreelancer()
        {
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.SetEmailInput();
            _logInAsFreelancerPage.SetPasswordInput();
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.ClickLoginButton();

        }

        [Given(@"I navigated to browse projects page")]
        public void GivenINavigatedToBrowseProjectsPage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.BrowseProjectClick();
        }

        [Given(@"I click on view details for any project")]
        public void GivenIClickOnViewDetailsForAnyProject()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ViewDetailsClick();
        }


        [Given(@"I click on public message tab")]
        public void GivenIClickOnPublicMessageTab()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.ScrollUpFunc());
            _freelancerPage.PublicMessageBoardClick();
            Thread.Sleep(utils.timeDelay);
        }

        [Given(@"I enter Test Public message text")]
        public void GivenIEnterText()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.TestBoxClick("Test Public message");
        }

        [When(@"I click on Ask question button")]
        public void WhenIClickOnButton()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AskQuestionClick();
        }

        [Then(@"I should see message posted and should reflect under ‘Messages’ section")]
        public void ThenIShouldSeeMessagePostedAndShouldReflectUnderMessagesSection()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.MessageCommentFunc().Should().Be("Test Public message");
        }

        [Given(@"I have an account")]
        public void GivenIHaveAnAccount()
        {
        }

        [When(@"I log into")]
        public void WhenILogInto()
        {
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.SetEmailInput();
            _logInAsFreelancerPage.SetPasswordInput();
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.ClickLoginButton();
        }

        [When(@"I open Proposals tab")]
        public void WhenIOpenProposalsTab()
        {
            _freelancerPage.ProposalTabClick();
        }

        [Then(@"I should see activated messaging container")]
        public void ThenIShouldSeeActivatedMessagingContainer()
        {
            _freelancerPage.CheckforMessageProve().Should().Be("You can also view and reply to these messages directly from your email inbox.");
        }

        [Then(@"I can send a message")]
        public void ThenICanSendAMessage()
        {
            _freelancerPage.TextAreaClickandSend();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.SendMessageClick();
        }

        [Given(@"I am logged into as a freelancer with few accepted proposals")]
        public void GivenIAmLoggedIntoAsAFreelancerWithFewAcceptedProposals()
        {
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.SetEmailInput();
            _logInAsFreelancerPage.SetPasswordInput();
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.ClickLoginButton();
        }

        [When(@"I open workspace")]
        public void WhenIOpenWorkspace()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceButtonLinkClick();
        }

        [When(@"I try to send a message to a client")]
        public void WhenITryToSendAMessageToAClient()
        {
            _freelancerPage.WorkspaceTextAreaLinkSend();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceTextSendButtonClick();
        }

        [Then(@"I should see message delivered successfully")]
        public void ThenIShouldSeeMessageDeliveredSuccessfully()
        {
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceTextCheckLinkProve().Should().Be("This is a Test Workspace Message.");
        }


        [Given(@"user login to Kolabtree existing account as freelancer")]
        public void GivenUserLoginToKolabtreeExistingAccountAsFreelancer()
        {
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.SetEmailInput();
            _logInAsFreelancerPage.SetPasswordInput();
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.ClickLoginButton();
        }

        [Given(@"user is having a project under confirmed state")]
        public void GivenUserIsHavingAProjectUnderState()
        {
        }

        [Given(@"user navigate to /workspace page")]
        public void GivenUserNavigateToWorkspacePage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceButtonLinkClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
        }

        [Given(@"user selects confirmed project")]
        public void GivenUserSelectsConfirmedProject()
        {
        }

        [Given(@"user uploads a file under workspace messaging")]
        public void GivenUserUploadsAFileUnderWorkspaceMessaging()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.UploadedFileProve().Should().Be(" download.png");
        }

        [Given(@"user clicks on delete icon next to file")]
        public void GivenUserClicksOnDeleteIconNextToFile()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.DeleteUploadClick();
        }

        [Given(@"user should see a warning! popup as Are you sure you want to remove filename file\?")]
        public void GivenUserShouldSeeAWarningPopupAsAreYouSureYouWantToRemoveFilenameFile()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ConfirmDeleteProve().Should().Be("Are you sure you want to remove \"download.png\" file?");
        }


        [When(@"user clicks on ‘ok’ button on popup")]
        public void WhenUserClicksOnOkButtonOnPopup()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.DeleteOKClick();
        }

        [Then(@"user should see the file link is removed")]
        public void ThenUserShouldSeeTheFileLinkIsRemoved()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.TestRemovedProve().Should().Be("Test removed file");
        }

        [Then(@"file cannot be downloaded")]
        public void ThenFileCannotBeDownloaded()
        {
        }

        [Given(@"user is on Kolabtree home page")]
        public void GivenUserIsOnKolabtreeHomePage()
        {
        }

        [Given(@"user is in loggedin/non loggedin mode")]
        public void GivenUserIsInLoggedinNonLoggedinMode()
        {
        }

        [When(@"user clicks on Kolabtree Blog link present under Follow Us Section")]
        public void WhenUserClicksOnKolabtreeBlogLinkPresentUnderFollowUsSection()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.getBlog());
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getBlog().Click();
        }

        [Then(@"user should be redirected to The Kolabtree Blog: Research, Innovation and The Future of Work   url in new tab")]
        public void ThenUserShouldBeRedirectedToTheKolabtreeBlogResearchInnovationAndTheFutureOfWorkUrlInNewTab()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.switchTab(1);
            _freelancerPage.getPage().Should().Be("https://www.kolabtree.com/blog/");
        }

        [Given(@"I am on Kolabtree Home page")]
        public void GivenIAmOnKolabtreeHomePage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();

            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BEcomeanExpertClick());
        }

        [Given(@"I clicks on any Become an Expert button present on footer without logged in to kolabtree account")]
        public void GivenIClicksOnAnyBecomeAnExpertButtonPresentOnFooterWithoutLoggedInToKolabtreeAccount()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.BEcomeanExpertClick().Click();
        }

        [Then(@"a popup should open focusing on create account tab")]
        public void ThenAPopupShouldOpenFocusingOnCreateAccountTab()
        {
            Thread.Sleep(utils.timeDelay);

            _freelancerPage.CreateAccountModalProve().Should().Be("Create an account for a personalized and secure experience");
        }

        [When(@"user clicks on Twitter link present under Follow Us Section")]
        public void WhenUserClicksOnTwitterLinkPresentUnderFollowUsSection()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();

            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.TwitterButtonLink());
        }

        [Then(@"user should be redirected to The Twitter url in new tab")]
        public void ThenUserShouldBeRedirectedToTheTwitterUrlInNewTab()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.TwitterButtonLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://twitter.com/kolabtree");
        }

        [When(@"user clicks on Facebook link present under Follow Us Section")]
        public void WhenUserClicksOnFacebookLinkPresentUnderFollowUsSection()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();

            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.FacebookButtonLink());
        }

        [Then(@"user should be redirected to The Facebook url in new tab")]
        public void ThenUserShouldBeRedirectedToTheFacebookUrlInNewTab()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FacebookButtonLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://www.facebook.com/kolabtree");
        }

        [When(@"user clicks on LinkedIn link present under Follow Us Section")]
        public void WhenUserClicksOnLinkedInLinkPresentUnderFollowUsSection()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();

            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.LinkedInButtonLink());
        }

        [Then(@"user should be redirected to The LinkedIn url in new tab")]
        public void ThenUserShouldBeRedirectedToTheLinkedInUrlInNewTab()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.LinkedInButtonLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.linkedin.com/company/kolabtree");
        }

        [Given(@"I am on Kolabtree homepepage")]
        public void GivenIAmOnKolabtreeHomepepage()
        {
        }

        [Given(@"I scroll to footer of homepage")]
        public void GivenIScrollToFooterOfHomepage()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());
        }

        [When(@"I click on  hyperlink under Experts by Skill section")]
        public void WhenIClickOnHyperlinkUnderExpertsBySkillSection()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();

        }

        [Then(@"I should navigate to the pages")]
        public void ThenIShouldNavigateToThePages()
        {
            // 1st Link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HireStatisticianLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/services/statistical-analysis/");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

            // 2nd link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ScientistLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

            //3rd link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FoodScientistLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert/subject/food-science-and-technology");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

            //4th link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HealthEconomistLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert/subject/health-economics");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

            //5th link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.DataScientistLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert/subject/data-analysis");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

            //6th Link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.MedicalWriterLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert/subject/medical-writing");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

            //7th link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ResearcherLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

            //8th link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HireDataScientistLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert/subject/data-analysis");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

            //9th link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ChemistLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert/subject/chemistry");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

            //10th link
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.BiostatisticianLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert/subject/biostatistics");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.BiostatisticianLink());

        }

        [Given(@"user is on Kolabtree home page in loggedin /nonloggedin mode")]
        public void GivenUserIsOnKolabtreeHomePageInLoggedinNonloggedinMode()
        {
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/");
        }

        [When(@"user clicks on Home link present in footer")]
        public void WhenUserClicksOnHomeLinkPresentInFooter()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.HomeClickLink());
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomeClickLink().Click();
        }

        [Then(@"user should be redirected to kolabtree home page only")]
        public void ThenUserShouldBeRedirectedToKolabtreeHomePageOnly()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/");
        }

        [When(@"user clicks on Success Stories link present in footer")]
        public void WhenUserClicksOnSuccessStoriesLinkPresentInFooter()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.SuccessStoriesClickLink());
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.SuccessStoriesClickLink().Click();
        }

        [Then(@"user should be redirected to kolabtree Success Stories page only")]
        public void ThenUserShouldBeRedirectedToKolabtreeSuccessStoriesPageOnly()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/success-stories");
        }

        [When(@"user scroll and go to footer")]
        public void WhenUserScrollAndGoToFooter()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.ValidAddressLink());
        }


        [Then(@"user should be read kolabtree Valid Address on footer")]
        public void ThenUserShouldBeReadKolabtreeValidAddressOnFooter()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ValidAddressProve().Should().Be("Devonshire House, 60 Goswell Road,\r\nLondon, EC1M 7AD");
        }


        [When(@"user clicks on About Us  link present in footer")]
        public void WhenUserClicksOnAboutUsLinkPresentInFooter()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.AboutUsClickLink());
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AboutUsClickLink().Click();
        }

        [Then(@"user should be redirected to kolabtree About us page only")]
        public void ThenUserShouldBeRedirectedToKolabtreeAboutUsPageOnly()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/aboutus");
        }

        [Given(@"I am on Kolabtree")]
        public void GivenIAmOnKolabtree()
        {
        }

        [Given(@"I am on any of the pages in logged out mode")]
        public void GivenIAmOnAnyOfThePagesInLoggedOutMode()
        {
        }

        [When(@"I scroll to footer")]
        public void WhenIScrollToFooter()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.FrequentlyAskedQuestionLink());

        }

        [Then(@"I should see Frequently asked questions link present below Refer a friend button")]
        public void ThenIShouldSeeFrequentlyAskedQuestionsLinkPresentBelowReferAFriendButton()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FrequentlyAskedQuestionLink().Text.Should().Be("Frequently Asked Questions");
        }

        [Then(@"I click on the link")]
        public void ThenIClickOnTheLink()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FrequentlyAskedQuestionClick();
        }

        [Then(@"I should redirect to support page in new tab")]
        public void ThenIShouldRedirectToSupportPageInNewTab()
        {
            _utils.switchTab(1);
            _freelancerPage.getPage().Should().Be("https://kolabtree.freshdesk.com/support/home");
        }

        [Given(@"I am on Kolabtree Home Page1")]
        public void GivenIAmOnKolabtreeHomePage1()
        {
        }

        [Given(@"I click on Log In button present on homepage header")]
        public void GivenIClickOnLogInButtonPresentOnHomepageHeader()
        {
            _logInAsFreelancerPage.SetEmailInput();
        }

        [Given(@"I should see a popup opens focusing on Log in tab")]
        public void GivenIShouldSeeAPopupOpensFocusingOnLogInTab()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.LoginModalProve().Should().Be("Log in to your account");
        }

        [Given(@"I enter hiring credentials email id")]
        public void GivenIEnterHiringCredentialsEmailId()
        {

            _logInAsFreelancerPage.SetPasswordInput();
        }

        [Given(@"I click on Log in button")]
        public void GivenIClickOnLogInButton()
        {
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.ClickLoginButton();
        }

        [Then(@"I should get successfully logged in to kolabtree account")]
        public void ThenIShouldGetSuccessfullyLoggedInToKolabtreeAccount()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.LogInProveLink().Should().Be("  My Dashboard  ");
        }



        [Given(@"user navigate to create-bid page for any hourly fee project")]
        public void GivenUserNavigateToCreate_BidPageForAnyHourlyFeeProject()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.BrowseProjectClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HourlyFeeProveLink().Should().Be("Hourly fee");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ViewDetails1LinkClick();
        }

        [Given(@"user enter all fields on step")]
        public void GivenUserEnterAllFieldsOnStep()
        {
            _freelancerPage.ProposalSummaryClick("This is a Proposal Summary");
        }

        [Given(@"user clicks on Enter fee and deadline CTA")]
        public void GivenUserClicksOnCTA()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.EnterFeeAndDeadlineClick();
        }

        [Given(@"user add Proposed Hourly Fee as 100")]
        public void GivenUserAddProposedHourlyFeeAs()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ProposedHourlyFeeClick("100");
        }

        [Given(@"user add No. Of Hours as Ten")]
        public void GivenUserAddAs()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.NumberOfHoursClick("10");
        }

        [Given(@"user select deadline")]
        public void GivenUserSelectDeadline()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AddDatesClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.NextDatesClick();
        }

        [When(@"user clicks on Create proposal CTA")]
        public void WhenUserClicksOnCTA()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CreateProposalClick();
        }

        [Then(@"user should see the proposal is created successfully and user is navigated to proposals page")]
        public void ThenUserShouldSeeTheProposalIsCreatedSuccessfullyAndUserIsNavigatedToProposalsPage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ProposalPageProveLink().Should().Be("  Freelancer Proposal    ");
        }

        [Then(@"user should see all details reflect correctly for the proposal on the proposals page")]
        public void ThenUserShouldSeeAllDetailsReflectCorrectlyForTheProposalOnTheProposalsPage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HourlyFeeProveInPrposalPageLink().Should().Be("100.00");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.NumberofHourProveInPrposalPageLink().Should().Be("10");

        }
        [Given(@"user select deadline for fixed fee")]
        public void GivenUserSelectDeadlineForFixedFee()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FixedFeeDateClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FixedFeeNextDateClick();
        }

        [Given(@"user navigate to create-bid page for any fixed fee project")]
        public void GivenUserNavigateToCreate_BidPageForAnyFixedFeeProject()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.BrowseProjectClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FixedFeeProve().Should().Be("Fixed fee");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ViewDetailsClick();
        }

        [Then(@"user should see all details reflect correctly for the proposal on the proposals page for Fixed Fee")]
        public void ThenUserShouldSeeAllDetailsReflectCorrectlyForTheProposalOnTheProposalsPageForFixedFee()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HourlyFeesProveInPrposalPageLink().Should().Be("100.00");
        }

        [Given(@"user is having open for proposals project present in their account")]
        public void GivenUserIsHavingOpenForProposalsProjectPresentInTheirAccount()
        {

        }

        [Given(@"user navigate to proposals page")]
        public void GivenUserNavigateToProposalsPage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ProposalTabClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
        }

        [Given(@"user uploads a file under private messaging channel")]
        public void GivenUserUploadsAFileUnderPrivateMessagingChannel()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.assterbrowsefileLink().Should().Be(" download.png");
        }

        [When(@"user clicks on tag icon present next to uploaded file")]
        public void WhenUserClicksOnTagIconPresentNextToUploadedFile()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.TagFileClick();
        }

        [When(@"user enters tag as File tagged")]
        public void WhenUserEntersTagAsFileTagged()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.TagInputClick("File tagged");
            Thread.Sleep(utils.timeDelay);
        }

        [When(@"user clicks as Save")]
        public void WhenUserClicksAsSave()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.SaveTagClick();
        }

        [Then(@"user should see the tag has been added to file name")]
        public void ThenUserShouldSeeTheTagHasBeenAddedToFileName()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.NewTagProve().Should().Be("File tagged");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.RemoveTagClick();
        }


        [Given(@"I open workspace")]
        public void GivenIOpenWorkspace()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceButtonLinkClick();
        }

        [Given(@"I clicks on Browse file button and upload file")]
        public void GivenIClicksOnBrowseFileButtonAndUploadFile()
        {

        }

        [Given(@"I should see uploaded file under uploaded files box contains")]
        public void GivenIShouldSeeUploadedFileUnderUploadedFilesBoxContains()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceAssertbrowsefileLink().Should().Be(" download.png");
        }

        [When(@"I clicks on Add Tag button and insert tag name")]
        public void WhenIClicksOnAddTagButtonAndInsertTagName()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceTagFileClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceTagInputClick("File tagged");
            Thread.Sleep(utils.timeDelay);

        }

        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceSaveTagClick();
        }

        [When(@"I should see  uploaded file tag name")]
        public void WhenIShouldSeeUploadedFileTagName()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceTagProve().Should().Be("File tagged");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.WorkspaceRemoveTagClick();

        }

        [Given(@"I click on view details for any hourly fee project with Project Title: Service Category and Sub service, Project Description, Expertise required:,  Fee Type, Fee, Project duration: , No\. of hours Per Week: added")]
        public void GivenIClickOnViewDetailsForAnyHourlyFeeProjectWithProjectTitleServiceCategoryAndSubServiceProjectDescriptionExpertiseRequiredFeeTypeFeeProjectDurationNo_OfHoursPerWeekAdded()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ViewDetails1LinkClick();
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.ProjectTitleLink());
            _freelancerPage.ProjectTitleLink().Text.Should().Be("Test project");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CatagoryProveLink().Should().Be("Category: Consulting");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.SubCatagoryProveLink().Should().Be("Subcategory: Technical consulting");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.TasksDeliverablesLink().Should().Be("Tasks & Deliverables: Consulting call");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ProposalSummaryClick("This is a Proposal Summary");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();

        }

        [Given(@"I navigated to create bid page")]
        public void GivenINavigatedToCreateBidPage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.EnterFeeAndDeadlineClick();

        }

        [When(@"I click on public message tab")]
        public void WhenIClickOnPublicMessageTab()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.ScrollUpFunc());
            _freelancerPage.PublicMessageBoardClick();
            Thread.Sleep(utils.timeDelay);
        }

        [Then(@"I should see Project Title: Service Category and Sub service on top of page")]
        public void ThenIShouldSeeProjectTitleServiceCategoryAndSubServiceOnTopOfPage()
        {
            Thread.Sleep(utils.timeDelay);
            _utils.scrollToElement(_freelancerPage.ProjectTitleLink());
            _freelancerPage.ProjectTitleLink().Text.Should().Be("Test project");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CatagoryProveLink().Should().Be("Category: Consulting");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.SubCatagoryProveLink().Should().Be("Subcategory: Technical consulting");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.TasksDeliverablesLink().Should().Be("Tasks & Deliverables: Consulting call");
        }

        [Then(@"I should see Project Description, Expertise required: under Project Description section")]
        public void ThenIShouldSeeProjectDescriptionExpertiseRequiredUnderProjectDescriptionSection()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ProjectDescriptionLink().Should().Be("Project Description:");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ExpertiserequiredProve().Should().Be("Expertise required:");
        }

        [Then(@"I should see Fee Type, Fee, Project duration:, No\. of hours Per Week: under Project Budget section")]
        public void ThenIShouldSeeFeeTypeFeeProjectDurationNo_OfHoursPerWeekUnderProjectBudgetSection()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FeeTypeProve().Should().Be("Fee Type:");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FeeProveText().Should().Be("Fee:");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FeexPerMonthProve().Should().Be("Per Month:");
            Thread.Sleep(utils.timeDelay);

        }

        [Then(@"I should see Clients timeline for hiring")]
        public void ThenIShouldSeeClientsTimelineForHiring()
        {
            _freelancerPage.TimelineforHiringProve().Should().Be("Client's timeline for hiring");
            Thread.Sleep(utils.timeDelay);
        }

        [Given(@"I am on Kolabtree Home Page")]
        public void GivenIAmOnKolabtreeHomePage2()
        {
        }

        [When(@"I click on Kolabtree link present on homepage header")]
        public void WhenIClickOnKolabtreeLinkPresentOnHomepageHeader()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HomepageBackClick();
        }

        [Then(@"I should navigate to Koalbtree Home Page with url as www\.kolabtree\.co")]
        public void ThenIShouldNavigateToKoalbtreeHomePageWithUrlAsWww_Kolabtree_Co()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/");
        }

        [Then(@"I click on Projects link present on homepage header")]
        public void ThenIClickOnProjectsLinkPresentOnHomepageHeader()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ProjectsHomepageClick();
        }

        [Then(@"I should navigate to Browse Projects Page with url as www\.kolabtree\.com/projects")]
        public void ThenIShouldNavigateToBrowseProjectsPageWithUrlAsWww_Kolabtree_ComProjects()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/projects");
        }

        [Then(@"I click on find an expert link present on homepage header")]
        public void ThenIClickOnFindAnExpertLinkPresentOnHomepageHeader()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FindAnExpertLinkClick();
        }

        [Then(@"I should navigate to Browse Projects Page with url as /find-an-expert page")]
        public void ThenIShouldNavigateToBrowseProjectsPageWithUrlAsFind_An_ExpertPage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert");
        }

        [Then(@"I click on how-it-works link present on homepage header")]
        public void ThenIClickOnHow_It_WorksLinkPresentOnHomepageHeader()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.HowItWorksClick();
        }

        [Then(@"I should navigate to how-it-works Page with url as www\.kolabtree\.com/how-it-work")]
        public void ThenIShouldNavigateToHow_It_WorksPageWithUrlAsWww_Kolabtree_ComHow_It_Work()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/how-it-works");
        }

        [Then(@"I click on Services dropdown link present on homepage header")]
        public void ThenIClickOnServicesDropdownLinkPresentOnHomepageHeader()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ServiceLinkClick();
        }

        [Then(@"I click on each service under dropdown")]
        public void ThenIClickOnEachServiceUnderDropdown()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.MedicalWritingClick();
        }

        [Then(@"I should navigate to  clicked service page with url as www\.kolabtree\.com/Services/service name/")]
        public void ThenIShouldNavigateToClickedServicePageWithUrlAsWww_Kolabtree_ComServicesServiceName()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/services/medical-writing/");
        }

        [Then(@"I click on Solutions dropdown link present on homepage header")]
        public void ThenIClickOnSolutionsDropdownLinkPresentOnHomepageHeader()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.SolutionsLinkClick();
        }

        [Then(@"I click on each industry under dropdown")]
        public void ThenIClickOnEachIndustryUnderDropdown()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.PharmaceuticalsClick();
        }

        [Then(@"I should navigate to  clicked option")]
        public void ThenIShouldNavigateToClickedOption()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert/subject/pharmaceutical-industry");
        }

        [Then(@"I click on Join as expert button")]
        public void ThenIClickOnJoinAsExpertButton()
        {
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.BecomeExpertClick();
        }

        [Then(@"I should see signup modal should open")]
        public void ThenIShouldSeeSignupModalShouldOpen()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CreateAccountModalProve().Should().Be("Create an account for a personalized and secure experience");
        }

        [Then(@"I click on sign IN button")]
        public void ThenIClickOnSignINButton()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.LogInModalClick();
        }

        [Then(@"I should see sign in modal should open")]
        public void ThenIShouldSeeSignInModalShouldOpen()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.LoginModalProve().Should().Be("Log in to your account");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CloseLogInModalClick();
        }

        [Then(@"I click on Request a service button")]
        public void ThenIClickOnRequestAServiceButton()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.RequestAServiceClick();
        }

        [Then(@"I should navigate to create project form with url as /create-project")]
        public void ThenIShouldNavigateToCreateProjectFormWithUrlAsCreate_Project()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CreateProjectProveLink().Should().Be("Creating a project typically takes 5-7 mins.");
        }

        [Given(@"user login on kolabtree as Freelancer")]
        public void GivenUserLoginOnKolabtreeAsFreelancer()
        {
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.SetEmailInput();
            _logInAsFreelancerPage.SetPasswordInput();
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.ClickLoginButton();
        }

        [Given(@"user is on freelancer bid page")]
        public void GivenUserIsOnFreelancerBidPage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ProposalTabClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
        }

        [Given(@"user is on Proposal tab")]
        public void GivenUserIsOnProposalTab()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/freelancer/bid/");
        }

        [When(@"user try to browse given extension file \(jpg, png, mpFour , video file, doc, xlsx, pdf, zip, rar, sevenZ\)")]
        public void WhenUserTryToBrowseGivenExtensionFileJpgPngMpFourVideoFileDocXlsxPdfZipRarSevenZ()
        {
        }

        [Then(@"user can send files from system successfully")]
        public void ThenUserCanSendFilesFromSystemSuccessfully()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.assterbrowsefileLink().Should().Be(" download.png");
        }

        [Given(@"user is having open for proposals project present in their account(.*)")]
        public void GivenUserIsHavingOpenForProposalsProjectPresentInTheirAccount(int p0)
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ProposalTabClick();
        }

        [Given(@"user should see a warning! popup as Are you sure you want to remove filename v1")]
        public void GivenUserShouldSeeAWarningPopupAsAreYouSureYouWantToRemoveFilenameFile1()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CustomMessageModalLink().Should().Be("Are you sure you want to remove \"download.png\" file?");
        }

        [When(@"user clicks on ok button on pop v1")]
        public void WhenUserClicksOnOkButtonOnPopup1()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ClickonOKinProposalPageClick();
        }

        [Then(@"user should see the file link is remove v1")]
        public void ThenUserShouldSeeTheFileLinkIsRemoved1()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.TextRemoveCheckProposalPageProve().Should().Be("Test removed file :");
        }

        [Then(@"file cannot be download v1")]
        public void ThenFileCannotBeDownloaded1()
        {
        }


        [Given(@"user clicks on delete icon next to uploaded file")]
        public void GivenUserClicksOnDeleteIconNextToUploadedFile()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.DelectIconProposalPageClick();
        }

        [Given(@"I am on find an expert page")]
        public void GivenIAmOnFindAnExpertPage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FindAnExpertLinkClick();
        }

        [Given(@"I select any institution by typing a letter a")]
        public void GivenISelectAnyInstitutionByTypingALetterA()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.FindExterMoreButtonClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.InstitutionInputWork().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.InstitutionInputAlphabetA();
            Thread.Sleep(utils.timeDelay);

        }

        [Given(@"I select an option from auto suggest dropdown")]
        public void GivenISelectAnOptionFromAutoSuggestDropdown()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.SelectUniversityList1Click();

        }

        [When(@"I click on apply filter button")]
        public void WhenIClickOnApplyFilterButton()
        {
        }

        [Then(@"I should see the profiles with selected institution name reflects only")]
        public void ThenIShouldSeeTheProfilesWithSelectedInstitutionNameReflectsOnly()
        {
            _freelancerPage.UniversityProveOfIt().Should().Be("University of Texas at Austin");
        }

        [Then(@"I should see the ordering of profile is done as per freelancer profile score ordered by highest to lowest")]
        public void ThenIShouldSeeTheOrderingOfProfileIsDoneAsPerFreelancerProfileScoreOrderedByHighestToLowest()
        {
        }

        [Given(@"I select India under country drop down")]
        public void GivenISelectIndiaUnderCountryDropDown()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CountryClickLink();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.EnterACountryNameClick().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.EnterACountryNameInput();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.SelectUniversityList1Click();

        }

        [Then(@"I should see the profiles with country as India only")]
        public void ThenIShouldSeeTheProfilesWithCountryAsIndiaOnly()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CountryProveLink().Should().Be("India");
        }

        [When(@"Experts container is loaded")]
        public void WhenExpertsContainerIsLoaded()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.getPage().Should().Be("https://test.kolabtree.com/find-an-expert");
        }

        [When(@"I select subject Biophysics in search filter")]
        public void WhenISelectSubjectBiophysicsInSearchFilter()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.SubjectAreasClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.EnterSubjectAreaLink().Click();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.EnterSubjectAreaLink().SendKeysWithClear("Biophysics");
        }



        //..

        [Given(@"I am logged into Kolabtree as freelancer")]
        public void GivenIAmLoggedIntoKolabtreeAsFreelancer()
        {
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.SetEmailInput();
            _logInAsFreelancerPage.SetPasswordInput();
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.ClickLoginButton();
        }

        [When(@"I clicked on '(.*)' tab")]
        public void WhenIClickedOnTab(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ClickOnWorkSpace();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ClickOnAcceptCookies();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ClickOnDeleteBtn();
           _freelancerPage.ClickOnUploadFile().Should().Be("download.png");
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.CLickOnDeleteAction();
        }

        [When(@"I clicks on Browse file button and upload file")]
        public void WhenIClicksOnBrowseFileButtonAndUploadFile()
        {

        }

        [Then(@"I should see uploaded file under messages section with delete and tag icon")]
        public void ThenIShouldSeeUploadedFileUnderMessagesSectionWithDeleteAndTagIcon()
        {

        }

        [Given(@"I am on a Kolabtree home page")]
        public void GivenIAmOnAKolabtreeHomePage()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ClickOnFindOnanExpert();

        }

        [Given(@"I create a project  with subject area as '(.*)'")]
        public void GivenICreateAProjectWithSubjectAreaAs(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ClickOnSubjectArea();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.EnterSearchText("Sales Marketing");
            Thread.Sleep(utils.timeDelay);

        }

        [When(@"I navigate to '(.*)' page")]
        public void WhenINavigateToPage(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            //_freelancerPage.ClickOnFreelancerTest();
        }

        [Then(@"I should see the profiles display as per '(.*)' under filter applied")]
        public void ThenIShouldSeeTheProfilesDisplayAsPerUnderFilterApplied(string p0)
        {

        }

        [Given(@"I am logged into Kolabtree as a Freelancer")]
        public void GivenIAmLoggedIntoKolabtreeAsAFreelancer()
        {
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.SetEmailInput();
            _logInAsFreelancerPage.SetPasswordInput();
            Thread.Sleep(utils.timeDelay);
            _logInAsFreelancerPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
        }


        [Given(@"Client has performed the fee transfer")]
        public void GivenClientHasPerformedTheFeeTransfer()
        {

        }
        [When(@"I navigate to the '(.*)' page")]
        public void WhenINavigateToThePage(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.ClickOnBillingOn();
        }


        [When(@"I should be received an email with two invoices as an attachment")]
        public void WhenIShouldBeReceivedAnEmailWithTwoInvoicesAsAnAttachment()
        {

        }




    }

}

