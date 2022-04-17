using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.PageObjects
{
    public class CreateAccountPage
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        private By FirstNameId => By.Id("txtCreateAccountFirstName");
        private By LastNameId => By.Id("txtCreateAccountLastName");
        private By EmailId => By.Id("txtCreateAccountEmail");
        private By PasswordId => By.Id("txtCreateAccountPassword");
        private By ContactNumberId => By.Id("createAccountModalContactPhoneNumber");
        private By HowYouHearId => By.Id("ddlClientAttributeHowYouKnew");
        private By OnlineAdXpath => By.XPath("//*[@id='ddlClientAttributeHowYouKnew']/option[2]");
        private By PrivacyPolicyId => By.XPath("//body/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[4]/form[1]/div[8]/div[2]/label[1]");
        private By SubscribeNewLetterId => By.XPath("//label[contains(text(),'Yes, send me useful tips, articles and offers to h')]");
        private By CreateAccountButtonId => By.Id("btnCreateAccount");
        private By CreateProfileId => By.Id("setFreelancingRole");
        private By PhoneNumberErrorMsgXpath => By.XPath("//label[@id='createAccountModal-error-msg']");
        private By SignUpFormXpath => By.XPath("//form[@id='signupform']");
        private By PasswordFieldErrorXpath => By.Id("valCreateAccountPassword");
        private By FirstNameErrorId => By.Id("valCreateAccountFirstName");
        private By LastNameErrorId => By.Id("valCreateAccountLastName");
        private By EmailErrorId => By.Id("valCreateAccountEmail");
        private By CreateProjectId => By.Id("setClientRole");
        private By BusinessEmailErrorId => By.Id("catchBusinessEmailLableOnCreateAccount");
        private By TandCId => By.Id("terms");
        private By PrivacyPolicyLinkId => By.Id("privacy");

        public CreateAccountPage(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }

        private IWebElement PrivacyPolicyLink => _browserInteractions.WaitAndReturnElement(PrivacyPolicyLinkId);
        private IWebElement TandCLink => _browserInteractions.WaitAndReturnElement(TandCId);
        private IWebElement BusinessEmailError => _browserInteractions.WaitAndReturnElement(BusinessEmailErrorId);
        private IWebElement CreateProject => _browserInteractions.WaitAndReturnElement(CreateProjectId);
        private IWebElement EmailError => _browserInteractions.WaitAndReturnElement(EmailErrorId);
        private IWebElement FirstNameError => _browserInteractions.WaitAndReturnElement(FirstNameErrorId);
        private IWebElement LastNameError => _browserInteractions.WaitAndReturnElement(LastNameErrorId);
        private IWebElement PasswordFieldError => _browserInteractions.WaitAndReturnElement(PasswordFieldErrorXpath);
        private IWebElement PhoneNumberErrorMsg => _browserInteractions.WaitAndReturnElement(PhoneNumberErrorMsgXpath);
        private IWebElement CreateProfile => _browserInteractions.WaitAndReturnElement(CreateProfileId);
        private IWebElement FirstName => _browserInteractions.WaitAndReturnElement(FirstNameId);
        private IWebElement LastName => _browserInteractions.WaitAndReturnElement(LastNameId);
        private IWebElement Email => _browserInteractions.WaitAndReturnElement(EmailId);
        private IWebElement Password => _browserInteractions.WaitAndReturnElement(PasswordId);
        private IWebElement ContactNumber => _browserInteractions.WaitAndReturnElement(ContactNumberId);
        private IWebElement HowYouhear => _browserInteractions.WaitAndReturnElement(HowYouHearId);
        private IWebElement OnlineAd => _browserInteractions.WaitAndReturnElement(OnlineAdXpath);
        private IWebElement PrivacyPolicy => _browserInteractions.WaitAndReturnElement(PrivacyPolicyId);
        private IWebElement SubscribeNewLetter => _browserInteractions.WaitAndReturnElement(SubscribeNewLetterId);
        private IWebElement CreateAccountButton => _browserInteractions.WaitAndReturnElement(CreateAccountButtonId);
        private IWebElement SignUpForm => _browserInteractions.WaitAndReturnElement(SignUpFormXpath);

        public string getTermsAndConditionPage()
        {
           //_browserInteractions.SwitchTo().Window(_browserInteractions.WindowHandles[1]);
            return _browserInteractions.GetUrl();
        }

        public IWebElement getTermAndCondition()
        {
            return TandCLink;
        }

        public IWebElement getPrivacyPolicyLink()
        {
            return PrivacyPolicyLink;
        }

        public string getBusinessEmailError()
        {
            return BusinessEmailError.Text;
        }

        public void clickOnCreateProject()
        {
            CreateProject.Click();
        }

        public HomePage clickOnCreateProfile()
        {
            CreateProfile.Click();

            return new HomePage(_browserInteractions, _browserDriver);
        }
        

        public IWebElement getPassword()
        {
            return Password;
        }
        
        public IWebElement getEmail()
        {
            return Email;
        }
        
        public IWebElement getContactNumber()
        {
            return ContactNumber;
        }

        public void clickOnHowYouHear()
        {
            HowYouhear.Click();
            Thread.Sleep(2000);
            OnlineAd.Click();
        } 
        
        public void clickOnPrivacyAndSubscribeCheckbox()
        {
            PrivacyPolicy.Click();
            Thread.Sleep(2000);
            SubscribeNewLetter.Click();
        }

        public void clickOnCreateAccountButton()
        {
            CreateAccountButton.Click();
        }
        
        public void clickOnSignUpForm()
        {
            SignUpForm.Click();
        }

        public string getPhoneNumberErrorMsg()
        {
            return PhoneNumberErrorMsg.Text;
        }
        
        public string getPasswordErrorMsg()
        {
            return PasswordFieldError.Text;
        }

        public IWebElement getPasswordError()
        {
            return PasswordFieldError;
        }
        
        public string getFirstNameErrorMsg()
        {
            return FirstNameError.Text;
        }
        
        public string getLastNameErrorMsg()
        {
            return LastNameError.Text;
        }

        public IWebElement getPhoneNumberError()
        {
            return PhoneNumberErrorMsg;
        }
        
        public string getEmailErrorMsg()
        {
            return EmailError.Text;
        }

        public IWebElement getCreateAccountButton()
        {
            return CreateAccountButton;
        }
       
        public IWebElement getFirstName()
        {
            return FirstName;
        }
        
        public IWebElement getLastName()
        {
            return LastName;
        }

        public IWebElement getPrivacyCheckBox()
        {
            return PrivacyPolicy;
        }
    }
}
