using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.PageObjects
{
    class FreelancerPage
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        private By FreelancerPageButton => By.XPath("//*[@id='pageMainHeader']/div/ul[2]/li[3]/div/div/label/span[1]");
        private By AcceptCookiesButton => By.XPath("//*[@id='cookiescript_accept']");
        private By BrowseProjectButton => By.XPath("//*[@id='sidebar-wrapper']/ul/li[6]/a");
        private By ViewDetailsButton => By.XPath("//*[@id='page-content-wrapper-1']/div/div/div[6]/div/div[1]/div/div[3]/div/div[2]/div[5]/div/div/a");
        private By PublicMessageBoardButton => By.XPath("//a[@id='publicmessage']");
        private By TestBoxSentKey => By.XPath("//textarea[@class='form-control']");
        private By AskQuestionButton => By.XPath("//*[@id='public-project-discussion']/div[1]/div[2]/div[2]/button");
        private By MessageComment => By.XPath("//*[@id='ProjectForumMessages']/li[1]/div[2]/div/p[3]");
        private By ScrollUpButton => By.XPath("//*[@id='tab']/li[1]/a");
        private By ProposalTabButton => By.XPath("//*[@id='sidebar-wrapper']/ul/li[7]/a");
        private By TextAreaButton => By.XPath("//*[@id='MessageText']");
        private By SendMessageButton => By.XPath("//*[@id='TextFileSectionModal']/div[5]/div[4]/button");
        private By CheckforMessage => By.XPath("//*[@id='TextFileSectionModal']/div[2]/span");
        private By WorkspaceButton => By.XPath("//a[@class='col-md-12 col-sm-12 col-xs-12 no-padding']");
        private By WorkspaceTextArea => By.XPath("//*[@id='MessageText']");
        private By WorkspaceTextSendButton => By.XPath("//button[@class='btn pull-right SendMessageBtn green_btn proximanova-semibold-14px']");
        private By WorkspaceTextCheck => By.XPath("//*[@id='MessagesContainer']/div[3]/div/div[1]/div[1]/p[1]");
        private By UploadedFileXpath => By.XPath("//a[contains(text(),'download.png')]");
        private By DeleteUploadXpath => By.XPath("//*[@id='Messages']/div[33]/div/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/a/i");//manual change needed
        private By ConfirmDeleteXpath => By.XPath("//*[@id='modalDanger']/div/div/div/div[2]/p");
        private By DeleteOKXpath => By.XPath("//*[@id='modalDanger']/div/div/div/div[3]/div/button[1]");
        private By TestRemovedXpath => By.XPath("//a[contains(text(),'removed file')]");
        private By UploadfileXpath => By.XPath("//*[@id='Messages']/div[34]/div/div[1]/div[1]/div[1]/div[1]/a");
        private By BEcomeanExpertButton => By.XPath("//*[@id='footerMenu']/div[1]/div/div[2]/a");
        private By CreateAccountModalXpath => By.XPath("//*[@id='CustomMessageOnModal']");
        private By TwitterXpath => By.XPath("//*[@id='footerMenu']/div[4]/div[2]/a[2]");
        private By FacebookXpath => By.XPath("//*[@id='footerMenu']/div[4]/div[2]/a[3]");
        private By LinkedInXpath => By.XPath("//*[@id='footerMenu']/div[4]/div[2]/a[4]");
        private By HireStatisticianXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[1]/a");
        private By ScientistXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[2]/a");
        private By FoodScientistXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[3]/a");
        private By HealthEconomistXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[4]/a");
        private By DataScientistXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[5]/a");
        private By MedicalWriterXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[6]/a");
        private By ResearcherXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[7]/a");
        private By HireDataScientistXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[8]/a");
        private By ChemistXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[9]/a");
        private By BiostatisticianXpath => By.XPath("//*[@id='footerMenu']/div[3]/ul/li[10]/a");
        private By HomeClickXpath => By.XPath("//*[@id='footerMenu']/div[7]/div[1]/a[1]");
        private By SuccessStoriesXpath => By.XPath("//*[@id='footerMenu']/div[7]/div[1]/a[3]");
        private By AboutUsXpath => By.XPath("//*[@id='footerMenu']/div[7]/div[1]/a[2]");
        private By ValidAddressXpath => By.XPath("//*[@id='footerMenu']/div[4]/div[3]/address/p[2]");
        private By FrequentlyAskedQuestionXpath => By.XPath("//*[@id='faqid']/div[2]/p/u/a");
        private By LogInProveXpath => By.XPath("//*[@id='pageMainHeader']/div/ul[1]/li[2]/label");
        private By HourlyFeeProveXpath => By.XPath("//*[@id='page-content-wrapper-1']/div/div/div[6]/div/div[1]/div/div[3]/div/div[1]/div[1]/div[3]/div[3]/div[2]/span[3]");
        private By HomepageBackXpath => By.XPath("//*[@id='logo-top']");
        private By ViewDetailsXpath => By.XPath("//*[@id='page-content-wrapper-1']/div/div/div[6]/div/div[1]/div/div[3]/div/div[1]/div[5]/div/div/a");
        private By LoginModalXpath => By.XPath("//*[@id='CustomMessageOnModal']");
        private By ProposalSummaryXpath => By.XPath("//*[@id='proposalSummary']");
        private By EnterFeeAndDeadlineXpath => By.XPath("//*[@id='NextFeeandDeadline']");
        private By ProposedHourlyFeeXpath => By.XPath("//*[@id='txtTotalFee']");
        private By NumberOfHoursXpath => By.XPath("//*[@id='txtNoOfHours']");
        private By AddDatesXpath => By.XPath("//*[@id='bid-form']/div[2]/div[3]/div/div[19]/div/div[1]/span");
        private By NextDateXpath => By.XPath("/html/body/div[3]/div[3]/table/tbody/tr[3]/td[5]");
        private By CreateProposalXpath => By.XPath("//*[@id='submit-bid-button']");
        private By ProposalPageProveXpath => By.XPath("//*[@id='pageMainHeader']/div/ul[1]/li[2]/label");
        private By HourlyFeeProveInPrposalPageXpath => By.XPath("//*[@id='EditableHourlyRate']");
        private By HourlyFeesProveInPrposalPageXpath => By.XPath("//*[@id='EditableTotalFees']");
        private By NumberofHourProveInPrposalPageXpath => By.XPath("//*[@id='EditableNoOfHours']");
        private By FixedFeeXpath => By.XPath("//*[@id='page-content-wrapper-1']/div/div/div[6]/div/div[1]/div/div[3]/div/div[2]/div[1]/div[3]/div[3]/div[2]/span[2]");
        private By FixedFeeDateXpath => By.XPath("//*[@id='bid-form']/div[2]/div[3]/div/div[18]/div/div[1]/span");
        private By FixedFeeNextDateXpath => By.XPath("/html/body/div[2]/div[3]/table/tbody/tr[3]/td[5]");
        private By assterbrowsefileXpath => By.XPath("//*[@id='Messages']/div[1]/div/div[2]/div[1]/div[2]/a");
        private By WorkspaceAssertbrowsefileXpath => By.XPath("//*[@id='Messages']/div[25]/div/div[1]/div[1]/div[1]/div[1]/a");
        private By TagFileXpath => By.XPath("//*[@id='Messages']/div[1]/div/div[2]/div[1]/div[4]/div[3]/div[2]/a");
        private By WorkspaceTagFileXpath => By.XPath("//*//*[@id='Messages']/div[25]/div/div[1]/div[1]/div[1]/div[2]/div[3]/div[2]/a");
        private By TagInputXpath => By.XPath("//*[@id='Messages']/div[1]/div/div[2]/div[1]/div[4]/div[2]/div/input");
        private By WorkspaceTagInputXpath => By.XPath("//*[@id='Messages']/div[25]/div/div[1]/div[1]/div[1]/div[2]/div[2]/div/input");
        private By SaveTagXpath => By.XPath("//*[@id='Messages']/div[1]/div/div[2]/div[1]/div[4]/div[2]/div/button[1]");
        private By WorkspaceSaveTagXpath => By.XPath("//*[@id='Messages']/div[25]/div/div[1]/div[1]/div[1]/div[2]/div[2]/div/button[1]");
        private By NewTagXpath => By.XPath("//*[@id='Messages']/div[1]/div/div[2]/div[1]/div[4]/div[1]/span/span");
        private By WorkspaceTagXpath => By.XPath("//*[@id='Messages']/div[25]/div/div[1]/div[1]/div[1]/div[2]/div[1]/span/span");
        private By RemoveTagXpath => By.XPath("//*[@id='Messages']/div[1]/div/div[2]/div[1]/div[4]/div[1]/span/a/i");
        private By WorkspaceRemoveTagXpath => By.XPath("//*[@id='Messages']/div[25]/div/div[1]/div[1]/div[1]/div[2]/div[1]/span/a");
        private By ProjectTitleXpath => By.XPath("//*[@id='project-title']");
        private By CatagoryXpath => By.XPath("//*[@id='projectdetailsrow']/div[2]/label");
        private By SubCatagoryXpath => By.XPath("//*[@id='projectdetailsrow']/div[3]/label");
        private By TasksDeliverablesXpath  => By.XPath("//*[@id='projectdetailsrow']/div[4]/label");
        private By ProjectDescriptionXpath  => By.XPath("//*[@id='project-detail-review']/div/div/div/div[1]/div/div[2]/div[1]/label");
        private By ExpertiserequiredXpath  => By.XPath("//*[@id='project-detail-review']/div/div/div/div[1]/div/div[2]/div[2]/div/label");
        private By FeeTypeXpath  => By.XPath("//*[@id='project-detail-review']/div/div/div/div[2]/div/div[2]/div/div[1]/label/span[1]");
        private By Feexapth  => By.XPath("//*[@id='project-detail-review']/div/div/div/div[2]/div/div[2]/div/div[2]/label/span[1]");
        private By FeexPerMonthXapth  => By.XPath("//*[@id='EstimatedHoursTypeMaster']");
        private By TimelineforHiringXpath  => By.XPath("//*[@id='project-detail-review']/div/div/div/div[3]/div/div[1]");
        private By ProjectsHomepageXpath  => By.XPath("//*[@id='BrowseProjects']");
        private By FindAnExpertXpath  => By.XPath("//*[@id='findAnExpertMenu']");
        private By HowItWorksXpath  => By.XPath("//*[@id='responsive']/ul/li[1]/a");
        private By SolutionsXpath  => By.XPath("//*[@id='industryMenu']");
        private By PharmaceuticalsXpath => By.XPath("//*[@id='responsive']/ul/li[5]/ul/li[5]/a");
        private By ServiceXpath => By.XPath("//*[@id='servicesMenu']");
        private By MedicalWritingXpath => By.XPath("//*[@id='responsive']/ul/li[6]/ul/li[6]/a");
        private By BecomeExpertXpath => By.XPath("//*[@id='responsive']/div[3]/a[1]");
        private By LogInModalXpath => By.XPath("//*[@id='login-modal']/div/div/div[1]/div[2]/ul/li[1]/a");
        private By CloseLogInModalXpath => By.XPath("//*[@id='closeLoginModal']");
        private By RequestAServiceXpath => By.XPath("//*[@id='responsive']/div[3]/a[3]");
        private By CreateProjectProveXpath => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[3]/div[1]/div/span");
        private By DelectIconProposalPageXpath => By.XPath("//*[@id='Messages']/div[1]/div/div[2]/div[1]/div[4]/div[3]/div[1]");
        private By CustomMessageModalXpath => By.XPath("//*[@id='custombody']/p");
        private By ClickonOKinProposalPageXpath => By.XPath("//*[@id='FreelancerProposals']/div/div[4]/app-freelancerproposaltab/div[7]/div/div/div/div[3]/div/button[1]");
        private By CheckifFlieRemovedXpath => By.XPath("//*[@id='Messages']/div[1]/div/div[2]/div/div/div/span[1]");
        private By TextRemoveCheckProposalPageXpath => By.XPath("//div[contains(text(),' removed file :')]");
        private By FindExterMoreButtonXpath => By.XPath("//*[@id='page-content-wrapper']/div/div/div[10]/div[1]/div[2]/div/div[2]/div[5]");
        private By InstitutionInputXpath => By.XPath("//*[@id='s2id_autogen3']");
        private By SelectUniversityList1Xpath => By.XPath("//*[@id='select2-drop']/ul/li[1]");
        private By UniversityProveXpath => By.XPath("//*[@id='expert-container']/div[1]/div[1]/div[2]/div[4]/div/div[1]/div[2]/strong");
        private By CountryClickXpath => By.XPath("//*[@id='dLabel']");
        private By EnterACountryNameXpath => By.XPath("//*[@id='s2id_autogen2']");
        private By CountryProveXpath => By.XPath("//*[@id='expert-container']/div[1]/div[1]/div[2]/div[2]/div[2]/span");
        private By SubjectAreasXpath => By.XPath("//*[@id='dLabel']");
        private By EnterSubjectAreaXpath => By.XPath("//*[@id='s2id_autogen1']");
        private By WorkSpaceBtn => By.XPath("//*[@id='sidebar-wrapper']/ul/li[8]/a/span");
        private By AcceptCookiesBtn => By.XPath("//*[@id='cookiescript_accept']");
        private By BrowseFilesBtn => By.XPath("//*[@id='wrapper']/div/app-workspace/div[4]/div[1]/div/div[3]/div[1]/div[3]/div[2]/div/div[5]/div[3]/div[1]/span");
        private By UploadFilesBox => By.XPath("//*[@id='ajax-upload-id-1647748887246']");

        private By BlogXpath => By.Id("blog-link-footer");
        private By DeleteBtn => By.XPath("//*[@id='Messages']/div[37]/div/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/a/i");
        private By DeleteActionXpath => By.XPath("//*[@id='modalDanger']/div/div/div/div[3]/div/button[1]");
        private By FindanExpertXpath => By.XPath("//a[@id='findAnExpertMenu']");
        private By SubjectAreaXpath => By.XPath("//a[contains(text(),'Subject Areas')]");
        private By SearchOnSubjectAreaXpath => By.XPath("//input[@id='s2id_autogen1']");
        private By FreelancerTestXpath => By.XPath("//a[contains(text(),'Freelancer Test')]");
        private By BillingOnXpath => By.XPath("//span[contains(text(),'Billing')]");

        public FreelancerPage(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }


        private IWebElement BillingOn => _browserInteractions.WaitAndReturnElement(BillingOnXpath);
        private IWebElement FreelancerTest => _browserInteractions.WaitAndReturnElement(FreelancerTestXpath);
         private IWebElement SearchOnSubjectArea => _browserInteractions.WaitAndReturnElement(SearchOnSubjectAreaXpath);
        private IWebElement SubjectArea => _browserInteractions.WaitAndReturnElement(SubjectAreaXpath);
        private IWebElement FindOnanExpert => _browserInteractions.WaitAndReturnElement(FindanExpertXpath);
        private IWebElement FreelancerPageLink => _browserInteractions.WaitAndReturnElement(FreelancerPageButton);
        private IWebElement AcceptCookiesLink => _browserInteractions.WaitAndReturnElement(AcceptCookiesButton);
        private IWebElement BrowseProjectLink => _browserInteractions.WaitAndReturnElement(BrowseProjectButton);
        private IWebElement ViewDetailsLink => _browserInteractions.WaitAndReturnElement(ViewDetailsButton);
        private IWebElement PublicMessageBoardLink => _browserInteractions.WaitAndReturnElement(PublicMessageBoardButton);
        private IWebElement TestBoxLink => _browserInteractions.WaitAndReturnElement(TestBoxSentKey);
        private IWebElement AskQuestionLink => _browserInteractions.WaitAndReturnElement(AskQuestionButton);
        private IWebElement MessageCommentLink => _browserInteractions.WaitAndReturnElement(MessageComment);
        private IWebElement ScrollUpLink => _browserInteractions.WaitAndReturnElement(ScrollUpButton);
        private IWebElement ProposalTabLink => _browserInteractions.WaitAndReturnElement(ProposalTabButton);
        private IWebElement TextAreaLink => _browserInteractions.WaitAndReturnElement(TextAreaButton);
        private IWebElement SendMessageLink => _browserInteractions.WaitAndReturnElement(SendMessageButton);
        private IWebElement CheckforMessageLink => _browserInteractions.WaitAndReturnElement(CheckforMessage);
        private IWebElement WorkspaceButtonLink => _browserInteractions.WaitAndReturnElement(WorkspaceButton);
        private IWebElement WorkspaceTextAreaLink => _browserInteractions.WaitAndReturnElement(WorkspaceTextArea);
        private IWebElement WorkspaceTextSendButtonLink => _browserInteractions.WaitAndReturnElement(WorkspaceTextSendButton);
        private IWebElement WorkspaceTextCheckLink => _browserInteractions.WaitAndReturnElement(WorkspaceTextCheck);
        private IWebElement UploadedFile => _browserInteractions.WaitAndReturnElement(UploadedFileXpath);
        private IWebElement DeleteUpload => _browserInteractions.WaitAndReturnElement(DeleteUploadXpath);
        private IWebElement ConfirmDelete => _browserInteractions.WaitAndReturnElement(ConfirmDeleteXpath);
        private IWebElement DeleteOK => _browserInteractions.WaitAndReturnElement(DeleteOKXpath);
        private IWebElement TestRemoved => _browserInteractions.WaitAndReturnElement(TestRemovedXpath);
        private IWebElement BlogId => _browserInteractions.WaitAndReturnElement(BlogXpath);
        private IWebElement BEcomeanExpert => _browserInteractions.WaitAndReturnElement(BEcomeanExpertButton);
        private IWebElement CreateAccountModal => _browserInteractions.WaitAndReturnElement(CreateAccountModalXpath);
        private IWebElement TwitterButton => _browserInteractions.WaitAndReturnElement(TwitterXpath);
        private IWebElement FacebookButton => _browserInteractions.WaitAndReturnElement(FacebookXpath);
        private IWebElement LinkedInButton => _browserInteractions.WaitAndReturnElement(LinkedInXpath);
        private IWebElement Biostatistician => _browserInteractions.WaitAndReturnElement(BiostatisticianXpath);
        private IWebElement HireStatistician => _browserInteractions.WaitAndReturnElement(HireStatisticianXpath);
        private IWebElement Scientist => _browserInteractions.WaitAndReturnElement(ScientistXpath);
        private IWebElement FoodScientist => _browserInteractions.WaitAndReturnElement(FoodScientistXpath);
        private IWebElement HealthEconomist => _browserInteractions.WaitAndReturnElement(HealthEconomistXpath);
        private IWebElement DataScientist => _browserInteractions.WaitAndReturnElement(DataScientistXpath);
        private IWebElement MedicalWriter => _browserInteractions.WaitAndReturnElement(MedicalWriterXpath);
        private IWebElement Researcher => _browserInteractions.WaitAndReturnElement(ResearcherXpath);
        private IWebElement HireDataScientist => _browserInteractions.WaitAndReturnElement(HireDataScientistXpath);
        private IWebElement Chemist => _browserInteractions.WaitAndReturnElement(ChemistXpath);
        private IWebElement HomepageBack => _browserInteractions.WaitAndReturnElement(HomepageBackXpath);
        private IWebElement HomeClick => _browserInteractions.WaitAndReturnElement(HomeClickXpath);
        private IWebElement SuccessStoriesClick => _browserInteractions.WaitAndReturnElement(SuccessStoriesXpath);
        private IWebElement AboutUsClick => _browserInteractions.WaitAndReturnElement(AboutUsXpath);
        private IWebElement ValidAddress => _browserInteractions.WaitAndReturnElement(ValidAddressXpath);
        private IWebElement FrequentlyAskedQuestion => _browserInteractions.WaitAndReturnElement(FrequentlyAskedQuestionXpath);
        private IWebElement LoginModal => _browserInteractions.WaitAndReturnElement(LoginModalXpath);
        private IWebElement LogInProve => _browserInteractions.WaitAndReturnElement(LogInProveXpath);
        private IWebElement HourlyFeeProve => _browserInteractions.WaitAndReturnElement(HourlyFeeProveXpath);
        private IWebElement ViewDetails1Link => _browserInteractions.WaitAndReturnElement(ViewDetailsXpath);
        private IWebElement ProposalSummary => _browserInteractions.WaitAndReturnElement(ProposalSummaryXpath);
        private IWebElement EnterFeeAndDeadline => _browserInteractions.WaitAndReturnElement(EnterFeeAndDeadlineXpath);
        private IWebElement ProposedHourlyFee => _browserInteractions.WaitAndReturnElement(ProposedHourlyFeeXpath);
        private IWebElement NumberOfHours => _browserInteractions.WaitAndReturnElement(NumberOfHoursXpath);
        private IWebElement AddDates => _browserInteractions.WaitAndReturnElement(AddDatesXpath);
        private IWebElement NextDate => _browserInteractions.WaitAndReturnElement(NextDateXpath);
        private IWebElement CreateProposal => _browserInteractions.WaitAndReturnElement(CreateProposalXpath);
        private IWebElement ProposalPageProve => _browserInteractions.WaitAndReturnElement(ProposalPageProveXpath);
        private IWebElement HourlyFeeProveInPrposalPage => _browserInteractions.WaitAndReturnElement(HourlyFeeProveInPrposalPageXpath);
        private IWebElement NumberofHourProveInPrposalPage => _browserInteractions.WaitAndReturnElement(NumberofHourProveInPrposalPageXpath);
        private IWebElement FixedFee => _browserInteractions.WaitAndReturnElement(FixedFeeXpath);
        private IWebElement FixedFeeDate => _browserInteractions.WaitAndReturnElement(FixedFeeDateXpath);
        private IWebElement FixedFeeNextDate => _browserInteractions.WaitAndReturnElement(FixedFeeNextDateXpath);
        private IWebElement HourlyFeesProveInPrposalPage => _browserInteractions.WaitAndReturnElement(HourlyFeesProveInPrposalPageXpath);
        private IWebElement assterbrowsefile => _browserInteractions.WaitAndReturnElement(assterbrowsefileXpath);
        private IWebElement WorkspaceAssertbrowsefile => _browserInteractions.WaitAndReturnElement(WorkspaceAssertbrowsefileXpath);
        private IWebElement TagFile => _browserInteractions.WaitAndReturnElement(TagFileXpath);
        private IWebElement WorkspaceTagFile => _browserInteractions.WaitAndReturnElement(WorkspaceTagFileXpath);
        private IWebElement TagInput => _browserInteractions.WaitAndReturnElement(TagInputXpath);
        private IWebElement WorkspaceTagInput => _browserInteractions.WaitAndReturnElement(WorkspaceTagInputXpath);
        private IWebElement SaveTag => _browserInteractions.WaitAndReturnElement(SaveTagXpath);
        private IWebElement WorkspaceSaveTag => _browserInteractions.WaitAndReturnElement(WorkspaceSaveTagXpath);
        private IWebElement NewTag => _browserInteractions.WaitAndReturnElement(NewTagXpath);
        private IWebElement WorkspaceTag => _browserInteractions.WaitAndReturnElement(WorkspaceTagXpath);
        private IWebElement RemoveTag => _browserInteractions.WaitAndReturnElement(RemoveTagXpath);
        private IWebElement WorkspaceRemoveTag => _browserInteractions.WaitAndReturnElement(WorkspaceRemoveTagXpath);
        private IWebElement ProjectTitle => _browserInteractions.WaitAndReturnElement(ProjectTitleXpath);
        private IWebElement CatagoryProve => _browserInteractions.WaitAndReturnElement(CatagoryXpath);
        private IWebElement SubCatagoryProve => _browserInteractions.WaitAndReturnElement(SubCatagoryXpath);
        private IWebElement TasksDeliverables => _browserInteractions.WaitAndReturnElement(TasksDeliverablesXpath);
        private IWebElement ProjectDescription => _browserInteractions.WaitAndReturnElement(ProjectDescriptionXpath);
        private IWebElement Expertiserequired => _browserInteractions.WaitAndReturnElement(ExpertiserequiredXpath);
        private IWebElement FeeType => _browserInteractions.WaitAndReturnElement(FeeTypeXpath);
        private IWebElement Fee => _browserInteractions.WaitAndReturnElement(Feexapth);
        private IWebElement FeexPerMonth => _browserInteractions.WaitAndReturnElement(FeexPerMonthXapth);
        private IWebElement TimelineforHiring => _browserInteractions.WaitAndReturnElement(TimelineforHiringXpath);
        private IWebElement ProjectsHomepage => _browserInteractions.WaitAndReturnElement(ProjectsHomepageXpath);
        private IWebElement FindAnExpertLink => _browserInteractions.WaitAndReturnElement(FindAnExpertXpath);
        private IWebElement HowItWorks => _browserInteractions.WaitAndReturnElement(HowItWorksXpath);
        private IWebElement SolutionsLink => _browserInteractions.WaitAndReturnElement(SolutionsXpath);
        private IWebElement Pharmaceuticals => _browserInteractions.WaitAndReturnElement(PharmaceuticalsXpath);
        private IWebElement ServiceLink => _browserInteractions.WaitAndReturnElement(ServiceXpath);
        private IWebElement MedicalWriting => _browserInteractions.WaitAndReturnElement(MedicalWritingXpath);
        private IWebElement BecomeExpert => _browserInteractions.WaitAndReturnElement(BecomeExpertXpath);
        private IWebElement LogInModal => _browserInteractions.WaitAndReturnElement(LogInModalXpath);
        private IWebElement CloseLogInModal => _browserInteractions.WaitAndReturnElement(CloseLogInModalXpath);
        private IWebElement RequestAService => _browserInteractions.WaitAndReturnElement(RequestAServiceXpath);
        private IWebElement CreateProjectProve => _browserInteractions.WaitAndReturnElement(CreateProjectProveXpath);
        private IWebElement DelectIconProposalPage => _browserInteractions.WaitAndReturnElement(DelectIconProposalPageXpath);
        private IWebElement CustomMessageModal => _browserInteractions.WaitAndReturnElement(CustomMessageModalXpath);
        private IWebElement ClickonOKinProposalPage => _browserInteractions.WaitAndReturnElement(ClickonOKinProposalPageXpath);
        private IWebElement CheckifFlieRemoved => _browserInteractions.WaitAndReturnElement(CheckifFlieRemovedXpath);
        private IWebElement TextRemoveCheckProposalPage => _browserInteractions.WaitAndReturnElement(TextRemoveCheckProposalPageXpath);
        private IWebElement FindExterMoreButton => _browserInteractions.WaitAndReturnElement(FindExterMoreButtonXpath);
        private IWebElement InstitutionInput => _browserInteractions.WaitAndReturnElement(InstitutionInputXpath);
        private IWebElement EnterACountryName => _browserInteractions.WaitAndReturnElement(EnterACountryNameXpath);
        private IWebElement SelectUniversityList1 => _browserInteractions.WaitAndReturnElement(SelectUniversityList1Xpath);
        private IWebElement UniversityProve => _browserInteractions.WaitAndReturnElement(UniversityProveXpath);
        private IWebElement CountryClick => _browserInteractions.WaitAndReturnElement(CountryClickXpath);
        private IWebElement CountryProve => _browserInteractions.WaitAndReturnElement(CountryProveXpath);
        private IWebElement SubjectAreas => _browserInteractions.WaitAndReturnElement(SubjectAreasXpath);
        private IWebElement EnterSubjectArea => _browserInteractions.WaitAndReturnElement(EnterSubjectAreaXpath);
        private IWebElement WorkSpaceOnBtn => _browserInteractions.WaitAndReturnElement(WorkSpaceBtn);
        private IWebElement BrowseFileBtn => _browserInteractions.WaitAndReturnElement(BrowseFilesBtn);
        private IWebElement AcceptOnCookieBtn => _browserInteractions.WaitAndReturnElement(AcceptCookiesBtn);
        private IWebElement UploadOnFilesBtn => _browserInteractions.WaitAndReturnElement(UploadFilesBox);
        private IWebElement UploadFileOnXpath => _browserInteractions.WaitAndReturnElement(UploadfileXpath);
        private IWebElement DeleteBtnXpath => _browserInteractions.WaitAndReturnElement(DeleteBtn);
        private IWebElement DeleteAction => _browserInteractions.WaitAndReturnElement(DeleteActionXpath);




        public string getPage()
        {
            //_browserInteractions.SwitchTo().Window(_browserInteractions.WindowHandles[1]);
            return _browserInteractions.GetUrl();
        }
        public void ClickOnFindOnanExpert()
        {
            FindOnanExpert.Click();
        }

        public void ClickOnBillingOn()
        {
            BillingOn.Click();
        }

        public void ClickOnSubjectArea()
        {
            //SubjectArea.SendKeysWithClear(text);
            SubjectArea.Click();
        }

        public void EnterSearchText(string text)
        {
            SearchOnSubjectArea.SendKeysWithClear(text);
            SearchOnSubjectArea.SendKeys(Keys.Enter);
        }

        public void ClickOnFreelancerTest()
        {
            FreelancerTest.Click();
        }
        public void FreelancerPageClick()
        {
            FreelancerPageLink.Click();
        }
        public void SolutionsLinkClick()
        {
            SolutionsLink.Click();
        }
        public void BecomeExpertClick()
        {
            BecomeExpert.Click();
        }
        public void RequestAServiceClick()
        {
            RequestAService.Click();
        }
        public void DelectIconProposalPageClick()
        {
            DelectIconProposalPage.Click();
        }
        public void CloseLogInModalClick()
        {
            CloseLogInModal.Click();
        }
        public void SubjectAreasClick()
        {
            SubjectAreas.Click();
        }
        public void ClickonOKinProposalPageClick()
        {
            ClickonOKinProposalPage.Click();
        }
        public void LogInModalClick()
        {
            LogInModal.Click();
        }
        public void FindExterMoreButtonClick()
        {
            FindExterMoreButton.Click();
        }
        public void CountryClickLink()
        {
            CountryClick.Click();
        }

        public void ClickOnDeleteBtn()
        {
            DeleteBtnXpath.Click();
        }

        public void CLickOnDeleteAction()
        {
            DeleteAction.Click();
        }
        public void SelectUniversityList1Click()
        {
            SelectUniversityList1.Click();
        }
        public void MedicalWritingClick()
        {
            MedicalWriting.Click();
        }
        public void ServiceLinkClick()
        {
            ServiceLink.Click();
        }
        public void PharmaceuticalsClick()
        {
            Pharmaceuticals.Click();
        }
        public IWebElement BEcomeanExpertClick()
        {
            return BEcomeanExpert;
        }
        public IWebElement HomeClickLink()
        {
            return HomeClick;
        }
        public IWebElement TwitterButtonLink()
        {
            return TwitterButton;
        }
        public IWebElement FacebookButtonLink()
        {
            return FacebookButton;
        }
        public IWebElement EnterSubjectAreaLink()
        {
            return EnterSubjectArea;
        }
        public IWebElement InstitutionInputWork()
        {
            return InstitutionInput;
        }
        public IWebElement EnterACountryNameClick()
        {
            return EnterACountryName;
        }
        public void InstitutionInputAlphabetA()
        {
            InstitutionInput.SendKeysWithClear("a");
        }
        public void EnterACountryNameInput()
        {
            EnterACountryName.SendKeysWithClear("India");
        }
        public IWebElement LinkedInButtonLink()
        {
            return LinkedInButton;
        }
        public IWebElement getBlog()
        {
            return BlogId;
        }
        public IWebElement HireDataScientistLink()
        {
            return HireDataScientist;
        }
        public IWebElement ChemistLink()
        {
            return Chemist;
        }
        public IWebElement ProjectTitleLink()
        {
            return ProjectTitle;
        }
        public IWebElement BiostatisticianLink()
        {
            return Biostatistician;
        }
        public IWebElement HireStatisticianLink()
        {
            return HireStatistician;
        }
        public IWebElement ScientistLink()
        {
            return Scientist;
        }
        public IWebElement FrequentlyAskedQuestionLink()
        {
            return FrequentlyAskedQuestion;
        }
        public IWebElement ResearcherLink()
        {
            return Researcher;
        }
        public IWebElement MedicalWriterLink()
        {
            return MedicalWriter;
        }
        public IWebElement FoodScientistLink()
        {
            return FoodScientist;
        }
        public IWebElement HealthEconomistLink()
        {
            return HealthEconomist;
        }
        public IWebElement DataScientistLink()
        {
            return DataScientist;
        }
        public string ProposalPageProveLink()
        {
            return ProposalPageProve.Text;
        }
        public string CheckifFlieRemovedProve()
        {
            return CheckifFlieRemoved.Text;
        }
        public string TextRemoveCheckProposalPageProve()
        {
            return TextRemoveCheckProposalPage.Text;
        }
        public string CustomMessageModalLink()
        {
            return CustomMessageModal.Text;
        }
        public string CountryProveLink()
        {
            return CountryProve.Text;
        }
        public string CreateProjectProveLink()
        {
            return CreateProjectProve.Text;
        }
        public string SubCatagoryProveLink()
        {
            return SubCatagoryProve.Text;
        }
        public string UniversityProveOfIt()
        {
            return UniversityProve.Text;
        }
        public string TasksDeliverablesLink()
        {
            return TasksDeliverables.Text;
        }
        public string FeeProveText()
        {
            return Fee.Text;
        }
        public string TimelineforHiringProve()
        {
            return TimelineforHiring.Text;
        }
        public string ProjectDescriptionLink()
        {
            return ProjectDescription.Text;
        }
        public string ExpertiserequiredProve()
        {
            return Expertiserequired.Text;
        }
        public string FeeTypeProve()
        {
            return FeeType.Text;
        }
        public string FeexPerMonthProve()
        {
            return FeexPerMonth.Text;
        }
        public string HourlyFeesProveInPrposalPageLink()
        {
            return HourlyFeesProveInPrposalPage.Text;
        }
        public string HourlyFeeProveInPrposalPageLink()
        {
            return HourlyFeeProveInPrposalPage.Text;
        }
        public string NumberofHourProveInPrposalPageLink()
        {
            return NumberofHourProveInPrposalPage.Text;
        }
        public string FixedFeeProve()
        {
            return FixedFee.Text;
        }
        public IWebElement SuccessStoriesClickLink()
        {
            return SuccessStoriesClick;
        }

        public IWebElement AboutUsClickLink()
        {
            return AboutUsClick;
        }
        public void AcceptCookiesClick()
        {
            AcceptCookiesLink.Click();
        }
        public void HomepageBackClick()
        {
            HomepageBack.Click();
        }
        public void FindAnExpertLinkClick()
        {
            FindAnExpertLink.Click();
        }
        public void AddDatesClick()
        {
            AddDates.Click();
        }
        public void HowItWorksClick()
        {
            HowItWorks.Click();
        }
        public void NextDatesClick()
        {
            NextDate.Click();
        }
        public void ProjectsHomepageClick()
        {
            ProjectsHomepage.Click();
        }
        public void FixedFeeDateClick()
        {
            FixedFeeDate.Click();
        }
        public void FixedFeeNextDateClick()
        {
            FixedFeeNextDate.Click();
        }

        public void BrowseProjectClick()
        {
            BrowseProjectLink.Click();
        }
        public void ViewDetailsClick()
        {
            ViewDetailsLink.Click();
        }
        public void CreateProposalClick()
        {
            CreateProposal.Click();
        }
        public void EnterFeeAndDeadlineClick()
        {
            EnterFeeAndDeadline.Click();
        }
        public void PublicMessageBoardClick()
        {
            PublicMessageBoardLink.Click();
        }
        public void TestBoxClick(string msg)
        {
            TestBoxLink.Click();
            TestBoxLink.SendKeysWithClear(msg);
        }
        public void NumberOfHoursClick(string msg)
        {
            NumberOfHours.Click();
            NumberOfHours.SendKeysWithClear(msg);
        }
        public void ProposedHourlyFeeClick(string msg)
        {
            ProposedHourlyFee.Click();
            ProposedHourlyFee.SendKeysWithClear(msg);
        }
        public void ProposalSummaryClick(string msg)
        {
            ProposalSummary.Click();
            ProposalSummary.SendKeysWithClear(msg);
        }
        public void AskQuestionClick()
        {
            AskQuestionLink.Click();
        }
        public void FrequentlyAskedQuestionClick()
        {
            FrequentlyAskedQuestion.Click();
        }
        public void ViewDetails1LinkClick()
        {
            ViewDetails1Link.Click();
        }
        public void DeleteUploadClick()
        {
            DeleteUpload.Click();
        }
        public string MessageCommentFunc()
        {
            return MessageCommentLink.Text;
        }
        public string LogInProveLink()
        {
            return LogInProve.Text;
        }
        public string HourlyFeeProveLink()
        {
            return HourlyFeeProve.Text;
        }
        public string CatagoryProveLink()
        {
            return CatagoryProve.Text;
        }
        public IWebElement ScrollUpFunc()
        {
            return ScrollUpLink;
        }
        public void ProposalTabClick()
        {
            ProposalTabLink.Click();
        }
        public void TextAreaClickandSend()
        {
            TextAreaLink.Click();
            TextAreaLink.SendKeysWithClear("This is a Test Message");
        }
        public void SendMessageClick()
        {
            SendMessageLink.Click();
        }
        public string CheckforMessageProve()
        {
            return CheckforMessageLink.Text;
        }
        public string CreateAccountModalProve()
        {
            return CreateAccountModal.Text;
        }

        public void WorkspaceButtonLinkClick()
        {
            WorkspaceButtonLink.Click();
        }
        public void WorkspaceTextAreaLinkSend()
        {
            WorkspaceTextAreaLink.Click();
            WorkspaceTextAreaLink.SendKeysWithClear("This is a Test Workspace Message.");
        }
        public void WorkspaceTextSendButtonClick()
        {
            WorkspaceTextSendButtonLink.Click();
        }
        public void DeleteOKClick()
        {
            DeleteOK.Click();
        }

        public string WorkspaceTextCheckLinkProve()
        {
            return WorkspaceTextCheckLink.Text;
        }
        public string LoginModalProve()
        {
            return LoginModal.Text;
        }
        public string TestRemovedProve()
        {
            return TestRemoved.Text;
        }

        public string UploadedFileProve()
        {
            return UploadedFile.Text;
        }
        public string ConfirmDeleteProve()
        {
            return ConfirmDelete.Text;
        }

        public string ClickOnUploadFile()
        {
            return UploadFileOnXpath.Text;
        }

        public string ValidAddressProve()
        {
            return ValidAddress.Text;
        }

        public IWebElement ValidAddressLink()
        {
            return ValidAddress;
        }

        public string assterbrowsefileLink()
        {
            return assterbrowsefile.Text;
        }

        public void TagFileClick()
        {
            TagFile.Click();
        }
        public void WorkspaceTagFileClick()
        {
            WorkspaceTagFile.Click();
        }

        public void TagInputClick(string txt)
        {

            TagInput.SendKeysWithClear(txt);
        }
        public void WorkspaceTagInputClick(string txt)
        {

            WorkspaceTagInput.SendKeysWithClear(txt);
        }
        public void SaveTagClick()
        {
            SaveTag.Click();
        }
        public void WorkspaceSaveTagClick()
        {
            WorkspaceSaveTag.Click();
        }

        public string NewTagProve()
        {
            return NewTag.Text;
        }
        public string WorkspaceTagProve()
        {
            return WorkspaceTag.Text;
        }

        public void RemoveTagClick()
        {
            RemoveTag.Click();
        }

        public void WorkspaceRemoveTagClick()
        {
            WorkspaceRemoveTag.Click();
        }

        public string WorkspaceAssertbrowsefileLink()
        {
            return WorkspaceAssertbrowsefile.Text;
        }

        public void ClickOnWorkSpace()
        {
            WorkSpaceOnBtn.Click();
        }
        public void ClickOnBrowseFile()
        {
            BrowseFileBtn.Click();
        }
        public void ClickOnAcceptCookies()
        {
            AcceptOnCookieBtn.Click();
        }

        public void CLickOnUploadFiles()
        {
            UploadOnFilesBtn.Click();
        }
    }
}