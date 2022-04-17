
Feature: Client

# TCM-191 : 'Next' and 'Previous' button icons(<< < > >>) are available in pagination when more than 1 page of profiles is available
@Smoke
Scenario: 'Next' and 'Previous' button icons(<< < > >>) are available in pagination when more than 1 page of profiles is available
	Given I am on 'Expert Profiles' page
	And   User Accept cookies
	When 'Expert's' container is loaded
	And I switch to the last pagination page
	Then I should see Previous button available
	When I switch to the first pagination page
	Then I should see Next page button available

# TCM-683: User should be able to browse files in private message
@Smoke
Scenario: 'User' should be able to browse files in private message
	Given user logged in to kolabtree as client
	And user has bid ongoing project
	And user is on manage project page
	When user try to browse file with given extension as (jpg, .png, .mp ,video file, doc, xlsx,pdf,zip,rar,z)
	Then user should see the file should be uploaded in form of  message

# TCM-646 Client can reject the project deadline modified by freelancer
Scenario: Client can reject the project deadline modified by freelancer
	Given I logged in as client
	When I clicks on proposals tab
	And I select project from dropdown
	And I should see a message The proposal has been modified. Please accept or reject freelancers changes. under  Fee and Deadline section
	And I clicks on Reject New deadline button
	Then I should see new deadline should not updated under Fee and Deadline section1

# TCM-578 Client can accept the project deadline modified by freelancer
Scenario: Client can accept the project deadline modified by freelancer
	Given I logged in as client
	When I clicks on proposals tab
	And I select project from dropdown2
	And I should see a message The proposal has been modified. Please accept or reject freelancers changes. under  Fee and Deadline section
	And I clicks on accept New deadline button
	Then I should see new deadline should be updated under Fee and Deadline section2

# TCM-1419: Client can send a message to freelancer
Scenario: Client can send a message to freelancer
	Given I am logged into as a client with few awarded projects
	When I open the workspace
	And I try to send a message to a freelancer
	Then I should see a message delivered successfully

# TCM-3689: Client can send private message from system
Scenario: Client can send private message from system
	Given user login to Kolabtree existing account as client

	And user is having a project under open for proposals state

	And user navigate to Proposals page and selects the project

	And user opens private messages modal on the proposal

	And user enter message as Test Private message

	When user clicks on Send message CTA

	Then user should see the message is sent to freelancer over private message channel


## TCM-3681: Client can send file in workspace message from system
Scenario: Client can send file in workspace message from system
	Given user is on Kolabtree as Client

	And user has project in confirmed state

	And user navigate to workspace

	When user try to upload a file except blacklisted file on workspace messaging

	Then user should see file uploaded successfully

# TCM-685: User should be able to tag the uploaded file
@Smoke
Scenario: User should be able to tag the uploaded file
	Given user is on Kolabtree as Client

	And user has project in confirmed state

	And user navigate to workspace

	When user try to tag a file

	Then user should see file tagged successfully

# TCM-1476: Client can delete uploaded file
Scenario: Client can delete uploaded file
	Given user is on Kolabtree as Client
	And user navigate to workspace
	When I click on delete file button and confirms  delete option
	And I clicks on Save button
	And I should see that the hyperlink link on file name should get removed

# TCM-1240: Submit login with correct freelancer credentials
@Smoke
Scenario: Submit login with correct freelancer credentials
	When I click the Log In link I should see Login popup
	When I enter correct email address
	And I enter correct password
	And I click Sign In button
	Then I should be logged into successfully


#TCM-3086: Client can send public message from public message board
@Smoke
Scenario: Client can send public message from public message board
	Given user is on Kolabtree as Client
	And user has bid ongoing project
	And user navigates to manage project page
	When  user open the project
	Then user should see public message board present under project details tab
	And user enters message and send


#TCM-1475: Client should be able to tag the uploaded file on workspace
@Smoke
Scenario: Client should be able to tag the uploaded file on workspace
	Given user is on Kolabtree as Client

	And user has project in confirmed state

	And user navigate to workspace

	When user try to tag a file

	Then user should see file tagged successfully


## TCM-684: User should be able to delete the uploaded file
Scenario: User should be able to delete the uploaded file
	Given user is on Kolabtree as Client
	And user navigate to workspace
	When I click on delete file button and confirms  delete option
	And I clicks on Save button
	And I should see that the hyperlink link on file name should get removed

#TCM-1117: Check the different amounts when user funds a project using saved credit/debit card
Scenario: Check the different amounts when user funds a project using saved credit/debit card
	Given I logged in to kolabtree account as Client
	And I click on Billing page tab present on side menu
	And I have funds in my E_Wallet Available balance and Total wallet Balance
	And I do not have any funds in my committed balance
	And I clicks on Billing page
	And I click on Fund this project button under section
	And I see a section Fund this project section opens in side
	And I select Pay by card radio button, if not selected
	And I see the amount is editable in enter the amount field
	And I clicks on Select a card drop down and select saved card
	When I click on Pay to add funds to wallet button
	Then I should see the project is funded with USD
	And I Should see a successful message displays on screen Your funds are added for the project.
	And Committed Balance should reflect as USD
	And Project Wallet Balance under Billing Details should reflect USD
	And I should see Total wallet balance increases to USD

