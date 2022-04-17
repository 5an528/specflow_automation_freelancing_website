using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.PageObjects
{
    public class BrowseExpertPage
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;


        private By BrowserNotificationAlertXpath => By.XPath("//button[contains(text(),'OK')]");
        private By NextPageIcon => By.XPath("//a[contains(text(),'>')]");
        private By LastPageIcon => By.XPath("//a[contains(text(),'>>')]");
        private By PreviousPageIcon => By.XPath("//*[@id='paginationclient']/ul/li[2]/a");
        private By FirstPageIcon => By.XPath("//*[@id='paginationclient']/ul/li[1]/a");
        private By LabelNameXpath => By.XPath("//h1[contains(text(),'Hire a freelance scientist')]");
        private By DropDownXpath => By.XPath("//div[@class='mat-form-field-infix']");
        private By FirstProjectxpath => By.XPath("//*[@id='d39239eb-1ca3-46e5-99e5-856c891a5b88']/span");
        private By DropDownInputXpath => By.XPath("//*[@id='mat-option-0']/span/ngx-mat-select-search/div/input");
        private By SecondProjectxpath => By.XPath("//*[@id='d39239eb-1ca3-46e5-99e5-856c891a5b88']/span");
        private By ModiefiedTextXpath => By.XPath("//*[@id='ShowProposalModifiedMsgSummary']/span");
        private By RejectDeadlinexpath => By.XPath("//*[@id='RejectNewDeadline']");
        private By ApproveNewDeadlineXpath => By.XPath("//*[@id='ApproveNewDeadline']");
        private By DeadlineXpath => By.XPath("//*[@id='Deadline']/div/span[2]");
        private By WorkSpaceXpath => By.XPath("//*[@id='sidebar-wrapper']/ul/li[7]/a");
        private By ProposalsXpath => By.XPath("//*[@id='sidebar-wrapper']/ul/li[6]/a");
        private By ProjectDetailsXpath => By.XPath("//*[@id='showProjectDetailsTab']/a/span");
        private By PublicMessageTextAreaXpath => By.XPath("//*[@id='ProjectForumMessageText']");
        private By PublicMessageTextCheckXpath => By.XPath("//li[1][@class='clearfix comment-list']/div[2]/div[1]/p[3][1]");
        private By SendTextXpath => By.XPath("//*[@id='MessageText']");
        private By SendButtonXpath => By.XPath("//*[@id='wrapper']/div/app-workspace/div[4]/div[1]/div/div[3]/div[1]/div[3]/div[2]/div/div[6]/div[3]/div[2]/button");
        private By AssertTextXpath => By.XPath("//*[@id='Messages']/div[7]/div/div/div[1]/div[1]/p[2]");
        private By ReplyXpath => By.XPath("//*[@id='ShowReplyButton']/div[2]/div");
        private By MessageTypeXpath => By.XPath("//*[@id='MessageText']");
        private By SendMessageButtonXpath => By.XPath("//button[contains(text(),' Send message ')]");
        private By TechnecialConsulting => By.XPath("//span[contains(text(),' Technical consulting ')]");

        private By AssertPrivateTextXpath => By.XPath("//p[contains(text(),'This is a Private Test Message!')]");
        private By AssertPublicMessageBoardXpath => By.XPath("//*[@id='projectForumMessages']/div/div[1]/div[1]/p");
        private By PostMessageXpath => By.XPath("//*[@id='projectForumMessages']/div/div[1]/div[2]/div/div[2]/button");
        private By assterbrowsefileXpath => By.XPath("//*[@id='Messages']/div[45]/div/div[1]/div[1]/div[1]/div[1]/a"); //a[contains(text(),'download.png')]
        private By fa_fa_deleteBtn => By.XPath("//*[@id='Messages']/div[45]/div/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/a/i");
        private By TagFileXpath => By.XPath("//*[@id='Messages']/div[24]/div/div[1]/div[1]/div[1]/div[2]/div[3]/div[2]/a");
        private By TagInputXpath => By.XPath("//*[@id='Messages']/div[24]/div/div[1]/div[1]/div[1]/div[2]/div[2]/div/input");
        private By SaveTagXpath => By.XPath("//*[@id='Messages']/div[24]/div/div[1]/div[1]/div[1]/div[2]/div[2]/div/button[1]");
        private By NewTagXpath => By.XPath("//*[@id='Messages']/div[24]/div/div[1]/div[1]/div[1]/div[2]/div[1]/span/span");
        private By RemoveTagXpath => By.XPath("//*[@id='Messages']/div[24]/div/div[1]/div[1]/div[1]/div[2]/div[1]/span/a");
        private By DeleteFileXpath => By.XPath("//*[@id='Messages']/div[45]/div/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/a");//manually update div
        private By ConfirmDeleteXpath => By.XPath("//*[@id='modalDanger']/div/div/div/div[3]/div/button[1]");
        private By TestFileDeletedXpath => By.XPath("//span[contains(text(),' removed file')]");
        private By LoggedInXpath => By.XPath("//*[@id='pageMainHeader']/div/ul[1]/li[2]/label");
        private By BillingPageButtonXpath => By.XPath("//*[@id='sidebar-wrapper']/ul/li[8]/a");
        private By TotalWalletBalanceXpath => By.XPath("//*[@id='bankaccountdetails']/div/div[1]/div[2]/div[1]/div[1]/label");   //*[@id='balanceAmount']
        private By WalletDivXpath => By.XPath("//*[@id='bankaccountdetails']/div/div[1]/div[2]/div[1]");
        private By CommittedBalanceXpath => By.XPath("//*[@id='commitedBalance']");
        private By AddFundsXpath => By.XPath("//*[@id='AllOngoingProjects']/li[2]/div[6]/button[1]");
        private By AddFundsWindowOpenXpath => By.XPath("//*[@id='divPaymentcardSection']/div[1]/div[1]");
        private By CreditCardButtonXpath => By.XPath("//*[@id='radioOptionSection']/div/div[1]/label");
        private By AmmountAreaisEditableXpath => By.XPath("//*[@id='txtIncreaseAmount']");
        private By IncreasedammountshowsupXpath => By.XPath("//*[@id='fundingAmountTotalFee']");
        private By CardDropdownXpath => By.XPath("//*[@id='ddlExistingCards']");
        private By SelectCardTwoXpath => By.XPath("//*[@id='ddlExistingCards']/option[2]");
        private By ClickConfirmFundXpath => By.XPath("//*[@id='btnDiscountPayFundProject']");
        private By ProveofFundedProjectXpath => By.XPath("//*[@id='AllOngoingProjects']/li[1]/div[1]");
        private By ModalMessageXpath => By.XPath("//*[@id='transaction-status']");
        private By ModalMessageCloseXpath => By.XPath("//*[@id='pnlTransactionStatus']/button");
        private By TotalFundedProjectDetailsXpath => By.XPath("//*[@id='TotalFundedProjectFee']");
        private By BalanceCurrencyShowsXpath => By.XPath("//*[@id='balanceCurrency']");
        private By ClickOnSecondProjectXpath => By.XPath("//*[@id='AllOngoingProjects']/li[2]/h4");
        private By History => By.XPath("//*[@id='btnTransactionHistory']");




        //..

        //private By UserLogin = By.XPath("//a[@id='signIn']");
        private By ClkPorposal => By.XPath("//*[@id='sidebar-wrapper']/ul/li[6]/a");
        private By ClkHireTestAcc1 => By.XPath("//*[@id='AcceptproposalButtonDiv']/a");
        private By ClkTextArea => By.XPath("//*[@id='MessageTextconversation']");
        private By ClickHireTestAcc1 => By.XPath("//*[@id='proposalactionbutton']");
        private By AssertTxt => By.XPath("//label[contains(text(),'Proposals')]");
        private By ClkCreateProject = By.XPath("//*[@id='sidebar-wrapper']/ul/li[4]/a/span");
        private By SelectCardOnNewProject = By.XPath("//span[contains(text(),'Start a new project')]");
        private By ClickAllExpert => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[3]/div[1]/div/app-privacy/div/div[1]");
        private By ClickConsulting => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[1]/div[1]/div[2]/div[1]/div/app-servicecatagory/div/div[1]/div[2]");
        private By ClickStartPosting => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div[3]/div[2]/div[3]/div/button");
        private By ClickonCosultingFirstModalXpath => By.XPath("//*[@id='mat-radio-6']/label/span[2]");
        private By EnterSkill => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[1]/div[1]/div[2]/div[1]/div/app-autocomplete/div[3]/div/div[3]");
        private By ResearchDevelopment => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[1]/div[1]/div[2]/div[1]/div/app-autocomplete/div[3]/div/div[3]");
        private By ProductDevelopment => By.XPath("//*[@id='mat-radio-71']/label/div[1]/div[1]");
        private By ClickNext => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[3]/div/button[2]");
        private By ClickRadio => By.XPath("//span[contains(text(),'Consulting call')]");
        private By SelectProjectDropDownModalXpath => By.XPath("//*[@id='selProjects']");
        private By ChosseCategory => By.XPath("//*[@id='mat-radio-9']/label/div[1]/div[1]");
        //private By ClkNext => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[3]/div/button[2]/span/span");
        private By ClickConsultingCheckBox => By.XPath("//*[@id='mat-checkbox-6']/label/div");
        private By ClickSubDrop => By.XPath("//*[@id='mat-radio-75']/label/div[1]/div[1]");
        private By ClickOnSkillText => By.XPath("//div[contains(text(),'Research & Development')]");
        private By ClickProposalDetails => By.XPath("//*[@id='workspacetabsection']/div[1]/div[1]/div/div[2]");
        private By ClickViewProposal => By.XPath("//*[@id='showScopeHoverData']/div/div/div[2]/div/a");
        private By ClcikBilling => By.XPath("//*[@id='sidebar-wrapper']/ul/li[8]/a");
        private By AddFund => By.CssSelector("#btnAddFundWallet");
        private By AddAmount => By.XPath("//*[@id='txtIncreaseAmount']");
        private By Credit_DebitXpath => By.XPath("//*[@id='radioOptionSection']/div/div[1]/label/span");
        private By BtnPay => By.XPath("//*[@id='btnPay']");
        private By AddFundToThis => By.XPath("//*[@id='AllOngoingProjects']/li[1]/div[6]/button");
        private By ClickTransicationHistory => By.XPath("//*[@id='btnTransactionHistory']");
        private By ClickConuslting => By.XPath("//*[@id='mat-radio-70']/label/div[2]");
        private By MarketResearch => By.CssSelector("#mat-radio-147 > label > div.mat-radio-label-content");
        private By Research = By.CssSelector("#mat-checkbox-3 > label > div");
        private By ProjectTitle => By.XPath("//*[@id='textboxComponent']");
        private By InviteExpertXpath => By.XPath("//*[@id='CloseInviteExpertPopup']");
        private By FreelancerInviteButtonXpath => By.XPath("//*[@id='expert-container']/div[1]/div[1]/div[2]/div[1]/div[1]/div/div[2]/div/a");
        private By ProjectDescriptionInputXpath => By.XPath("//*[@id='TxtAreaComponent']");
        private By ClickOnDecideLate => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[1]/div[1]/div[2]/div[1]/div/app-radio-button/div/div[5]");
        private By PostProject => By.XPath("//*[@id='wrapper']/div/app-create-project/app-question-answer/div/div[1]/div[3]/div/div[2]/div[3]/div/button[2]/span/span");

        private By SelectProjectoneXpath => By.XPath("//option[contains(text(),' The standard Lorem Ipsum passage, used since the 1500s')]");
        private By MessagetoFreelancerCustomInputXpath => By.XPath("//*[@id='EmailContent']");

        private By InviteFreelancerTextXpath => By.XPath("//span[contains(text(),'Freelancer Test')]");
        private By SuccessfulMessageXpath => By.XPath("//*[@id='lessthanlimit']/div/div/div[2]");
        private By TestProjectTitleXpath => By.XPath("//*[@id='AllOngoingProjects']/li[2]/h4");
        private By PayFreelancerXpath => By.XPath("//*[@id='AllOngoingProjects']/li[2]/div[4]/button[2]");
        private By AmountToBeTransferXpath => By.XPath("//*[@id='txtTransferAmount']");
        private By PayNowBtnXpath => By.XPath("//*[@id='btnConfirmTransfer']");
        private By ProjectTitleXpath => By.XPath("//*[@id='AllOngoingProjects']/li[3]/h4");
        private By AddfundXpath => By.XPath("//*[@id='AllOngoingProjects']/li[3]/div[6]/button");
        private By AddProjectFundXpath => By.XPath("//*[@id='txtIncreaseAmount']");
        private By Credit_DebitCard_Xpath => By.XPath("//*[@id='radioOptionSection']/div/div[1]/label");
        private By ConfirmXpath => By.XPath("//*[@id='btnDiscountPayFundProject']");
        private By CardNumberXpath => By.XPath("//*[@id='ddlExistingCards']");
        private By Proposal_Xpath => By.XPath("//*[@id='sidebar-wrapper']/ul/li[6]/a/span");
        private By ProjectDetails_Xpath => By.XPath("//*[@id='showProjectDetailsTab']/a/span");
        private By PublicMessageBoardXpath => By.XPath("//*[@id='ProjectForumMessageText']");
        private By PostMagXpath => By.XPath("//*[@id='projectForumMessages']/div/div[1]/div[2]/div/div[2]/button");
        private By HireTestAcc1Xpath => By.XPath("//*[@id='AcceptproposalButtonDiv']/a");
        private By BidFromTestAcc1TextAreaXpath => By.XPath("//*[@id='MessageTextconversation']");
        private By HireTestBtnXpath => By.XPath("//*[@id='proposalactionbutton']");
        private By SelectSubjectXpath => By.XPath("//*[@id='search-input']");
        private By HireACC1ForBidXpath => By.XPath("//*[@id='AcceptproposalButtonDiv']/a");


        public BrowseExpertPage(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }



        private IWebElement BrowserNotificationAlert => _browserInteractions.WaitAndReturnElement(BrowserNotificationAlertXpath);
        private IWebElement HireACC1ForBid => _browserInteractions.WaitAndReturnElement(HireACC1ForBidXpath);
        private IWebElement SelectSubject => _browserInteractions.WaitAndReturnElement(SelectSubjectXpath);
        private IWebElement HireTestBtn => _browserInteractions.WaitAndReturnElement(HireTestBtnXpath);
        private IWebElement BidFromTestAcc1TextArea => _browserInteractions.WaitAndReturnElement(BidFromTestAcc1TextAreaXpath);
        private IWebElement HireOnTestAcc1 => _browserInteractions.WaitAndReturnElement(HireTestAcc1Xpath);
        private IWebElement PostOnMessage => _browserInteractions.WaitAndReturnElement(PostMagXpath);
        private IWebElement PublicMessageBoard => _browserInteractions.WaitAndReturnElement(PublicMessageBoardXpath);
        private IWebElement ProjectOnDetails => _browserInteractions.WaitAndReturnElement(ProjectDetails_Xpath);
        private IWebElement CardNumber => _browserInteractions.WaitAndReturnElement(CardNumberXpath);
        private IWebElement ToConfirm => _browserInteractions.WaitAndReturnElement(ConfirmXpath);
        private IWebElement Credit_Debit_Card => _browserInteractions.WaitAndReturnElement(Credit_DebitCard_Xpath);
        private IWebElement AddProjectFund => _browserInteractions.WaitAndReturnElement(AddProjectFundXpath);
        private IWebElement AddOnfund => _browserInteractions.WaitAndReturnElement(AddfundXpath);
        private IWebElement ProjectOnTitle => _browserInteractions.WaitAndReturnElement(ProjectTitleXpath);
        private IWebElement PayNowBtn => _browserInteractions.WaitAndReturnElement(PayNowBtnXpath);
        private IWebElement AmountToBeTransfer => _browserInteractions.WaitAndReturnElement(AmountToBeTransferXpath);
        private IWebElement PayFreelancer => _browserInteractions.WaitAndReturnElement(PayFreelancerXpath);
        private IWebElement TestProjectTitle => _browserInteractions.WaitAndReturnElement(TestProjectTitleXpath);
        private IWebElement NextPageIconLink => _browserInteractions.WaitAndReturnElement(NextPageIcon);
        private IWebElement InviteFreelancerText => _browserInteractions.WaitAndReturnElement(InviteFreelancerTextXpath);
        private IWebElement MessagetoFreelancerCustomInput => _browserInteractions.WaitAndReturnElement(MessagetoFreelancerCustomInputXpath);
        private IWebElement SelectProjectone => _browserInteractions.WaitAndReturnElement(SelectProjectoneXpath);
        private IWebElement SelectProjectDropDownModal => _browserInteractions.WaitAndReturnElement(SelectProjectDropDownModalXpath);
        private IWebElement FreelancerInviteButton => _browserInteractions.WaitAndReturnElement(FreelancerInviteButtonXpath);
        private IWebElement InviteExpertLink => _browserInteractions.WaitAndReturnElement(InviteExpertXpath);
        private IWebElement ProjectDescriptionInput => _browserInteractions.WaitAndReturnElement(ProjectDescriptionInputXpath);
        private IWebElement LastPageIconLink => _browserInteractions.WaitAndReturnElement(LastPageIcon);
        private IWebElement PreviousPageIconLink => _browserInteractions.WaitAndReturnElement(PreviousPageIcon);
        private IWebElement FirstPageIconLink => _browserInteractions.WaitAndReturnElement(FirstPageIcon);
        private IWebElement LabelName => _browserInteractions.WaitAndReturnElement(LabelNameXpath);
        private IWebElement DropDown => _browserInteractions.WaitAndReturnElement(DropDownXpath);
        private IWebElement FirstProject => _browserInteractions.WaitAndReturnElement(FirstProjectxpath);
        private IWebElement SecondProject => _browserInteractions.WaitAndReturnElement(SecondProjectxpath);
        private IWebElement ModiefiedText => _browserInteractions.WaitAndReturnElement(ModiefiedTextXpath);
        private IWebElement ClickonCosultingFirstModal => _browserInteractions.WaitAndReturnElement(ClickonCosultingFirstModalXpath);
        private IWebElement TechnecialOnConsulting => _browserInteractions.WaitAndReturnElement(TechnecialConsulting);
        private IWebElement RejectDeadline => _browserInteractions.WaitAndReturnElement(RejectDeadlinexpath);
        private IWebElement Deadline => _browserInteractions.WaitAndReturnElement(DeadlineXpath);
        private IWebElement ApproveNewDeadline => _browserInteractions.WaitAndReturnElement(ApproveNewDeadlineXpath);
        private IWebElement WorkSpace => _browserInteractions.WaitAndReturnElement(WorkSpaceXpath);
        private IWebElement SendText => _browserInteractions.WaitAndReturnElement(SendTextXpath);
        private IWebElement DropDownInput => _browserInteractions.WaitAndReturnElement(DropDownInputXpath);
        private IWebElement SendButton => _browserInteractions.WaitAndReturnElement(SendButtonXpath);
        private IWebElement AssertText => _browserInteractions.WaitAndReturnElement(AssertTextXpath);
        private IWebElement Proposals => _browserInteractions.WaitAndReturnElement(ProposalsXpath);
        private IWebElement ProjectDetails => _browserInteractions.WaitAndReturnElement(ProjectDetailsXpath);
        private IWebElement PublicMessageTextAreaLink => _browserInteractions.WaitAndReturnElement(PublicMessageTextAreaXpath);
        private IWebElement PublicMessageTextCheckLink => _browserInteractions.WaitAndReturnElement(PublicMessageTextCheckXpath);
        private IWebElement Reply => _browserInteractions.WaitAndReturnElement(ReplyXpath);
        private IWebElement MessageType => _browserInteractions.WaitAndReturnElement(MessageTypeXpath);
        private IWebElement SendMessageButton => _browserInteractions.WaitAndReturnElement(SendMessageButtonXpath);
        private IWebElement AssertPrivateText => _browserInteractions.WaitAndReturnElement(AssertPrivateTextXpath);
        private IWebElement AssertPublicMessageBoard => _browserInteractions.WaitAndReturnElement(AssertPublicMessageBoardXpath);
        private IWebElement PostMessageLink => _browserInteractions.WaitAndReturnElement(PostMessageXpath);
        private IWebElement SuccessfulMessage => _browserInteractions.WaitAndReturnElement(SuccessfulMessageXpath);
        private IWebElement assterbrowsefile => _browserInteractions.WaitAndReturnElement(assterbrowsefileXpath);
        private IWebElement TagFile => _browserInteractions.WaitAndReturnElement(TagFileXpath);
        private IWebElement TagInput => _browserInteractions.WaitAndReturnElement(TagInputXpath);
        private IWebElement SaveTag => _browserInteractions.WaitAndReturnElement(SaveTagXpath);
        private IWebElement NewTag => _browserInteractions.WaitAndReturnElement(NewTagXpath);
        private IWebElement RemoveTag => _browserInteractions.WaitAndReturnElement(RemoveTagXpath);
        private IWebElement DeleteFileLink => _browserInteractions.WaitAndReturnElement(DeleteFileXpath);
        private IWebElement ConfirmDeleteLink => _browserInteractions.WaitAndReturnElement(ConfirmDeleteXpath);
        private IWebElement TestFileDeleted => _browserInteractions.WaitAndReturnElement(TestFileDeletedXpath);
        private IWebElement LoggedIn => _browserInteractions.WaitAndReturnElement(LoggedInXpath);
        private IWebElement BillingPageButton => _browserInteractions.WaitAndReturnElement(BillingPageButtonXpath);
        private IWebElement TotalWalletBalance => _browserInteractions.WaitAndReturnElement(TotalWalletBalanceXpath);
        private IWebElement WalletDiv => _browserInteractions.WaitAndReturnElement(WalletDivXpath);
        private IWebElement CommittedBalance => _browserInteractions.WaitAndReturnElement(CommittedBalanceXpath);
        private IWebElement AddFunds => _browserInteractions.WaitAndReturnElement(AddFundsXpath);
        private IWebElement AddFundsWindowOpen => _browserInteractions.WaitAndReturnElement(AddFundsWindowOpenXpath);
        private IWebElement CreditCardButton => _browserInteractions.WaitAndReturnElement(CreditCardButtonXpath);
        private IWebElement AmmountAreaisEditable => _browserInteractions.WaitAndReturnElement(AmmountAreaisEditableXpath);
        private IWebElement Increasedammountshowsup => _browserInteractions.WaitAndReturnElement(IncreasedammountshowsupXpath);
        private IWebElement CardDropdown => _browserInteractions.WaitAndReturnElement(CardDropdownXpath);
        private IWebElement SelectCardTwo => _browserInteractions.WaitAndReturnElement(SelectCardTwoXpath);
        private IWebElement ClickConfirmFund => _browserInteractions.WaitAndReturnElement(ClickConfirmFundXpath);
        private IWebElement ProveofFundedProject => _browserInteractions.WaitAndReturnElement(ProveofFundedProjectXpath);
        private IWebElement ModalMessage => _browserInteractions.WaitAndReturnElement(ModalMessageXpath);
        private IWebElement ModalMessageClose => _browserInteractions.WaitAndReturnElement(ModalMessageCloseXpath);
        private IWebElement TotalFundedProjectDetails => _browserInteractions.WaitAndReturnElement(TotalFundedProjectDetailsXpath);
        private IWebElement BalanceCurrencyShows => _browserInteractions.WaitAndReturnElement(BalanceCurrencyShowsXpath);
        private IWebElement ClickOnSecondProject => _browserInteractions.WaitAndReturnElement(ClickOnSecondProjectXpath);
        private IWebElement Clk_fa_fa_deleteBtn => _browserInteractions.WaitAndReturnElement(fa_fa_deleteBtn);



        //..

        //private IWebElement ClkOnUserLogin => _browserInteractions.WaitAndReturnElement(UserLogin);
        private IWebElement ClickOnProposal => _browserInteractions.WaitAndReturnElement(ClkPorposal);
        private IWebElement ClickOnHireTestAcc1 => _browserInteractions.WaitAndReturnElement(ClkHireTestAcc1);
        private IWebElement EnterTextArea => _browserInteractions.WaitAndReturnElement(ClkTextArea);
        private IWebElement ClkOnHireTestAcc1 => _browserInteractions.WaitAndReturnElement(ClickHireTestAcc1);
        private IWebElement Assertion => _browserInteractions.WaitAndReturnElement(AssertTxt);
        private IWebElement ClickOnCreateProject => _browserInteractions.WaitAndReturnElement(ClkCreateProject);
        private IWebElement ClickOnCard => _browserInteractions.WaitAndReturnElement(SelectCardOnNewProject);
        private IWebElement ClickOnAllExpert => _browserInteractions.WaitAndReturnElement(ClickAllExpert);
        private IWebElement ClickOnConsulting => _browserInteractions.WaitAndReturnElement(ClickConsulting);
        private IWebElement EnterOnSkill => _browserInteractions.WaitAndReturnElement(EnterSkill);
        private IWebElement ClickOnNext => _browserInteractions.WaitAndReturnElement(ClickNext);
        private IWebElement ProductOnDevelopment => _browserInteractions.WaitAndReturnElement(ProductDevelopment);
        private IWebElement ChooseSubCategory => _browserInteractions.WaitAndReturnElement(ChosseCategory);
        private IWebElement ClickOnConsultingCheckBox => _browserInteractions.WaitAndReturnElement(ClickConsultingCheckBox);
        private IWebElement ClickOnRadioBtn => _browserInteractions.WaitAndReturnElement(ClickRadio);
        private IWebElement ClikOnSubDrop => _browserInteractions.WaitAndReturnElement(ClickSubDrop);
        private IWebElement ClickOnSPP => _browserInteractions.WaitAndReturnElement(ClickStartPosting);
        private IWebElement ClcikText => _browserInteractions.WaitAndReturnElement(ClickOnSkillText);
        private IWebElement ClickOnProposalDetails => _browserInteractions.WaitAndReturnElement(ClickProposalDetails);
        private IWebElement ClcikOnViewProposal => _browserInteractions.WaitAndReturnElement(ClickViewProposal);
        private IWebElement ClickOnBilling => _browserInteractions.WaitAndReturnElement(ClcikBilling);
        private IWebElement AddOnFund => _browserInteractions.WaitAndReturnElement(AddFund);
        private IWebElement AddToAmount => _browserInteractions.WaitAndReturnElement(AddAmount);
        private IWebElement Credit_DebitCard => _browserInteractions.WaitAndReturnElement(Credit_DebitXpath);
        private IWebElement AddFundProject => _browserInteractions.WaitAndReturnElement(AddFundToThis);
        private IWebElement ClickOnHistory => _browserInteractions.WaitAndReturnElement(ClickTransicationHistory);
        private IWebElement clickReseach => _browserInteractions.WaitAndReturnElement(ResearchDevelopment);
        private IWebElement Click_Consulting => _browserInteractions.WaitAndReturnElement(ClickConuslting);
        private IWebElement ClickMarketResearch => _browserInteractions.WaitAndReturnElement(MarketResearch);
        private IWebElement clickResearch => _browserInteractions.WaitAndReturnElement(Research);
        private IWebElement ClickBtnPay => _browserInteractions.WaitAndReturnElement(BtnPay);
        private IWebElement ClickProjectTtitle => _browserInteractions.WaitAndReturnElement(ProjectTitle);
        private IWebElement ClickDecideLate => _browserInteractions.WaitAndReturnElement(ClickOnDecideLate);
        private IWebElement ClickPostProject => _browserInteractions.WaitAndReturnElement(PostProject);
        private IWebElement ProposalOnXpath => _browserInteractions.WaitAndReturnElement(Proposal_Xpath);





        public void ClickOnBrowserNotificationAlert()
        {
            BrowserNotificationAlert.Click();
        }

        public void EnterSelectSubject(string text)
        {
            SelectSubject.SendKeysWithClear(text);
            SelectSubject.SendKeys(Keys.Enter);
        }

        public void ClickOnHireACC1ForBid()
        {
            HireACC1ForBid.Click();
        }
        public void ClickHireTestBtn()
        {
            HireTestBtn.Click();
        }

        public void ClickBidFromTestAcc1TextArea(string text)
        {
            BidFromTestAcc1TextArea.SendKeysWithClear(text);
        }

        public void ClickOnHireOnTestAcc1()
        {
            HireOnTestAcc1.Click();
        }

        public void ClickPostOnMessage()
        {
            PostOnMessage.Click();
        }

        public void ClickPublicMessageBoard(string text)
        {
            PublicMessageBoard.SendKeysWithClear(text);
        }
        public void ClickOnProjectDetails()
        {
            ProjectOnDetails.Click();
        }
        public void ClickOnProposalXpath()
        {
            ProposalOnXpath.Click();
        }
        public void ClickOnCardNumber()
        {
            CardNumber.Click();
        }

        public void CLickOnConfirm()
        {
            ToConfirm.Click();
        }
        public void ClickCredit_Debit_Card()
        {
            Credit_Debit_Card.Click();
        }
        public void ClickOnAddProjectFund(string usdfund)
        {
            AddProjectFund.SendKeysWithClear(usdfund);
        }

        public void ClickAddOnfund()
        {
            AddOnfund.Click();
        }

        public void ClickProjectOnTitle()
        {
            ProjectOnTitle.Click();
        }

        public void ClickPayNowBtn()
        {
            PayNowBtn.Click();
        }

        public void ClickAmountToBeTransfer(string usdamount)
        {
            AmountToBeTransfer.SendKeysWithClear(usdamount);
        }
        public void ClickPayFreelancer()
        {
            PayFreelancer.Click();
        }

        public void ClickTestProjectTitle()
        {
            TestProjectTitle.Click();
        }
        public void ClickOn_fa_fa_deleteBtn()
        {
            Clk_fa_fa_deleteBtn.Click();
        }
        public string NextPage()
        {
            return NextPageIconLink.Text;
        }
        public string LoggedInProve()
        {
            return LoggedIn.Text;
        }

        public string IncreasedammountshowsupProve()
        {
            return Increasedammountshowsup.Text;
        }

        public string AddFundsWindowOpenProve()
        {
            return AddFundsWindowOpen.Text;
        }
        public string ProveofFundedProjectCheck()
        {
            return ProveofFundedProject.Text;
        }
        public string ModalMessageProve()
        {
            return ModalMessage.Text;
        }
        public string BalanceCurrencyShowsProve()
        {
            return BalanceCurrencyShows.Text;
        }
        public string TotalFundedProjectDetailsProve()
        {
            return TotalFundedProjectDetails.Text;
        }

        public IWebElement LastPage()
        {

            return LastPageIconLink;
        }

        public string PreviousPage()
        {
            return PreviousPageIconLink.Text;
        }

        public string TotalWalletBalanceCheck()
        {
            return TotalWalletBalance.Text;
        }
        public void ClickWalletBalance()
        {
            TotalWalletBalance.Click();
        }
        public void ClickonCosultingFirstClick()
        {
            ClickonCosultingFirstModal.Click();
        }
        public void FreelancerInviteButtonLink()
        {
            FreelancerInviteButton.Click();
        }
        public void InviteExpert()
        {
            InviteExpertLink.Click();
        }

        public void ClickTechnecialConsulting()
        {
            TechnecialOnConsulting.Click();
        }
        public IWebElement FirstPage()
        {
            return FirstPageIconLink;
        }

        public string GetLabelName()
        {
            return LabelName.Text;
        }
        public string AssertPrivateTextProve()
        {
            return AssertPrivateText.Text;
        }
        public string AssertPublicMessageBoardProve()
        {
            return AssertPublicMessageBoard.Text;
        }
        public string CommittedBalanceCheck()
        {
            return CommittedBalance.Text;
        }
        public string SuccessfulMessageCheck()
        {
            return SuccessfulMessage.Text;
        }

        public void PublicMessageTextAreaClickandSend()
        {
            PublicMessageTextAreaLink.Click();
            PublicMessageTextAreaLink.SendKeysWithClear("Test Public message");
        }
        public void MessagetoFreelancerCustomInputClick()
        {
            MessagetoFreelancerCustomInput.Click();
            MessagetoFreelancerCustomInput.SendKeysWithClear("Test Public Freelancer Invite");
        }
        public void AmmountAreaisEditableProve()
        {
            AmmountAreaisEditable.Click();
            AmmountAreaisEditable.SendKeysWithClear("110");
        }

        public string PublicMessageTextCheckLinkProve()
        {
            return PublicMessageTextCheckLink.Text;
        }

        public void PostMessageClick()
        {
            PostMessageLink.Click();
        }

        public void InviteFreelancerTextClick()
        {
            InviteFreelancerText.Click();
        }
        public void SelectProjectoneClick()
        {
            SelectProjectone.Click();
        }
        public void SelectProjectDropDownModalClick()
        {
            SelectProjectDropDownModal.Click();
        }
        public void ClickOnSecondProjectClick()
        {
            ClickOnSecondProject.Click();
        }
        public void ModalMessageCloseClick()
        {
            ModalMessageClose.Click();
        }
        public void ClickConfirmFundClick()
        {
            ClickConfirmFund.Click();
        }
        public void SelectCardTwoClick()
        {
            SelectCardTwo.Click();
        }
        public void CardDropdownClick()
        {
            CardDropdown.Click();
        }
        public void CreditCardButtonClick()
        {
            CreditCardButton.Click();
        }

        public void BillingPageButtonClick()
        {
            BillingPageButton.Click();
        }
        public void WalletDivClick()
        {
            WalletDiv.Click();
        }
        public void AddFundsClick()
        {
            AddFunds.Click();
        }

        public void DropDownClick()
        {
            DropDown.Click();
        }
        public void DropDowninputText()
        {
            DropDownInput.SendKeysWithClear("Test");
        }
        public void ProjectDescription()
        {
            ProjectDescriptionInput.SendKeysWithClear("Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ");
        }
        public void FirstProjectClick()
        {
            FirstProject.Click();
        }
        public void SecondProjectClick()
        {
            SecondProject.Click();
        }

        public string ModiefiedTextPage()
        {
            return ModiefiedText.Text;
        }
        public void RejectDeadlineClick()
        {
            RejectDeadline.Click();
        }
        public void SendMessageButtonClick()
        {
            SendMessageButton.Click();
        }
        public void ApproveNewDeadlineClick()
        {
            ApproveNewDeadline.Click();
        }
        public void WorkSpaceXpathLink()
        {
            WorkSpace.Click();
        }
        public void ProposalsClick()
        {
            Proposals.Click();
        }
        public void ProjectDetailsXpathLink()
        {
            ProjectDetails.Click();
        }
        public void SendTextClick()
        {
            SendText.Click();
        }
        public void SendButtonClick()
        {
            SendButton.Click();
        }
        public void MessageTypeClick()
        {
            MessageType.Click();
        }
        public void ReplyClick()
        {
            Reply.Click();
        }

        public string DeadlineCheck()
        {
            return Deadline.Text;
        }
        public string TestFileDeletedProve()
        {
            return TestFileDeleted.Text;
        }

        public void SendTextLink(string txt)
        {

            SendText.SendKeysWithClear(txt);
        }

        public void MessageTypeClick(string txt)
        {

            MessageType.SendKeysWithClear(txt);
        }


        public string AssertTextPage()
        {
            return AssertText.Text;
        }
        public string NewTagProve()
        {
            return NewTag.Text;
        }
        public string assterbrowsefileLick()
        {
            return assterbrowsefile.Text;
        }

        public void TagFileClick()
        {
            TagFile.Click();
        }
        public void SaveTagClick()
        {
            SaveTag.Click();
        }

        public void RemoveTagClick()
        {
            RemoveTag.Click();
        }
        public void DeleteFileClick()
        {
            DeleteFileLink.Click();
        }
        public void ConfirmDeleteClick()
        {
            ConfirmDeleteLink.Click();
        }

        public void TagInputClick(string txt)
        {

            TagInput.SendKeysWithClear(txt);
        }


        //..-534

        public void PressOnProposal()
        {
            ClickOnProposal.Click();
        }

        public void ClickOnTextHire()
        {
            ClickOnHireTestAcc1.Click();
        }

        public void EnterTextAreaField(string text)
        {
            EnterTextArea.SendKeysWithClear(text);
        }

        public void ClickOnHireTest()
        {
            ClkOnHireTestAcc1.Click();
        }

        public string AssertionTxt()
        {
            return Assertion.Text;
        }
        public void ProposalDetails()
        {
            ClickOnProposalDetails.Click();
        }
        public void ViewProposal()
        {
            ClcikOnViewProposal.Click();
        }

        //..-2342
        public void EnterCreateProject()
        {
            ClickOnCreateProject.Click();
        }

        public void ClickOnNewProjectCard()
        {
            ClickOnCard.Click();
        }

        public void AllExpert()
        {
            ClickOnAllExpert.Click();
        }

        public void Consulting()
        {
            ClickOnConsulting.Click();
        }

        public void ClickOnProductDevelopment()
        {
            ProductOnDevelopment.Click();
        }
        public void EnterTextInput()
        {
            EnterOnSkill.Click();
        }

        public void ClickOnNextBtn()
        {
            ClickOnNext.Click();
        }

        public void ClickChooseCategory()
        {
            ChooseSubCategory.Click();
        }

        public void PressConsulting()
        {
            Click_Consulting.Click();
        }

        public void MarketResearchMethod()
        {
            ClickMarketResearch.Click();
        }

        public void ClickOnResearch()
        {
            clickReseach.Click();
        }
        public void ClickCheckBox()
        {
            ClickOnConsultingCheckBox.Click();
        }
        public void ClickRadioBtn()
        {
            ClickOnRadioBtn.Click();
        }


        public void ClickOnSubDropdown()
        {
            ClikOnSubDrop.Click();
        }
        public void ClickSPPBtn()
        {
            ClickOnSPP.Click();
        }

        public void ClkOnResearchAndDevelopment()
        {
            clickReseach.Click();
        }
        public void EterProjectTilteText(string text)
        {
            ClickProjectTtitle.SendKeysWithClear(text);
        }

        public void PressDecideLater()
        {
            ClickDecideLate.Click();
        }

        public void PostOnProject()
        {
            ClickPostProject.Click();
        }


        public void ClickOnBill()
        {
            ClickOnBilling.Click();
        }

        public void AddToFund()
        {
            AddOnFund.Click();
        }

        public void AddUSDAmount(string dollar)
        {
            AddToAmount.SendKeysWithClear(dollar);
        }

        public void CreditDebitCard()
        {
            Credit_DebitCard.Click();
        }
        public void PayBtnSubmitBtn()
        {
            ClickBtnPay.Click();
        }

        public void FundToProject()
        {
            AddFundProject.Click();
        }
        public void ClkHistory()
        {
            ClickOnHistory.Click();
        }
        public void Clk_History()
        {
            //CLick_History.Click();
        }


    }

}

