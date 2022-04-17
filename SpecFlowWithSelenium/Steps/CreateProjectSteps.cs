using FluentAssertions;
using SpecFlow.Actions.Selenium;
using SpecFlowWithSelenium.Hooks;
using SpecFlowWithSelenium.PageObjects;
using SpecFlowWithSelenium.Utils;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public class CreateProjectSteps
    {
        private readonly HomePage _homePage;
        private readonly CreateProjectPage _createteProjectPage;
        private readonly ProposalPage _proposalPage;
        private readonly utils _utils;
        public string descText = "If you're visiting this page, you're likely here because you're searching for a random sentence. Sometimes a random word just isn't enough, and that is where the random sentence generator comes into play. By inputting the desired number, you can make a list of as many random sentences as you want or need.";

        public CreateProjectSteps(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _homePage = new HomePage(browserInteractions, browserDriver);
            _createteProjectPage = new CreateProjectPage(browserInteractions, browserDriver);
            _proposalPage = new ProposalPage(browserInteractions, browserDriver);
            _utils = new utils(browserInteractions, browserDriver);
        }

        [Given(@"User can switch to Project Owner")]
        public void GivenUserCanSwitchToProjectOwner()
        {
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnBrowserNotificationAlert();
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnToggleProjectOwner();
        }

        [Given(@"User click on Create Project")]
        public void WhenUserClickOnCreateProject()
        {
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnBrowserNotificationAlert();

            _homePage.ClickOnCreateProject();
            try
            {
                _createteProjectPage.getCreateNewProject().Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "Already in new project");
            }
        }

        [Given(@"User reaches to promotion code step")]
        public void WhenUserReachesToPromotionCodeStep()
        {
            _createteProjectPage.ClickOnAllKolabtreeExperts();
            _createteProjectPage.ClickOnConsulting();
            _createteProjectPage.ClickOnAcceptCookies();
            _createteProjectPage.ClickOnGeneticsAndGenomics();
            _createteProjectPage.ClickOnNext();
            //_createteProjectPage.ClickOnProductDevelopmentRadioButton();
            _createteProjectPage.ClickOnFormulationAndDevelopment();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnProductSupport();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.SetProjectTitleTextBox("Test project");
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnNext();
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.SetProjectDescriptionTestBox(descText);
            _createteProjectPage.ClickOnNext();

        }

        [When(@"User Click on Apply Button")]
        public void WhenUserClickOnApplyButton()
        {
            _createteProjectPage.ClickOnApplyButton();
        }

        [Then(@"User should get promo code invalid messaage")]
        public void ThenUserShouldGetPromoCodeInvalidMessaage()
        {
            _createteProjectPage.GetCouponErrorMsg().Should().Be("Coupon is not valid.");
        }

        [Then(@"user should see promo code should get applied")]
        public void ThenUserShouldSeePromoCodeShouldGetApplied()
        {
            _createteProjectPage.GetPromotionAppliedText().Should().Be("Promotion Applied");
        }

        [Then(@"user should see T&C link should be visible for user")]
        public void ThenUserShouldSeeTCLinkShouldBeVisibleForUser()
        {
            _createteProjectPage.GetTermAndConditionText().Should().Be("T&C");
        }

        [When(@"User enter promotion code ""(.*)""")]
        public void WhenUserEnterPromotionCode(string code)
        {
            _createteProjectPage.getPromotionalCodeCheckBox().Click();
            _createteProjectPage.SetPromoCodeTextBox(code);
        }

        [Given(@"User is on fee step")]
        public void GivenUserIsOnFeeStep()
        {
            _createteProjectPage.ClickOnAllKolabtreeExperts();
            _createteProjectPage.ClickOnConsulting();
            _createteProjectPage.ClickOnAcceptCookies();
            _createteProjectPage.ClickOnGeneticsAndGenomics();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnFormulationAndDevelopment();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnProductSupport();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.SetProjectTitleTextBox("Test project");
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.SetProjectDescriptionTestBox(descText);
            _createteProjectPage.ClickOnNext();
        }

        [Given(@"User selects fee type as fixed fee")]
        public void GivenUserSelectsFeeTypeAsFixedFee()
        {
            _createteProjectPage.ClickOnFixedFee();
        }

        [When(@"User successfully post project")]
        public void WhenUserSuccessfullyPostProject()
        {
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnWithinMonth();
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.clickOnPostProject();
            _createteProjectPage.ClickOnInviteExpert();
        }

        [Then(@"User should see on proposal page , fee type should be saved as fixed fee")]
        public void ThenUserShouldSeeOnProposalPageFeeTypeShouldBeSavedAsFixedFee()
        {
            _createteProjectPage.GoToProposalPage();
            _proposalPage.GetFixedFeeType().Should().Be("Fixed fee");
        }

        [Then(@"User should see all entered data should get saved correctly")]
        public void ThenUserShouldSeeAllEnteredDataShouldGetSavedCorrectly()
        {
            //_proposalPage.GetProjectTitle().Should().Be("Test Project");
            _proposalPage.GetProjectService().Should().Be("Consulting");
            _proposalPage.GetProjectExpertise().Should().Be("Genetics & Genomics");
        }

        [Given(@"User selects fee type as Hourly fee")]
        public void GivenUserSelectsFeeTypeAsHourlyFee()
        {
            _createteProjectPage.getHourlyFee().Click();
        }

        [Given(@"User selects Per Week as fee")]
        public void GivenUserSelectsPerWeekAsFee()
        {
            //_createteProjectPage.ClickOnPerWeek();
        }

        [Then(@"User should see on proposal page, fee type should be saved as hourly fee with Per week basis")]
        public void ThenUserShouldSeeOnProposalPageFeeTypeShouldBeSavedAsHourlyFeeWithPerWeekBasis()
        {
            _createteProjectPage.GoToProposalPage();
            _proposalPage.GetHourlyFeeType().Should().Be("Hourly fee");
            _proposalPage.GetPerWeekType().Should().Be("Per Week");
        }

        [Given(@"User selects Per Month as fee")]
        public void GivenUserSelectsPerMonthAsFee()
        {
            _createteProjectPage.ClickOnPerMonth();
        }

        [Then(@"User should see on proposal page, fee type should be saved as hourly fee with Per Month basis")]
        public void ThenUserShouldSeeOnProposalPageFeeTypeShouldBeSavedAsHourlyFeeWithPerMonthBasis()
        {
            _createteProjectPage.GoToProposalPage();
            _proposalPage.GetHourlyFeeType().Should().Be("Hourly fee");
            _proposalPage.GetPerWeekType().Should().Be("Per Month");
        }

        [Given(@"User is on Upload file step")]
        public void GivenUserIsOnUploadFileStep()
        {
            _createteProjectPage.ClickOnAllKolabtreeExperts();
            _createteProjectPage.ClickOnConsulting();
            _createteProjectPage.ClickOnAcceptCookies();
            _createteProjectPage.ClickOnGeneticsAndGenomics();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnFormulationAndDevelopment();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnProductSupport();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.SetProjectTitleTextBox("Test project");
            _createteProjectPage.ClickOnNext();
        }

        [When(@"When user upload a blacklisted file with extension as")]
        public void WhenWhenUserUploadABlacklistedFileWithExtensionAs()
        {
            _createteProjectPage.setUploadFile();
        }

        [Then(@"User should verify validation message")]
        public void ThenUserShouldVerifyValidationMessage()
        {
            _createteProjectPage.getUploadErrorMsg().Should().Be("VisualStudioSetup.exe is not allowed.");
        }

        [When(@"User go to Project title page")]
        public void WhenUserGoToProjectTitlePage()
        {
            _createteProjectPage.ClickOnAllKolabtreeExperts();
            _createteProjectPage.ClickOnConsulting();
            _createteProjectPage.ClickOnGeneticsAndGenomics();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnFormulationAndDevelopment();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnProductSupport();
            _createteProjectPage.ClickOnNext();
        }

        [When(@"User enter Other languages")]
        public void WhenUserEnterOtherLanguages()
        {
            _createteProjectPage.SetProjectTitleTextBox("বাংলাবাংলাবাংলা");
        }

        [When(@"User can create project successfully")]
        public void WhenUserCanCreateProjectSuccessfully()
        {
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.SetProjectDescriptionTestBox(descText);
            _createteProjectPage.ClickOnNext();
            Thread.Sleep(2000);
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnWithinMonth();
            _createteProjectPage.clickOnPostProject();
            _createteProjectPage.ClickOnInviteExpert();
        }

        [Then(@"User should verify project title")]
        public void ThenUserShouldVerifyProjectTitle()
        {
            _createteProjectPage.GoToProposalPage();
            _proposalPage.GetProjectTitle().Should().Be("বাংলাবাংলাবাংলা");
        }

        [When(@"User can click on remove coupon")]
        public void WhenUserCanClickOnRemoveCoupon()
        {
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.clickOnRemovedCoupon();
        }

        [Then(@"User should verify coupon remove")]
        public void ThenUserShouldVerifyCouponRemove()
        {
            _createteProjectPage.getApplyText().Should().Be("Apply");
        }

        [Given(@"User Accept cookies")]
        public void WhenUserAcceptCookies()
        {
            _createteProjectPage.ClickOnAcceptCookies();
        }


        [When(@"User click on Next")]
        public void WhenUserClickOnNext()
        {
            _createteProjectPage.ClickOnNext();
        }

        [Then(@"User should verify ""(.*)"" error message")]
        public void ThenUserShouldVerifyErrorMessage(string error)
        {
            _createteProjectPage.GetPrivacyError().Should().Be(error);
        }

        [When(@"User enter ""(.*)"" as project title")]
        public void WhenUserEnterAsProjectTitle(string title)
        {
            _createteProjectPage.SetProjectTitleTextBox(title);
        }

        [Then(@"User should verify Please enter at least (.*) characters error in title field")]
        public void ThenUserShouldVerifyPleaseEnterAtLeastCharactersErrorInTitleField(int p0)
        {
            _createteProjectPage.getProjectTitleMinimumError().Should().Be("Please enter at least 10 characters.");
        }

        [Then(@"User should see remaining characters should show as '(.*)'")]
        public void ThenUserShouldSeeRemainingCharactersShouldShowAs(int value)
        {
            _createteProjectPage.getProjectTitleMaximumReach().Should().Be("Remaining characters: 0/100");
        }

        [Given(@"User should not see promotion code text area")]
        public void GivenUserShouldNotSeePromotionCodeTextArea()
        {
            //Assert.False(_createteProjectPage.getPromotionTextBoxAvailable());
            // _createteProjectPage.getPromotionTextBox();
        }

        [When(@"User selects promo code check box")]
        public void WhenUserSelectsPromoCodeCheckBox()
        {
            _createteProjectPage.getPromotionalCodeCheckBox().Click();
        }

        [Then(@"User should see promotion code text area to enter promo code")]
        public void ThenUserShouldSeePromotionCodeTextAreaToEnterPromoCode()
        {
            Assert.True(_createteProjectPage.getPromotionTextBoxAvailable());
        }

        [When(@"User  navigate to promotion code step in CP form")]
        public void WhenUserNavigateToPromotionCodeStepInCPForm()
        {
            true.Equals(_createteProjectPage.getHourlyFee().Displayed);
        }

        [Then(@"User should see promo code check box is displayed")]
        public void ThenUserShouldSeePromoCodeCheckBoxIsDisplayed()
        {
            true.Equals(_createteProjectPage.getPromotionalCodeCheckBox().Displayed);
        }

        [Given(@"User reaches to Project description step")]
        public void GivenUserReachesToProjectDescriptionStep()
        {
            _createteProjectPage.ClickOnAllKolabtreeExperts();
            _createteProjectPage.ClickOnConsulting();
            _createteProjectPage.ClickOnAcceptCookies();
            _createteProjectPage.ClickOnGeneticsAndGenomics();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnFormulationAndDevelopment();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnProductSupport();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.SetProjectTitleTextBox("Test project");
            _createteProjectPage.ClickOnNext();
        }

        [When(@"User enter less than (.*) characters in project description field")]
        public void WhenUserEnterLessThanCharactersInProjectDescriptionField(int p0)
        {
            _createteProjectPage.SetProjectDescriptionTestBox("asdfghjlyuiutyevrtrcerrrrrrrrrrrrrrrrrrrrrrrrdf");
            _createteProjectPage.ClickOnNext();
        }

        [Then(@"user should see validation message reflects as ""(.*)""")]
        public void ThenUserShouldSeeValidationMessageReflectsAs(string error)
        {
            _createteProjectPage.getDescriptionError().Text.Should().Be(error);
        }

        [Given(@"User reaches to subject area expertise step")]
        public void GivenUserReachesToSubjectAreaExpertiseStep()
        {
            _createteProjectPage.ClickOnAllKolabtreeExperts();
            _createteProjectPage.ClickOnConsulting();
            _createteProjectPage.ClickOnAcceptCookies();

        }

        [When(@"User clicks on next step button without selecting")]
        public void WhenUserClicksOnNextStepButtonWithoutSelecting()
        {
            _createteProjectPage.ClickOnNext();
        }

        [Then(@"User should see subject area validation message reflects as ""(.*)""")]
        public void ThenUserShouldSeeSubjectAreaValidationMessageReflectsAs(string error)
        {
            _createteProjectPage.getSubjectAreaError().Text.Should().Be(error);
        }

        [Given(@"User reaches By when do you need to hire a freelancer\? step")]
        public void GivenUserReachesByWhenDoYouNeedToHireAFreelancerStep()
        {

            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnBrowserNotificationAlert();
            _createteProjectPage.ClickOnAllKolabtreeExperts();
            _createteProjectPage.ClickOnConsulting();
            _createteProjectPage.ClickOnAcceptCookies();
            _createteProjectPage.ClickOnGeneticsAndGenomics();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnFormulationAndDevelopment();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnProductSupport();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.SetProjectTitleTextBox("Test project");
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.SetProjectDescriptionTestBox(descText);
            _createteProjectPage.ClickOnNext();
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnNext();

        }

        [When(@"User clicks post project button without selecting")]
        public void WhenUserClicksPostProjectButtonWithoutSelecting()
        {
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnBrowserNotificationAlert();
            _createteProjectPage.clickOnPostProject();
        }


        [Then(@"User should verify validation message reflects as ""(.*)""")]
        public void ThenUserShouldVerifyValidationMessageReflectsAs(string error)
        {
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnBrowserNotificationAlert();
            _createteProjectPage.getSelectOptionError().Text.Should().Be(error);
        }

        [Given(@"User navigate to new CP form url /create-project")]
        public void GivenUserNavigateToNewCPFormUrlCreate_Project()
        {
            _homePage.ClickOnCreateProject();
        }

        [Given(@"User see two options display as '(.*)'and '(.*)' on modal")]
        public void GivenUserSeeTwoOptionsDisplayAsAndOnModal(string p0, string p1)
        {
            true.Equals(_createteProjectPage.getCreateNewProject().Displayed);
            true.Equals(_createteProjectPage.getContinuePreviousproject().Displayed);
        }

        [When(@"User clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string p0)
        {
            _createteProjectPage.getContinuePreviousproject().Click();
        }

        [Then(@"User should not see system error message alert and user should be able to continue previous project")]
        public void ThenUserShouldNotSeeSystemErrorMessageAlertAndUserShouldBeAbleToContinuePreviousProject()
        {
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnNext();
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnNext();
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnNext();
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnNext();
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnNext();
            Thread.Sleep(utils.timeDelay);
            _createteProjectPage.ClickOnNext();
            Thread.Sleep(utils.timeDelay);
        }

        [Given(@"User reaches service catagory step")]
        public void GivenUserReachesServiceCatagoryStep()
        {
            _createteProjectPage.ClickOnAllKolabtreeExperts();
            _createteProjectPage.ClickOnConsulting();
            _createteProjectPage.ClickOnAcceptCookies();
            _createteProjectPage.ClickOnGeneticsAndGenomics();
            _createteProjectPage.ClickOnNext();
            _createteProjectPage.ClickOnFormulationAndDevelopment();
            _createteProjectPage.ClickOnNext();
        }

        [When(@"User clicks post project button without selecting One Task")]
        public void WhenUserClicksPostProjectButtonWithoutSelectingOneTask()
        {
            _createteProjectPage.ClickOnNext();
        }

        [Then(@"User should verify Please select at least on task")]
        public void ThenUserShouldVerifyPleaseSelectAtLeastOneTask()
        {
            _createteProjectPage.getProjectOneTaskError().Should().Be("Please select at least one task.");
        }


    }
}