##..
#TCM-534: Manage project: Accept bid
Scenario: Manage project: Accept bid
	Given I have a project 'Project1' posted
	And I have Bid1 and Bid2 bids submitted to project 'Project1'
	And I am on 'Proposals' page
	When I click 'Accept' button for 'Bid1'
	And I confirm 'Accept confirmation' message
	Then I should see status should get changed from 'Viewed' to 'Accepted' for 'Bid1'
	And I should see status should not get changed for 'Bid2'
	When I open 'Projects' screen on admin dashboard
	Then I should see 'Confirmed' status next to 'Project1'
	When I open 'Bids' screen on admin dashboard
	Then I should see 'Accepted' status next to 'Bid1' bid3
	And I should see 'Created' status next to 'Bid2' bid

##..
#TCM-2342: Client can send invite to freelancer from 'Request a Service' button
Scenario: Client can send invite to freelancer from 'Request a Service' button
    Given I am on Kolabtree as an existing client
	And I login to my account
	And I have more than 1 projects in created state
	And I navigate to any of the pages
	And I click on 'Request a service' modal against any freelancer name
	And I can see modal opens
	And  a project is pre selected on the modal
	And I click on 'change project' button on modal
	And I select the project from dropdown
	And I enter a custom message under message Text area as <Send invite to freelancer>
	When I click on 'Invite<freelancer name>' button
	Then I can see an invite email is sent to freelancer
	And A success message reflects on modal
	And count of  freelancer invites out of 10 shows on modal

##..
#TCM-2523: Verify different balances after transfer from client KW wallet to freelancer KW wallet for fixed fee with VAT
Scenario: Verify different balances after transfer from client KW wallet to freelancer KW wallet for fixed fee with VAT
    Given  user login to Kolabtree as client
	And user is having a confirmed fixed fee with VAT funded project
	And user funded amount is reflecting under 'KW' wallet
	When user performs transfer of funded amount
	Then user should see Total Wallet balance – by transferred amount
	And user available balance gets NA
	And user committed balance gets – by transferred amount
	And user should see freelancer Total Wallet balance ++ by (transferred amount minus Kolabtree service fee of 20%)

#TCM-1113: Check the adjusted amount when user adds funds to E_Wallet using saved card
Scenario: Check the adjusted amount when user adds funds to E_Wallet using saved card
    Given I logged in to kolabtree account as Client
	And I click on 'Billing page' tab present on side menu
	And I dont have any funds in my wallet
	And I clicks on 'Add funds to wallet' link present on billing page
	And I see 'Add funds to wallet' section opens
	And I select ' Pay by Card' radio button option in the section
	And I enter the amount say $$ 10 USD $$ in 'Enter the amount' text box
	And I select a saved card from ' Use existing card ending' section
	And I see 'Total wallet balance' updated to USD 10
	And I see 'Amount paid towards ongoing projects' remains to O USD
	And I see 'Available wallet balance' updated to USD 10
	And I see 'Net amount to be paid' updated to USD 10
	When I click on 'Confirm and Pay' button
	Then I should see the funds are added to my E_Wallet
	And 'Total Wallet Balance' should reflect as USD 10
	And 'Available Balance' should reflect as USD 10
	And 'Comitted Balance' should reflect as USD 0, if no project is funded
	And in the table under 'Total wallet Balance' column a record of 10 USD is added in database
	And in the table under 'User Uncommitted Balance' columncord of 10 USD is added in database

#TCM-2508: Check different balances when user funds a project by wallet which is funded by stripe card
Scenario: Check different balances when user funds a project by wallet which is funded by stripe card
   Given user is on Kolabtree client account
   And user click on'Billing" button
   And user click on a project title
   And user click on 'Add funds'
   And user enter Amount <USD 10.00>
   And user click on 'credit/debit card' radio button
   And user click on 'Confirm and pay'button
   Then Total wallet balance will reduce

#TCM-506: Public message from Project owner should reflect under public messaging Board for freelancer and on email
Scenario: Public message from Project owner should reflect under public messaging Board for freelancer and on email
   Given  I login to kolabtree market place from client account
   And I created a project
   And I sent a public message from public message board present on 'proposals' page
   And I loggedin to freelancer account
   And I naviagted to create bid page for that project
   When I click on public 'message tab'
   Then I should see message from client received with client name as 'Project Owner'
   And I should  not see client name
   And I should receive an email with subject line as 'Kolabtree: New public message about <Project name> ' on freelancer email account

