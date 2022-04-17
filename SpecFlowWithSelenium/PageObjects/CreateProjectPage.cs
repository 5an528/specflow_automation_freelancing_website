using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.PageObjects
{
    public class CreateProjectPage
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        private By AcceptCookiesButton => By.XPath("//*[@id='cookiescript_accept']");
        private By CreateNewProjectXpath => By.XPath("//button[@type='button']");
        private By ContinuePreviousProjectXpath => By.XPath("//button[contains(text(),'Continue previous project')]");
        private By AllKolabtreeExpertsXpath => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[1]/div[1]/div[3]/div[1]/div/app-privacy/div/div[1]");
        private By ConsultingXpath => By.XPath("//div[@class='text-center tabbox row ng-star-inserted']/div[@class='serviceicon']");
        private By GeneticsAndGenomicsXpath => By.XPath("//div[contains(text(),'Genetics & Genomics')]");
        private By ScientificConsultantsNextXpath => By.XPath("//*[@id='wrapper]/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[3]/div/button[2]");
        private By ProductDevelopmentRadioButtonXpath => By.XPath("//*[@id='mat-radio-2']/label");
        private By FormulationAndDevelopmentXpath => By.XPath("//div[contains(text(),' Technical consulting ')]");
        private By ProductSupportXpath => By.XPath("//div[@class='mat-checkbox-inner-container']");
        private By ProductDevelopmentNextXpath => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[3]/div/button[2]");
        private By NextXpath => By.XPath("//span[contains(text(),'Next')]");
        private By ProjectTitleTextBoxId => By.Id("textboxComponent");
        private By ProjectDescriptionTestBoxId => By.Id("TxtAreaComponent");
        private By PromotionalCodeCheckBoxXpath => By.XPath("//div[@class='mat-checkbox-inner-container']");
        private By PromoCodeTextBoxId => By.Id("promocodetextbox");
        private By ApplyButtonXpath => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[1]/div[2]/div/div[1]/div/app-promotioncode/div[2]/div/div/div[1]/div[1]/span/button");
        private By CouponErrorMsgXpath => By.XPath("//div[@class='error ng-star-inserted']");
        private By CookiesAcceptXpath => By.XPath("//*[@id='cookiescript_accept']");
        private By PromotionAppliedXpath => By.XPath("//span[contains(text(),'Promotion Applied')]");
        private By TAndCLinkText => By.LinkText("T&C");
        private By FixedFeeClass => By.ClassName("fixedfeeicon");
        private By WithinMonthXpath => By.XPath("//div[contains(text(),'Within a month')]");
        private By InviteExpertsXpath => By.XPath("//a[contains(text(),'Invite Experts')]");
        private By ProposalXpath => By.XPath("//*[@id='sidebar-wrapper']/ul/li[6]/a");
        private By HourlyFeeXpath => By.XPath("//div[@class='text-center tabbox']");
        private By PerWeekId => By.Id("EstimatedHoursTypeMaster");
        private By PerMonthXpath => By.XPath("//*[@id='mat-radio-54']");
        private By UploadFileXpath => By.XPath("//*[@id='attachfiles']");
        private By UploadErrorMsgXpath => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[1]/div[2]/div/div[1]/div/app-file-upload-multi-tags/div[2]/div");
        private By RemovedCouponClass => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[1]/div[2]/div/div[1]/div/app-promotioncode/div[2]/div/div/div[2]/div[1]/span");
        private By PrivacySelectError => By.XPath("//div[contains(text(),'Please select at least one option.')]");
        private By PostProjectXpath => By.XPath("//span[contains(text(),'Post Project')]");
        private By TitleMinimumErrorXpath => By.XPath("//div[contains(text(),'Please enter at least 10 characters.')]");
        private By TitleMaximumReachXpath => By.XPath("//span[contains(text(),'Remaining characters: 0/100')]");
        private By DescriptionErrorXpath => By.XPath("//div[contains(text(),'Please enter at least 100 characters.')]");
        private By SubjectAreaErrorXpath => By.XPath("//div[contains(text(),'Please add at least one subject matter expertise.')]");
        private By SelectOptionErrorXpath => By.XPath("//div[contains(text(),'Please select at least one option.')]");
        private By StartingDialogBoxXpath => By.XPath("//mat-dialog-container[@id='mat-dialog-0']");
        private By TaskSelectErrorXpath => By.XPath("//div[contains(text(),'Please select at least one task.')]");
        private By BEcomeanExpertButton => By.XPath("//*[@id='footerMenu']/div[1]/div/div[2]/a");
        private By BrowserNotificationAlertXpath => By.XPath("//button[contains(text(),'OK')]");


        public CreateProjectPage(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }

        private IWebElement ContinuePreviousProject => _browserInteractions.WaitAndReturnElement(ContinuePreviousProjectXpath);
        private IWebElement StartingDialogBox => _browserInteractions.WaitAndReturnElement(StartingDialogBoxXpath);
        private IWebElement SelectOptionError => _browserInteractions.WaitAndReturnElement(SelectOptionErrorXpath);
        private IWebElement SubjectAreaError => _browserInteractions.WaitAndReturnElement(SubjectAreaErrorXpath);
        private IWebElement DescriptionError => _browserInteractions.WaitAndReturnElement(DescriptionErrorXpath);
        private IWebElement TitleMaximumError => _browserInteractions.WaitAndReturnElement(TitleMaximumReachXpath);
        private IWebElement TitleMinimumError => _browserInteractions.WaitAndReturnElement(TitleMinimumErrorXpath);
        private IWebElement PrivacySelectErrorText => _browserInteractions.WaitAndReturnElement(PrivacySelectError);
        private IWebElement RemovedCoupon => _browserInteractions.WaitAndReturnElement(RemovedCouponClass);
        private IWebElement UploadErrorMsg => _browserInteractions.WaitAndReturnElement(UploadErrorMsgXpath);
        private IWebElement UploadFile => _browserInteractions.WaitAndReturnElement(UploadFileXpath);
        private IWebElement PerMonth => _browserInteractions.WaitAndReturnElement(PerMonthXpath);
        private IWebElement HourlyFee => _browserInteractions.WaitAndReturnElement(HourlyFeeXpath);
        private IWebElement PerWeek => _browserInteractions.WaitAndReturnElement(PerWeekId);
        private IWebElement Proposal => _browserInteractions.WaitAndReturnElement(ProposalXpath);
        private IWebElement InviteExpert => _browserInteractions.WaitAndReturnElement(InviteExpertsXpath);
        private IWebElement WithinMonth => _browserInteractions.WaitAndReturnElement(WithinMonthXpath);
        private IWebElement FixedFee => _browserInteractions.WaitAndReturnElement(FixedFeeClass);
        private IWebElement PromotionApplied => _browserInteractions.WaitAndReturnElement(PromotionAppliedXpath);
        private IWebElement TermAndConditions => _browserInteractions.WaitAndReturnElement(TAndCLinkText);
        private IWebElement CookiesAccept => _browserInteractions.WaitAndReturnElement(CookiesAcceptXpath);
        private IWebElement CreateNewProject => _browserInteractions.WaitAndReturnElement(CreateNewProjectXpath);
        private IWebElement AllKolabtreeExperts => _browserInteractions.WaitAndReturnElement(AllKolabtreeExpertsXpath);
        private IWebElement Consulting => _browserInteractions.WaitAndReturnElement(ConsultingXpath);
        private IWebElement GeneticsAndGenomics => _browserInteractions.WaitAndReturnElement(GeneticsAndGenomicsXpath);
        private IWebElement ScientificConsultantsNext => _browserInteractions.WaitAndReturnElement(ScientificConsultantsNextXpath);
        private IWebElement ProductDevelopmentRadioButton => _browserInteractions.WaitAndReturnElement(ProductDevelopmentRadioButtonXpath);
        private IWebElement FormulationAndDevelopment => _browserInteractions.WaitAndReturnElement(FormulationAndDevelopmentXpath);
        private IWebElement ProductSupport => _browserInteractions.WaitAndReturnElement(ProductSupportXpath);
        private IWebElement ProductDevelopmentNext => _browserInteractions.WaitAndReturnElement(ProductDevelopmentNextXpath);
        private IWebElement Next => _browserInteractions.WaitAndReturnElement(NextXpath);
        private IWebElement ProjectTitleTextBox => _browserInteractions.WaitAndReturnElement(ProjectTitleTextBoxId);
        private IWebElement ProjectDescriptionTestBox => _browserInteractions.WaitAndReturnElement(ProjectDescriptionTestBoxId);
        private IWebElement PromotionalCodeCheckBox => _browserInteractions.WaitAndReturnElement(PromotionalCodeCheckBoxXpath);
        private IWebElement PromoCodeTextBox => _browserInteractions.WaitAndReturnElement(PromoCodeTextBoxId);
        private IWebElement ApplyButton => _browserInteractions.WaitAndReturnElement(ApplyButtonXpath);
        private IWebElement CouponErrorMsg => _browserInteractions.WaitAndReturnElement(CouponErrorMsgXpath);
        private IWebElement PostProject => _browserInteractions.WaitAndReturnElement(PostProjectXpath);
        private IWebElement TaskSelectError => _browserInteractions.WaitAndReturnElement(TaskSelectErrorXpath);
        private IWebElement BEcomeanExpert => _browserInteractions.WaitAndReturnElement(BEcomeanExpertButton);
        private IWebElement AcceptCookiesLink => _browserInteractions.WaitAndReturnElement(AcceptCookiesButton);
        private IWebElement BrowserNotificationAlert => _browserInteractions.WaitAndReturnElement(BrowserNotificationAlertXpath);


        public void ClickOnBrowserNotificationAlert()
        {
            BrowserNotificationAlert.Click();
        }
        public void AcceptCookiesClick()
        {
            AcceptCookiesLink.Click();
        }

        public IWebElement BEcomeanExpertClick()
        {
            return BEcomeanExpert;
        }
        public IWebElement getSelectOptionError()
        {
            return SelectOptionError;
        }

        public IWebElement getSubjectAreaError()
        {
            return SubjectAreaError;
        }

        public IWebElement getPromotionTextBox()
        {
            return PromoCodeTextBox;
        }

        public IWebElement getDescriptionError()
        {
            return DescriptionError;
        }

        public bool getPromotionTextBoxAvailable()
        {
            return PromoCodeTextBox.Displayed;
        }

        public string getProjectTitleMaximumReach()
        {
            return TitleMaximumError.Text;
        }

        public string getProjectTitleMinimumError()
        {
            return TitleMinimumError.Text;
        }

        public void clickOnRemovedCoupon()
        {
            RemovedCoupon.Click();
        }

        public void clickOnPostProject()
        {
            // _browserInteractions.WaitAndReturnElement(By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[3]/div/button[2]")).Click();
            PostProject.Click();
        }

        public string getUploadErrorMsg()
        {
            return UploadErrorMsg.Text;
        }

        public ProposalPage GoToProposalPage()
        {
            Proposal.Click();

            return new ProposalPage(_browserInteractions, _browserDriver);
        }

        public void ClickOnInviteExpert()
        {
            InviteExpert.Click();
        }

        public void setUploadFile()
        {
            UploadFile.Click();
            UploadFile.SendKeys("VisualStudioSetup.txt");
        }

        public void ClickOnPerMonth()
        {
            PerMonth.Click();
        }

        public IWebElement getHourlyFee()
        {
            return HourlyFee;
        }

        public void ClickOnPerWeek()
        {
            PerWeek.Click();
        }

        public void ClickOnWithinMonth()
        {
            WithinMonth.Click();
        }

        public void ClickOnFixedFee()
        {
            FixedFee.Click();
        }

        public string GetPromotionAppliedText()
        {
            return PromotionApplied.Text;
        }

        public string GetTermAndConditionText()
        {
            return TermAndConditions.Text;
        }

        public string GetCouponErrorMsg()
        {
            return CouponErrorMsg.Text;
        }
        public void ClickOnApplyButton()
        {
            ApplyButton.Click();
        }

        public string getApplyText()
        {
            return ApplyButton.Text;
        }

        public void ClickOnAcceptCookies()
        {
            CookiesAccept.Click();
        }

        public void SetPromoCodeTextBox(string code)
        {
            PromoCodeTextBox.SendKeys(code);
        }

        public IWebElement getCreateNewProject()
        {
            return CreateNewProject;
        }

        public IWebElement getContinuePreviousproject()
        {
            return ContinuePreviousProject;
        }

        public IWebElement getStartingDialogBox()
        {
            return StartingDialogBox;
        }

        public void ClickOnAllKolabtreeExperts()
        {
            AllKolabtreeExperts.Click();
        }

        public void ClickOnConsulting()
        {
            Consulting.Click();
        }

        public void ClickOnGeneticsAndGenomics()
        {
            GeneticsAndGenomics.Click();
        }

        public void ClickOnNext()
        {
            Next.Click();
        }

        public void ClickOnProductDevelopmentRadioButton()
        {
            ProductDevelopmentRadioButton.Click();
        }

        public void ClickOnFormulationAndDevelopment()
        {
            FormulationAndDevelopment.Click();
        }

        public void ClickOnProductSupport()
        {
            ProductSupport.Click();
        }

        public void SetProjectTitleTextBox(string title)
        {

            ProjectTitleTextBox.SendKeysWithClear(title);
        }

        public void SetProjectDescriptionTestBox(string desc)
        {
            ProjectDescriptionTestBox.SendKeysWithClear(desc);
        }

        public IWebElement getPromotionalCodeCheckBox()
        {
            return PromotionalCodeCheckBox;
        }

        public string GetPrivacyError()
        {
            return PrivacySelectErrorText.Text;
        }
        public string getProjectOneTaskError()
        {
            return TaskSelectError.Text;
        }
    }
}
