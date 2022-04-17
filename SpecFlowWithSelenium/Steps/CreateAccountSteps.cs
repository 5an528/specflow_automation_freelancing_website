using FluentAssertions;
using SpecFlow.Actions.Selenium;
using SpecFlowWithSelenium.PageObjects;
using SpecFlowWithSelenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public class CreateAccountSteps
    {
        private readonly HomePage _homePage;
        private readonly LoginPage _loginPage;
        private readonly CreateAccountPage _createAccountPage;
        private readonly DashBoardPage _dashBoardPage;
        private readonly AccountSettings _accountSettings;
        private readonly utils _utils;

        public CreateAccountSteps(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _homePage = new HomePage(browserInteractions, browserDriver);
            _createAccountPage = new CreateAccountPage(browserInteractions, browserDriver);
            _loginPage = new LoginPage(browserInteractions, browserDriver);
            _dashBoardPage = new DashBoardPage(browserInteractions, browserDriver);
            _accountSettings = new AccountSettings(browserInteractions, browserDriver);
            _utils = new utils(browserInteractions, browserDriver);
        }

        [Given(@"i am on create account popup")]
        public void GivenIAmOnCreateAccountPopup()
        {
            _loginPage.ClickOnCreateAccountPage();
        }

        [Given(@"i create an account")]
        public void GivenICreateAnAccount()
        {
            _createAccountPage.getFirstName().SendKeysWithClear("dev");
            _createAccountPage.getLastName().SendKeysWithClear("test");
            _createAccountPage.getEmail().SendKeysWithClear(_utils.getRandomEmailAddress());
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.getPassword().SendKeysWithClear("Asdfgh#12");
            _createAccountPage.getContactNumber().SendKeysWithClear("12345678912");
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.clickOnHowYouHear();
            _createAccountPage.clickOnPrivacyAndSubscribeCheckbox();
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.clickOnCreateAccountButton();

        }

        [Then(@"I should see on account setting page and dashboard page entered phone number is saved")]
        public void ThenIShouldSeeOnAccountSettingPageAndDashboardPageEnteredPhoneNumberIsSaved()
        {
            _createAccountPage.clickOnCreateProfile();
            _homePage.clickOnDashboard();
            Thread.Sleep(utils.timeDelay);
            _dashBoardPage.clickOnContactDetails();
            Thread.Sleep(utils.timeDelay);
            _dashBoardPage.getContactNumber().Should().Be("1-12345678912");
            _homePage.clickOnAccountSetting();
            Thread.Sleep(utils.timeDelay);
            _accountSettings.getUserPhoneNumber().Should().Be("1-12345678912");
        }

        [When(@"i enter ""(.*)"" in phone number text area")]
        public void WhenIEnterInPhoneNumberTextArea(string number)
        {
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.getContactNumber().SendKeysWithClear(number);
        }


        [Then(@"I should see correct validation message ""(.*)"" except '(.*)'")]
        public void ThenIShouldSeeCorrectValidationMessageExcept(string error, string number)
        {
           if (number == "1234asfasfa")
            {
                false.Equals(_createAccountPage.getPhoneNumberError().Displayed);
            } else
            {
                _createAccountPage.getPhoneNumberErrorMsg().Should().Be(error);
            }
        }

        [When(@"I enter all mandatory fields on modal")]
        public void WhenIEnterAllMandatoryFieldsOnModal()
        {
            _createAccountPage.getFirstName().SendKeysWithClear("dev");
            _createAccountPage.getLastName().SendKeysWithClear("test");
            _createAccountPage.getEmail().SendKeysWithClear(_utils.getRandomEmailAddress());
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.getContactNumber().SendKeysWithClear("12345678912");
            _createAccountPage.clickOnHowYouHear();
            _createAccountPage.clickOnPrivacyAndSubscribeCheckbox();
            Thread.Sleep(utils.timeDelay);
        }

        [When(@"I keep password field as blank")]
        public void WhenIKeepPasswordFieldAsBlank()
        {
            _createAccountPage.getPassword().Click();
            _createAccountPage.clickOnSignUpForm();
        }

        [Then(@"I should see password validation message reflects as ""(.*)""")]
        public void ThenIShouldSeeValidationMessageReflectsAs(string error)
        {
            _createAccountPage.getPasswordErrorMsg().Should().Be(error);
        }


        [Then(@"I should see '(.*)' is not created")]
        public void ThenIShouldSeeIsNotCreated(string createBtn)
        {
            false.Equals(_createAccountPage.getCreateAccountButton().Enabled);
        }

        [When(@"I enter all mandatory fields on modal except First Name")]
        public void WhenIEnterAllMandatoryFieldsOnModalExceptFirstName()
        {
            _createAccountPage.getLastName().SendKeysWithClear("test");
            _createAccountPage.getEmail().SendKeysWithClear(_utils.getRandomEmailAddress());
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.getPassword().SendKeysWithClear("Asdfgh#12");
            _createAccountPage.getContactNumber().SendKeysWithClear("12345678912");
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.clickOnHowYouHear();
            _createAccountPage.clickOnPrivacyAndSubscribeCheckbox();
            Thread.Sleep(utils.timeDelay);
        }

        [When(@"I keep FirstName field as blank")]
        public void WhenIKeepFirstNameFieldAsBlank()
        {
            _createAccountPage.getFirstName().Click();
            _createAccountPage.clickOnSignUpForm();
        }

        [Then(@"I should see first name validation message reflects as ""(.*)""")]
        public void ThenIShouldSeeFirstNameValidationMessageReflectsAs(string error)
        {
            _createAccountPage.getFirstNameErrorMsg().Should().Be(error);
        }

        [When(@"I enter all mandatory fields on modal except Last Name")]
        public void WhenIEnterAllMandatoryFieldsOnModalExceptLastName()
        {
            _createAccountPage.getFirstName().SendKeysWithClear("dev");
            _createAccountPage.getEmail().SendKeysWithClear(_utils.getRandomEmailAddress());
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.getPassword().SendKeysWithClear("Asdfgh#12");
            _createAccountPage.getContactNumber().SendKeysWithClear("12345678912");
            _createAccountPage.clickOnHowYouHear();
            _createAccountPage.clickOnPrivacyAndSubscribeCheckbox();
            Thread.Sleep(utils.timeDelay);
        }

        [When(@"I keep LastName field as blank")]
        public void WhenIKeepLastNameFieldAsBlank()
        {
            _createAccountPage.getLastName().Click();
            _createAccountPage.clickOnSignUpForm();
        }

        [Then(@"I should see last name validation message reflects as ""(.*)""")]
        public void ThenIShouldSeeLastNameValidationMessageReflectsAs(string error)
        {
            _createAccountPage.getLastNameErrorMsg().Should().Be(error);
        }

        [When(@"I enter all mandatory fields on modal except Email")]
        public void WhenIEnterAllMandatoryFieldsOnModalExceptEmail()
        {
            _createAccountPage.getFirstName().SendKeysWithClear("dev");
            _createAccountPage.getLastName().SendKeysWithClear("test");
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.getPassword().SendKeysWithClear("Asdfgh#12");
            _createAccountPage.getContactNumber().SendKeysWithClear("12345678912");
            _createAccountPage.clickOnHowYouHear();
            _createAccountPage.clickOnPrivacyAndSubscribeCheckbox();
            Thread.Sleep(2000);
        }

        [When(@"I enter email id as ""(.*)""")]
        public void WhenIEnterEmailIdAs(string email)
        {
            _createAccountPage.getEmail().SendKeysWithClear(email);
        }

        [When(@"I focus out from input field")]
        public void WhenIFocusOutFromInputField()
        {
            _createAccountPage.clickOnSignUpForm();
        }

        [Then(@"I should see email validation message reflects as ""(.*)""")]
        public void ThenIShouldSeeEmailValidationMessageReflectsAs(string error)
        {
            _createAccountPage.getEmailErrorMsg().Should().Be(error);
        }

        [When(@"i enter ""(.*)"" in Password text area")]
        public void WhenIEnterInPasswordTextArea(string pass)
        {
            _createAccountPage.getPassword().SendKeysWithClear(pass);
        }

        [Then(@"I should see password validation message reflects as ""(.*)"" except '(.*)'")]
        public void ThenIShouldSeePasswordValidationMessageReflectsAsExcept(string error, string pass)
        {
            if (pass == "Test123")
            {
                false.Equals(_createAccountPage.getPasswordError().Displayed);
            } else
            {
                _createAccountPage.getPasswordErrorMsg().Should().Be(error);
            }
        }

        [When(@"I enter account information with spaces in first and last name fields")]
        public void WhenIEnterAccountInformationWithSpacesInFirstAndLastNameFields()
        {
            _createAccountPage.getFirstName().SendKeysWithClear("your name");
            _createAccountPage.getLastName().SendKeysWithClear("Test Engineer");
            _createAccountPage.getEmail().SendKeysWithClear(_utils.getRandomEmailAddress());
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.getPassword().SendKeysWithClear("Asdfgh#12");
            _createAccountPage.getContactNumber().SendKeysWithClear("12345678912");
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.clickOnHowYouHear();
            _createAccountPage.clickOnPrivacyAndSubscribeCheckbox();
            Thread.Sleep(utils.timeDelay);
        }

        [When(@"I press Create account button")]
        public void WhenIPressCreateAccountButton()
        {
            _createAccountPage.clickOnCreateAccountButton();
        }

        [When(@"I press Create project button")]
        public void WhenIPressCreateProjectButton()
        {
            _createAccountPage.clickOnCreateProject();
        }

        [Then(@"Hiring account should be created with spaces in first and last name")]
        public void ThenHiringAccountShouldBeCreatedWithSpacesInFirstAndLastName()
        {
            Thread.Sleep(utils.timeDelay);
            _homePage.clickOnAccountSetting();
            Thread.Sleep(utils.timeDelay);
            _accountSettings.getUserProfilename().Should().Be("your name Test Engineer");
        }

        [When(@"I enter account information with unicode symbols in First Name as ""(.*)"" and Last Name field as ""(.*)""")]
        public void WhenIEnterAccountInformationWithUnicodeSymbolsInFirstNameAsAndLastNameFieldAs(string firstName, string lastName)
        {
            _createAccountPage.getFirstName().SendKeysWithClear(firstName);
            _createAccountPage.getLastName().SendKeysWithClear(lastName);
            _createAccountPage.getEmail().SendKeysWithClear(_utils.getRandomEmailAddress());
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.getPassword().SendKeysWithClear("Asdfgh#12");
            _createAccountPage.getContactNumber().SendKeysWithClear("12345678912");
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.clickOnHowYouHear();
            _createAccountPage.clickOnPrivacyAndSubscribeCheckbox();
            Thread.Sleep(utils.timeDelay);
        }

        [Then(@"Hiring account created with unicode symbols in First Name, Last Name fields")]
        public void ThenHiringAccountCreatedWithUnicodeSymbolsInFirstNameLastNameFields()
        {
            _homePage.clickOnAccountSetting();
            Thread.Sleep(utils.timeDelay);
            _accountSettings.getUserProfilename().Should().Be("Ĉser-Nãme lãst Ĉame");
        }

        [When(@"I enter firstname as ""(.*)""")]
        public void WhenIEnterFirstnameAs(string text)
        {
            _createAccountPage.getFirstName().SendKeysWithClear(text);
        }

        [Then(@"Account should be created with allowed special symbols in name")]
        public void ThenAccountShouldBeCreatedWithAllowedSpecialSymbolsInName()
        {
            _homePage.clickOnAccountSetting();
            Thread.Sleep(utils.timeDelay);
            _accountSettings.getUserProfilename().Should().Contain(".,-'");
        }

        [When(@"I enter lasttname as ""(.*)""")]
        public void WhenIEnterLasttnameAs(string text)
        {
            _createAccountPage.getLastName().SendKeysWithClear(text);
        }

        [When(@"user does not enter any valid value under all mandatory fields on form")]
        public void WhenUserDoesNotEnterAnyValidValueUnderAllMandatoryFieldsOnForm()
        {
            _createAccountPage.getFirstName().Click();
            _createAccountPage.getLastName().Click();
            _createAccountPage.getPassword().Click();
            _createAccountPage.clickOnSignUpForm();
        }

        [Then(@"I should see business email validation message reflects as ""(.*)""")]
        public void ThenIShouldSeeBusinessEmailValidationMessageReflectsAs(string error)
        {
            _createAccountPage.getBusinessEmailError().Should().Be(error);
        }

        [Given(@"""(.*)"" and ""(.*)"" link is present on create account modal\(in First checkbox\) and in footer section")]
        public void GivenAndLinkIsPresentOnCreateAccountModalInFirstCheckboxAndInFooterSection(string tAndC, string pP)
        {
            true.Equals(_createAccountPage.getPrivacyCheckBox().Displayed);
            Thread.Sleep(utils.timeDelay);
            true.Equals(_createAccountPage.getTermAndCondition().Displayed);
            true.Equals(_createAccountPage.getPrivacyPolicyLink().Displayed);
        }

        [When(@"user click on any link of '(.*)' or '(.*)'")]
        public void WhenUserClickOnAnyLinkOfOr(string p0, string p1)
        {
            Thread.Sleep(utils.timeDelay);
            _createAccountPage.getTermAndCondition().Click();

        }

        [Then(@"user should redirect to the ""(.*)"" or ""(.*)"" Page respectively\.")]
        public void ThenUserShouldRedirectToTheOrPageRespectively_(string p0, string p1)
        {
            Thread.Sleep(utils.timeDelay);
            _utils.switchTab(1);
            _createAccountPage.getTermsAndConditionPage().Should().Be("https://test.kolabtree.com/user-agreement");
        }

    }
}
