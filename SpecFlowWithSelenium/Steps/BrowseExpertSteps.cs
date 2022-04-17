using FluentAssertions;
using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using SpecFlowWithSelenium.PageObjects;
using SpecFlowWithSelenium.Utils;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Chrome;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public class  BrowseExpertSteps
    {
        private readonly LoginPage _loginPage;
        private readonly HomePage _homePage;
        private readonly BrowseExpertPage _browseExpertPage;
        private readonly CreateProjectPage _createteProjectPage;
        private readonly utils _utils;
        private readonly FreelancerPage _freelancerPage;


        public BrowseExpertSteps(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _loginPage = new LoginPage(browserInteractions, browserDriver);
            _homePage = new HomePage(browserInteractions, browserDriver);
            _freelancerPage = new FreelancerPage(browserInteractions, browserDriver);
            _createteProjectPage = new CreateProjectPage(browserInteractions, browserDriver);
            _browseExpertPage = new BrowseExpertPage(browserInteractions, browserDriver);
            _utils = new utils(browserInteractions, browserDriver);
        }

        [Given(@"I am on '(.*)' page")]
        public void GivenIAmOnPage(string p0)
        {
            _homePage.ClickOnBrowseExpert();
            Thread.Sleep(utils.timeDelay);
        }

        [When(@"'(.*)'s' container is loaded")]
        public void WhenSContainerIsLoaded(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.GetLabelName().Should().Be("Hire a freelance scientist");
        }

        [When(@"I switch to the last pagination page")]
        public void WhenISwitchToTheLastPaginationPage()
        {
            _utils.scrollToElement(_browseExpertPage.LastPage());

            _browseExpertPage.LastPage().Click();
        }

        [Then(@"I should see Previous button available")]
        public void ThenIShouldSeeButtonAvailable()
        {
            _utils.scrollToElement(_browseExpertPage.FirstPage());
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.PreviousPage().Should().Be("<");
        }

        [When(@"I switch to the first pagination page")]
        public void WhenISwitchToTheFirstPaginationPage()
        {
            _browseExpertPage.FirstPage().Click();
        }

        [Then(@"I should see Next page button available")]
        public void ThenIShouldSeeNextPageButtonAvailable()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.NextPage().Should().Be(">");
        }

        [Given(@"user logged in to kolabtree as client")]
        public void GivenUserLoggedInToKolabtreeAsClient()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _loginPage.SetEmailInput("Yourmail");
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();

        }

        [Given(@"user has bid ongoing project")]
        public void GivenUserHasBidOngoingProject()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnBrowse_Expert();
        }

        [Given(@"user is on manage project page")]
        public void GivenUserIsOnManageProjectPage()
        {
            Thread.Sleep(utils.timeDelay);
            _homePage.ReplyClickeProjectClick();
        }

        [When(@"user try to browse file with given extension as \(jpg, \.png, \.mp ,video file, doc, xlsx,pdf,zip,rar,z\)")]
        public void WhenUserTryToBrowseFileWithGivenExtensionAsJpg_Png_MpVideoFileDocXlsxPdfZipRarZ()
        {
        }


        [Then(@"user should see the file should be uploaded in form of  message")]
        public void ThenUserShouldSeeTheFileShouldBeUploadedInFormOfMessage()
        {
            Thread.Sleep(utils.timeDelay);
            _homePage.GetText().Should().Be(" download.png");
        }

        [Given(@"I logged in as client")]
        public void GivenILoggedInAsClient()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _loginPage.SetEmailInput("Yourmail");
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();
        }

        [When(@"I clicks on proposals tab")]
        public void WhenIClicksOnProposalsTab()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnBrowse_Expert();
        }

        [When(@"I select project from dropdown")]
        public void WhenISelectProjectFromDropdown()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.DropDownClick();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.DropDowninputText();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.FirstProjectClick();
        }
        [When(@"I select project from dropdown2")]
        public void WhenISelectProjectFromDropdown2()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.DropDownClick();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.FirstProjectClick();
        }


        [When(@"I should see a message The proposal has been modified. Please accept or reject freelancers changes. under  Fee and Deadline section")]
        public void WhenIShouldSeeAMessageSChanges_FeeAndDeadlineSection()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ModiefiedTextPage().Should().Be("The proposal has been modified. Please accept or reject freelancer's changes.");
        }

        [When(@"I clicks on Reject New deadline button")]
        public void WhenIClicksOnButton()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.RejectDeadlineClick();
        }

        [Then(@"I should see new deadline should not updated under Fee and Deadline section1")]
        public void ThenIShouldSeeNewDeadlineShouldNotUpdatedUnderSection()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.DeadlineCheck().Should().Be("February 08, 2022");
        }

        [When(@"I clicks on accept New deadline button")]
        public void WhenIClicksOnAcceptNewDeadlineButton()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ApproveNewDeadlineClick();
        }

        [Then(@"I should see new deadline should be updated under Fee and Deadline section2")]
        public void ThenIShouldSeeNewDeadlineShouldBeUpdatedUnderFeeAndDeadlineSection()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.DeadlineCheck().Should().Be("February 08, 2022");
        }

        [Given(@"I am logged into as a client with few awarded projects")]
        public void GivenIAmLoggedIntoAsAClientWithFewAwardedProjects()
        {
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _loginPage.SetEmailInput("Yourmail");
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();
        }

        [When(@"I open the workspace")]
        public void WhenIOpenTheWorkspace()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.WorkSpaceXpathLink();
        }

        [When(@"I try to send a message to a freelancer")]
        public void WhenITryToSendAMessageToAFreelancer()
        {
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnAcceptCookies();
            _browseExpertPage.SendTextClick();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.SendTextLink("This is a Test Workspace Message.");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.SendButtonClick();
        }

        [Then(@"I should see a message delivered successfully")]
        public void ThenIShouldSeeAMessageDeliveredSuccessfully()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.AssertTextPage().Should().Be("CONFIDENTIAL");
        }

        [Given(@"user login to Kolabtree existing account as client")]
        public void GivenUserLoginToKolabtreeExistingAccountAsClient()
        {
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _loginPage.SetEmailInput("Yourmail");
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();
        }

        [Given(@"user is having a project under open for proposals state")]
        public void GivenUserIsHavingAProjectUnderOpenForProposalsState()
        {
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnAcceptCookies();
        }

        [Given(@"user navigate to Proposals page and selects the project")]
        public void GivenUserNavigateToProposalsPageAndSelectsTheProject()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ProposalsClick();
        }

        [Given(@"user opens private messages modal on the proposal")]
        public void GivenUserOpensPrivateMessagesModalOnTheProposal()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ReplyClick();
        }

        [Given(@"user enter message as Test Private message")]
        public void GivenUserEnterMessageAsTestPrivateMessage()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.MessageTypeClick();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.MessageTypeClick("This is a Private Test Message!");
        }

        [When(@"user clicks on Send message CTA")]
        public void WhenUserClicksOnSendMessageCTA()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.SendMessageButtonClick();
        }

        [Then(@"user should see the message is sent to freelancer over private message channel")]
        public void ThenUserShouldSeeTheMessageIsSentToFreelancerOverPrivateMessageChannel()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.AssertPrivateTextProve().Should().Be("This is a Private Test Message!");
        }

        [Given(@"user is on Kolabtree as Client")]
        public void GivenUserIsOnKolabtreeAsClient()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _loginPage.SetEmailInput("Yourmail");
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();
        }

        [Given(@"user has project in confirmed state")]
        public void GivenUserHasProjectInConfirmedState()
        {
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnAcceptCookies();
        }

        [Given(@"user navigate to workspace")]
        public void GivenUserNavigateToWorkspace()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.WorkSpaceXpathLink();
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnAcceptCookies();
        }

        [When(@"user try to upload a file except blacklisted file on workspace messaging")]
        public void WhenUserTryToUploadAFileExceptBlacklistedFileOnWorkspaceMessaging()
        {

        }

        [Then(@"user should see file uploaded successfully")]
        public void ThenUserShouldSeeFileUploadedSuccessfully()
        {
            //_browseExpertPage.assterbrowsefileLick().Should().Be("download.png");
            Thread.Sleep(utils.timeDelay);

        }

        [When(@"user try to tag a file")]
        public void WhenUserTryToTagAFile()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOn_fa_fa_deleteBtn();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.TagFileClick();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.TagInputClick("new");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.SaveTagClick();

        }

        [Then(@"user should see file tagged successfully")]
        public void ThenUserShouldSeeFileTaggedSuccessfully()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.NewTagProve().Should().Be("new");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.RemoveTagClick();
        }

        [When(@"I click on delete file button and confirms  delete option")]
        public void WhenIClickOnDeleteFileButtonAndConfirmsDeleteOption()
        {
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.DeleteFileClick();
        }

        [When(@"I clicks on Save button")]
        public void WhenIClicksOnSaveButton()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ConfirmDeleteClick();
        }

        [When(@"I should see that the hyperlink link on file name should get removed")]
        public void WhenIShouldSeeThatTheHyperlinkLinkOnFileNameShouldGetRemoved()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.TestFileDeletedProve().Should().Be("Test removed file");
        }

        [When(@"I click the Log In link I should see Login popup")]
        public void WhenIClickTheLogInLinkIShouldSeeLoginPopup()
        {
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.LoginModalProve().Should().Be("Log in to your account");

        }

        [When(@"I enter correct email address")]
        public void WhenIEnterCorrectEmailAddress()
        {

            _loginPage.SetEmailInput("automation.client@mailinator.com");

        }

        [When(@"I enter correct password")]
        public void WhenIEnterCorrectPassword()
        {

            _loginPage.SetPasswordInput("12QWaszx");
            Thread.Sleep(utils.timeDelay);
        }

        [When(@"I click Sign In button")]
        public void WhenIClickSignInButton()
        {
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
        }

        [Then(@"I should be logged into successfully")]
        public void ThenIShouldBeLoggedIntoSuccessfully()
        {
           //_browseExpertPage.LoggedInProve().Should().Be("  Professional Profile  ");
        }

        [Given(@"user navigates to manage project page")]
        public void GivenUserNavigatesToManageProjectPage()
        {

        }


        [When(@"user open the project")]
        public void WhenUserOpenTheProject()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ProjectDetailsXpathLink();

        }

        [Then(@"user should see public message board present under project details tab")]
        public void ThenUserShouldSeePublicMessageBoardPresentUnderProjectDetailsTab()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.AssertPublicMessageBoardProve().Should().Be("Please use this space to reply to freelancers' questions about the project. These messages are visible to all logged in users.");
        }

        [Then(@"user enters message and send")]
        public void ThenUserEntersMessageAndSend()
        {
            _browseExpertPage.PublicMessageTextAreaClickandSend();

            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.PostMessageClick();

            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);

            _browseExpertPage.PublicMessageTextCheckLinkProve().Should().Be("Test Public message");

        }


        [Given(@"I logged in to kolabtree account as Client")]
        public void GivenILoggedInToKolabtreeAccountAsClient()
        {
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _loginPage.SetEmailInput("Yourmail");
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();

        }

        [Given(@"I click on Billing page tab present on side menu")]
        public void GivenIClickOnBillingPageTabPresentOnSideMenu()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.BillingPageButtonClick();

            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();


        }

        [Given(@"I have funds in my E_Wallet Available balance and Total wallet Balance")]
        public void GivenIHaveFundsInMyE_WalletAvailableBalanceAndTotalWalletBalance()
        {


        }

        [Given(@"I do not have any funds in my committed balance")]
        public void GivenIDoNotHaveAnyFundsInMyCommittedBalance()
        {

        }

        [Given(@"I have confirmed project present in my account with as project fee")]
        public void GivenIHaveConfirmedProjectPresentInMyAccountWithAsProjectFee()
        {

        }

        [Given(@"I clicks on Billing page")]
        public void GivenIClicksOnBillingPage()
        {

        }

        [Given(@"I click on Fund this project button under section")]
        public void GivenIClickOnFundThisProjectButtonUnderSection()
        {
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.AddToFund();

        }

        [Given(@"I see a section Fund this project section opens in side")]
        public void GivenISeeASectionFundThisProjectSectionOpensInSide()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.AddUSDAmount("20");

        }

        [Given(@"I select Pay by card radio button, if not selected")]
        public void GivenISelectPayByCardRadioButtonIfNotSelected()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.CreditDebitCard();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.CardDropdownClick();

        }

        [Given(@"I see the amount is editable in enter the amount field")]
        public void GivenISeeTheAmountIsEditableInEnterTheAmountField()
        {

        }

        [Given(@"I clicks on Select a card drop down and select saved card")]
        public void GivenIClicksOnSelectACardDropDownAndSelectSavedCard()
        {
            Thread.Sleep(utils.timeDelay);

        }

        [When(@"I click on Pay to add funds to wallet button")]
        public void WhenIClickOnPayToAddFundsToWalletButton()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.PayBtnSubmitBtn();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.Clk_History();


        }

        [Then(@"I should see the project is funded with USD")]
        public void ThenIShouldSeeTheProjectIsFundedWithUSD()
        {

        }

        [Then(@"I Should see a successful message displays on screen Your funds are added for the project\.")]
        public void ThenIShouldSeeASuccessfulMessageDisplaysOnScreenYourFundsAreAddedForTheProject_()
        {

        }

        [Then(@"Committed Balance should reflect as USD")]
        public void ThenCommittedBalanceShouldReflectAsUSD()
        {

        }

        [Then(@"Project Wallet Balance under Billing Details should reflect USD")]
        public void ThenProjectWalletBalanceUnderBillingDetailsShouldReflectUSD()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickWalletBalance();

        }

        [Then(@"I should see Total wallet balance increases to USD")]
        public void ThenIShouldSeeTotalWalletBalanceIncreasesToUSD()
        {

        }

        // ..-534

        [Given(@"I have a project '(.*)' posted")]
        public void GivenIHaveAProjectPosted(string p0)
        {
            _homePage.UserClickOnLoginBtn();
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickOnEnterEmail("Yourmail");
            _loginPage.ClickOnEnterPass("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickOnLoginButton();

            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();
            // _homePage.ClickDragOnToggle();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);


        }

        [Given(@"I have Bid(.*) and Bid(.*) bids submitted to project '(.*)'")]
        public void GivenIHaveBidAndBidBidsSubmittedToProject(int p0, int p1, string p2)
        {
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.PressOnProposal();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();

        }

        [When(@"I click '(.*)' button for '(.*)'")]
        public void WhenIClickButtonFor(string p0, string p1)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnTextHire();
            //_browseExpertPage.ClickOnHireACC1ForBid();
            Thread.Sleep(utils.timeDelay);

        }

        [When(@"I confirm '(.*)' message")]
        public void WhenIConfirmMessage(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.EnterTextAreaField("Our researchers publish regularly in academic journals, release projects as open source, and apply research to Google products.");
            Thread.Sleep(utils.timeDelay);



        }

        [Then(@"I should see status should get changed from '(.*)' to '(.*)' for '(.*)'")]
        public void ThenIShouldSeeStatusShouldGetChangedFromToFor(string p0, string p1, string p2)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnHireTest();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
        }

        [Then(@"I should see status should not get changed for '(.*)'")]
        public void ThenIShouldSeeStatusShouldNotGetChangedFor(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ProposalDetails();
            Thread.Sleep(utils.timeDelay);
        }

        [When(@"I open '(.*)' screen on admin dashboard")]
        public void WhenIOpenScreenOnAdminDashboard(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ViewProposal();
        }

        [Then(@"I should see '(.*)' status next to '(.*)'")]
        public void ThenIShouldSeeStatusNextTo(string p0, string p1)
        {

        }

        [Then(@"I should see '(.*)' status next to '(.*)' bid(.*)")]
        public void ThenIShouldSeeStatusNextToBid(string p0, string p1, int p2)
        {

        }

        [Then(@"I should see '(.*)' status next to '(.*)' bid")]
        public void ThenIShouldSeeStatusNextToBid(string p0, string p1)
        {

        }

        //..-2342

        [Given(@"I am on Kolabtree as an existing client")]
        public void GivenIAmOnKolabtreeAsAnExistingClient()
        {
            //Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            _homePage.UserClickOnLoginBtn();
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickOnEnterEmail("Yourmail");
            _loginPage.ClickOnEnterPass("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickOnLoginButton();
            Thread.Sleep(utils.timeDelay);


        }

        [Given(@"I login to my account")]
        public void GivenILoginToMyAccount()
        {
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
        }

        [Given(@"I have more than (.*) projects in created state")]
        public void GivenIHaveMoreThanProjectsInCreatedState(int p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.EnterCreateProject();
            Thread.Sleep(utils.timeDelay);
            //_browseExpertPage.ClickOnNewProjectCard();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.AllExpert();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.Consulting();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClkOnResearchAndDevelopment();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnNextBtn();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickonCosultingFirstClick();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnNextBtn();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickRadioBtn();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnNextBtn();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.EterProjectTilteText("Lorem Ipsum is simply dummy text of the printing and typesetting industry.");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnNextBtn();

            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ProjectDescription();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnNextBtn();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnNextBtn();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.PressDecideLater();

            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.PostOnProject();
        }

        [Given(@"I navigate to any of the pages")]
        public void GivenINavigateToAnyOfThePages()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.InviteExpert();

        }

        [Given(@"I click on '(.*)' modal against any freelancer name")]
        public void GivenIClickOnModalAgainstAnyFreelancerName(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.FreelancerInviteButtonLink();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);


        }

        [Given(@"I can see modal opens")]
        public void GivenICanSeeModalOpens()
        {
        }

        [Given(@"a project is pre selected on the modal")]
        public void GivenAProjectIsPreSelectedOnTheModal()
        {

        }



        [Given(@"I click on '(.*)' button on modal")]
        public void GivenIClickOnButtonOnModal(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.SelectProjectDropDownModalClick();
        }

        [Given(@"I select the project from dropdown")]
        public void GivenISelectTheProjectFromDropdown()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.SelectProjectoneClick();

        }

        [Given(@"I enter a custom message under message Text area as (.*)")]
        public void GivenIEnterACustomMessageUnderMessageTextAreaAs(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.MessagetoFreelancerCustomInputClick();
        }

        [When(@"I click on '(.*)' button")]
        public void WhenIClickOnButton(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.PayBtnSubmitBtn();
        }

        [Then(@"I can see an invite email is sent to freelancer")]
        public void ThenICanSeeAnInviteEmailIsSentToFreelancer()
        {

        }

        [Then(@"A success message reflects on modal")]
        public void ThenASuccessMessageReflectsOnModal()
        {
        }

        [Then(@"count of  freelancer invites out of (.*) shows on modal")]
        public void ThenCountOfFreelancerInvitesOutOfShowsOnModal(int p0)
        {

        }



        [Given(@"user login to Kolabtree as client")]
        public void GivenUserLoginToKolabtreeAsClient()
        {
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _loginPage.SetEmailInput("Yourmail");
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();

            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.BillingPageButtonClick();

            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();

            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickTestProjectTitle();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickPayFreelancer();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickAmountToBeTransfer("100.00");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickPayNowBtn();


        }

        [Given(@"user is having a confirmed fixed fee with VAT funded project")]
        public void GivenUserIsHavingAConfirmedFixedFeeWithVATFundedProject()
        {

        }

        [Given(@"user funded amount is reflecting under '(.*)' wallet")]
        public void GivenUserFundedAmountIsReflectingUnderWallet(string p0)
        {

        }

        [When(@"user performs transfer of funded amount")]
        public void WhenUserPerformsTransferOfFundedAmount()
        {

        }

        [Then(@"user should see Total Wallet balance – by transferred amount")]
        public void ThenUserShouldSeeTotalWalletBalanceByTransferredAmount()
        {

        }

        [Then(@"user available balance gets NA")]
        public void ThenUserAvailableBalanceGetsNA()
        {

        }

        [Then(@"user committed balance gets – by transferred amount")]
        public void ThenUserCommittedBalanceGetsByTransferredAmount()
        {

        }

        [Then(@"user should see freelancer Total Wallet balance \+\+ by \(transferred amount minus Kolabtree service fee of (.*)%\)")]
        public void ThenUserShouldSeeFreelancerTotalWalletBalanceByTransferredAmountMinusKolabtreeServiceFeeOf(int p0)
        {

        }



        [Given(@"user is on Kolabtree client account")]
        public void GivenUserIsOnKolabtreeClientAccount()
        {
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _loginPage.SetEmailInput("Yourmail");
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();
        }

        [Given(@"user click on'Billing"" button")]
        public void GivenUserClickOnBillingButton()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.BillingPageButtonClick();

            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
        }

        [Given(@"user click on a project title")]
        public void GivenUserClickOnAProjectTitle()
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickProjectOnTitle();
        }

        [Given(@"user click on '(.*)'")]
        public void GivenUserClickOn(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickAddOnfund();
        }

        [Given(@"user enter Amount (.*)")]
        public void GivenUserEnterAmount(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnAddProjectFund("10.00");
        }

        [Given(@"user click on '(.*)' radio button")]
        public void GivenUserClickOnRadioButton(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickCredit_Debit_Card();
        }

        [Given(@"user click on '(.*)'button")]
        public void GivenUserClickOnButton(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnCardNumber();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.CLickOnConfirm();
        }

        [Then(@"Total wallet balance will reduce")]
        public void ThenTotalWalletBalanceWillReduce()
        {

        }




        [Given(@"I click on '(.*)' tab present on side menu")]
        public void GivenIClickOnTabPresentOnSideMenu(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnBill();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);

        }

        [Given(@"I dont have any funds in my wallet")]
        public void GivenIDontHaveAnyFundsInMyWallet()
        {

        }

        [Given(@"I clicks on '(.*)' link present on billing page")]
        public void GivenIClicksOnLinkPresentOnBillingPage(string p0)
        {


        }

        [Given(@"I see '(.*)' section opens")]
        public void GivenISeeSectionOpens(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.AddToFund();
        }

        [Given(@"I select '(.*)' radio button option in the section")]
        public void GivenISelectRadioButtonOptionInTheSection(string p0)
        {

        }

        [Given(@"I enter the amount say \$\$ (.*) USD \$\$ in '(.*)' text box")]
        public void GivenIEnterTheAmountSayUSDInTextBox(int p0, string p1)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.AddUSDAmount("10");
        }

        [Given(@"I select a saved card from '(.*)' section")]
        public void GivenISelectASavedCardFromSection(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.CreditDebitCard();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.CardDropdownClick();
        }

        [Given(@"I see '(.*)' updated to USD (.*)")]
        public void GivenISeeUpdatedToUSD(string p0, int p1)
        {

        }

        [Given(@"I see '(.*)' remains to O USD")]
        public void GivenISeeRemainsToOUSD(string p0)
        {

        }

        [Then(@"I should see the funds are added to my E_Wallet")]
        public void ThenIShouldSeeTheFundsAreAddedToMyE_Wallet()
        {

        }

        [Then(@"'(.*)' should reflect as USD (.*)")]
        public void ThenShouldReflectAsUSD(string p0, int p1)
        {

        }

        [Then(@"'(.*)' should reflect as USD (.*), if no project is funded")]
        public void ThenShouldReflectAsUSDIfNoProjectIsFunded(string p0, int p1)
        {

        }

        [Then(@"in the table under '(.*)' column a record of (.*) USD is added in database")]
        public void ThenInTheTableUnderColumnARecordOfUSDIsAddedInDatabase(string p0, int p1)
        {

        }

        [Then(@"in the table under '(.*)' columncord of (.*) USD is added in database")]
        public void ThenInTheTableUnderColumncordOfUSDIsAddedInDatabase(string p0, int p1)
        {

        }

        [Given(@"I login to kolabtree market place from client account")]
        public void GivenILoginToKolabtreeMarketPlaceFromClientAccount()
        {
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _loginPage.SetEmailInput("Yourmail");
            _loginPage.SetPasswordInput("ASDFGHqwerty#12");
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickLoginButton();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnProposalXpath();
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();

        }

        [Given(@"I created a project")]
        public void GivenICreatedAProject()
        {

        }

        [Given(@"I sent a public message from public message board present on '(.*)' page")]
        public void GivenISentAPublicMessageFromPublicMessageBoardPresentOnPage(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnProjectDetails();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickPublicMessageBoard("Lorem Ipsum is simply dummy text of the printing and typesetting industry.");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickPostOnMessage();
            Thread.Sleep(utils.timeDelay);
            /*Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnProposalXpath();*/
        }

        [Given(@"I loggedin to freelancer account")]
        public void GivenILoggedinToFreelancerAccount()
        {


        }

        [Given(@"I naviagted to create bid page for that project")]
        public void GivenINaviagtedToCreateBidPageForThatProject()
        {
            /*  Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickOnHireOnTestAcc1();
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickBidFromTestAcc1TextArea("It is a long established fact that a reader will be distracted.");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.ClickHireTestBtn();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);*/
        }

        [When(@"I click on public '(.*)'")]
        public void WhenIClickOnPublic(string p0)
        {

        }

        [Then(@"I should see message from client received with client name as '(.*)'")]
        public void ThenIShouldSeeMessageFromClientReceivedWithClientNameAs(string p0)
        {

        }

        [Then(@"I should  not see client name")]
        public void ThenIShouldNotSeeClientName()
        {

        }

        [Then(@"I should receive an email with subject line as '(.*)' on freelancer email account")]
        public void ThenIShouldReceiveAnEmailWithSubjectLineAsOnFreelancerEmailAccount(string p0)
        {

        }

        [Given(@"I am on a '(.*)' page")]
        public void GivenIAmOnAPage(string p0)
        {
            _homePage.ClickOnBrowseExpert();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _freelancerPage.AcceptCookiesClick();
        }

        [When(@"'(.*)'s' container is loaded on")]
        public void WhenSContainerIsLoadedOn(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.GetLabelName().Should().Be("Hire a freelance scientist");
        }


        [When(@"I select subject '(.*)' in search filter")]
        public void WhenISelectSubjectInSearchFilter(string p0)
        {
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.EnterSelectSubject("Biophysics");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.EnterSelectSubject("Crystallography");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.EnterSelectSubject("Bioinformatics");
            Thread.Sleep(utils.timeDelay);
            _browseExpertPage.EnterSelectSubject("Structural Biology");




        }

        [When(@"I click '(.*)' button")]
        public void WhenIClickButton(string p0)
        {

        }

        [Then(@"I see more than (.*) subject areas when all of them are matching search filter")]
        public void ThenISeeMoreThanSubjectAreasWhenAllOfThemAreMatchingSearchFilter(int p0)
        {

        }

        [Then(@"the loaded list should reflect as per the profile score from highest to lowest")]
        public void ThenTheLoadedListShouldReflectAsPerTheProfileScoreFromHighestToLowest()
        {

        }





    }
}

