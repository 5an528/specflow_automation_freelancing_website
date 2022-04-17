Feature: Freelancer

# TCM-491: Freelancer can initiate public messaging
Scenario: Freelancer can initiate public messaging
	Given I login to kolabtree as freelancer
	And I navigated to browse projects page
	And I click on view details for any projectgin 
	And I click on public message tab
	And I enter Test Public message text
	When I click on Ask question button
	Then I should see message posted and should reflect under ‘Messages’ section


# TCM-1399: Freelancer can send a private message from Proposals page
Scenario: Freelancer can send a private message from Proposals page
	Given I have an account
	When I log into
	And I open Proposals tab
	Then I should see activated messaging container
	And I can send a message

# TCM-1490: Freelancer can send a message to client
Scenario: Freelancer can send a message to client
	Given I am logged into as a freelancer with few accepted proposals
	When I open workspace
	And I try to send a message to a client
	Then I should see message delivered successfully

# TCM-3685: Freelancer can delete uploaded file
Scenario: Freelancer can delete uploaded file
	Given user login to Kolabtree existing account as freelancer

	And user is having a project under confirmed state

	And user navigate to /workspace page

	And user selects confirmed project

	And user uploads a file under workspace messaging

	And user clicks on delete icon next to file

	And user should see a warning! popup as Are you sure you want to remove filename file?

	When user clicks on ‘ok’ button on popup

	Then user should see the file link is removed

	And file cannot be downloaded


# TCM-1716: 'Become a Expert' button on footer should open create account form popup
Scenario: 'Become a Expert' button on footer should open create account form popup

	Given I am on Kolabtree Home page
	And I clicks on any Become an Expert button present on footer without logged in to kolabtree account
	Then a popup should open focusing on create account tab


# TCM-3078: Correct URL is shown when clicking on 'Blog' link on footer
Scenario: Correct URL is shown when clicking on 'Blog' link on footer
	Given user is on Kolabtree home page
	And user is in loggedin/non loggedin mode
	When user clicks on Kolabtree Blog link present under Follow Us Section
	Then user should be redirected to The Kolabtree Blog: Research, Innovation and The Future of Work   url in new tab


# TCM-1707(part-1) Under 'Follow US' section each link should redirect to respective links
Scenario: (part-1) Under 'Follow US' section each link should redirect to respective links
	Given user is on Kolabtree home page
	And user is in loggedin/non loggedin mode
	When user clicks on Twitter link present under Follow Us Section
	Then user should be redirected to The Twitter url in new tab

# TCM-1707(part-2) Under 'Follow US' section each link should redirect to respective links
Scenario: (part-2) Under 'Follow US' section each link should redirect to respective links
	Given user is on Kolabtree home page
	And user is in loggedin/non loggedin mode
	When user clicks on Facebook link present under Follow Us Section
	Then user should be redirected to The Facebook url in new tab

## TCM-1707(part-3) Under 'Follow US' section each link should redirect to respective links
#Scenario: (part-3) Under 'Follow US' section each link should redirect to respective links
#	Given user is on Kolabtree home page
#
#	And user is in loggedin/non loggedin mode
#
#	When user clicks on LinkedIn link present under Follow Us Section
#
#	Then user should be redirected to The LinkedIn url in new tab

# TCM-1706: Under 'Experts by Skill' section each link should redirect to respective linked page
Scenario: Part Under 'Experts by Skill' section each link should redirect to respective linked page
	Given I am on Kolabtree homepepage
	And I scroll to footer of homepage
	When I click on  hyperlink under Experts by Skill section
	Then I should navigate to the pages

# TCM-1708: 'Home' hyperlink on footer should redirect the user to kolabtree homepage
Scenario: 'Home' hyperlink on footer should redirect the user to kolabtree homepage
	Given user is on Kolabtree home page in loggedin /nonloggedin mode
	When user clicks on Home link present in footer
	Then user should be redirected to kolabtree home page only

# TCM-1709: 'Success Stories' hyperlink should redirect the user to success stories page
Scenario: 'Success Stories' hyperlink should redirect the user to success stories page
	Given user is on Kolabtree home page in loggedin /nonloggedin mode
	When user clicks on Success Stories link present in footer
	Then user should be redirected to kolabtree Success Stories page only


# TCM-1718: 'Valid Address' should be present on footer section
Scenario: 'Valid Address' should be present on footer section
	Given user is on Kolabtree home page in loggedin /nonloggedin mode
	When user scroll and go to footer
	Then user should be read kolabtree Valid Address on footer


# TCM-2464: 'About Us' link redirects to about us page
Scenario: 'About Us' link redirects to about us page
	Given user is on Kolabtree home page in loggedin /nonloggedin mode
	When user clicks on About Us  link present in footer
	Then user should be redirected to kolabtree About us page only

# TCM-2831: 'Frequently ask question' link reflects below 'Refer a friend' button
Scenario: 'Frequently ask question' link reflects below 'Refer a friend' button
	Given I am on Kolabtree
	And I am on any of the pages in logged out mode
	When  I scroll to footer
	Then I should see Frequently asked questions link present below Refer a friend button
	And I click on the link
	And I should redirect to support page in new tab

# TCM-1241: Submit Login with correct hiring credentials
Scenario: Submit login with correct hiring credentials
	Given I am on Kolabtree Home Page1
	And I click on Log In button present on homepage header
	And I should see a popup opens focusing on Log in tab
	And I enter hiring credentials email id
	And I click on Log in button
	Then I should get successfully logged in to kolabtree account

# TCM-503: Verify the functionality of create bid for hourly fee with all valid data with VAT added
Scenario: Verify the functionality of create bid for hourly fee with all valid data with VAT added
	Given I login to kolabtree as freelancer
	And user navigate to create-bid page for any hourly fee project
	And user enter all fields on step
	And user clicks on Enter fee and deadline CTA
	And user add Proposed Hourly Fee as 100
	And user add No. Of Hours as Ten
	And user select deadline
	When user clicks on Create proposal CTA
	Then  user should see the proposal is created successfully and user is navigated to proposals page
	And user should see all details reflect correctly for the proposal on the proposals page

# TCM-501: Verify the functionality of create bid for fixed fee with all valid data and VAT added
Scenario: Verify the functionality of create bid for fixed fee with all valid data and VAT added
	Given I login to kolabtree as freelancer
	And user navigate to create-bid page for any fixed fee project
	And user enter all fields on step
	And user clicks on Enter fee and deadline CTA
	And user add Proposed Hourly Fee as 100
	And user select deadline for fixed fee
	When user clicks on Create proposal CTA
	Then  user should see the proposal is created successfully and user is navigated to proposals page
	And user should see all details reflect correctly for the proposal on the proposals page for Fixed Fee


#TCM-3678: Freelancer should be able to tag the uploaded file
Scenario: Freelancer should be able to tag the uploaded file
	Given I login to kolabtree as freelancer
	And user is having open for proposals project present in their account
	And user navigate to proposals page
	And user uploads a file under private messaging channel
	When user clicks on tag icon present next to uploaded file
	And user enters tag as File tagged
	And user clicks as Save
	Then user should see the tag has been added to file name


#TCM-1504: freelancer user add file tag name when freelancer uploaded file
Scenario: freelancer user add file tag name when freelancer uploaded file
	Given I login to kolabtree as freelancer
	And I open workspace
	And I clicks on Browse file button and upload file
	And I should see uploaded file under uploaded files box contains
	When I clicks on Add Tag button and insert tag name
	And I click on Save button
	And I should see  uploaded file tag name


#TCM-499: Correct projects Details should reflect under Public message tab for 'Hourly fee' projects
Scenario: Correct projects Details should reflect under Public message tab for 'Hourly fee' projects
	Given I login to kolabtree as freelancer
	And I navigated to browse projects page
	And I click on view details for any hourly fee project with Project Title: Service Category and Sub service, Project Description, Expertise required:,  Fee Type, Fee, Project duration: , No. of hours Per Week: added
	And I navigated to create bid page
	When I click on public message tab
	Then I should see Project Title: Service Category and Sub service on top of page
	And I should see Project Description, Expertise required: under Project Description section
	And I should see Fee Type, Fee, Project duration:, No. of hours Per Week: under Project Budget section
	And I should see Clients timeline for hiring

#TCM-1688: CTA's on header should navigate to requested pages for logged out and users
Scenario: CTA's on header should navigate to requested pages for logged out and users
	Given I am on Kolabtree Home Page
	When I click on Kolabtree link present on homepage header
	Then I should navigate to Koalbtree Home Page with url as www.kolabtree.co
	And I click on Projects link present on homepage header
	Then I should navigate to Browse Projects Page with url as www.kolabtree.com/projects
	And I click on find an expert link present on homepage header
	Then I should navigate to Browse Projects Page with url as /find-an-expert page
	And I click on how-it-works link present on homepage header
	Then I should navigate to how-it-works Page with url as www.kolabtree.com/how-it-work
	And I click on Services dropdown link present on homepage header
	And I click on each service under dropdown
	Then I should navigate to  clicked service page with url as www.kolabtree.com/Services/service name/
	And I click on Solutions dropdown link present on homepage header
	And I click on each industry under dropdown
	Then I should navigate to  clicked option
	And I click on Join as expert button
	Then I should see signup modal should open
	And I click on sign IN button
	Then I should see sign in modal should open
	And I click on Request a service button
	Then I should navigate to create project form with url as /create-project

#TCM-3676: FL can send file on freelancer bid page in private message from system
Scenario: FL can send file on freelancer bid page in private message from system
	Given user login on kolabtree as Freelancer
	And user is on freelancer bid page
	And user is on Proposal tab
	When user try to browse given extension file (jpg, png, mpFour , video file, doc, xlsx, pdf, zip, rar, sevenZ)
	Then user can send files from system successfully

#TCM-3677: Freelancer should be able to delete the uploaded file
Scenario: Freelancer should be able to delete the uploaded file
	Given user login on kolabtree as Freelancer

	And user is having open for proposals project present in their account1

	And user is on Proposal tab

	And user uploads a file under private messaging channel

	And user clicks on delete icon next to uploaded file

	And user should see a warning! popup as Are you sure you want to remove filename v1

	When user clicks on ok button on pop v1

	Then user should see the file link is remove v1

	And file cannot be download v1

#TCM-2693: 'Institution name' applied filter should show the list of selected 'Institution name' profiles only, sort by descending profile score
Scenario: 'Institution name' applied filter should show the list of selected 'Institution name' profiles only, sort by descending profile score
	Given I am on find an expert page

	And I select any institution by typing a letter a

	And I select an option from auto suggest dropdown

	When I click on apply filter button

	Then I should see the profiles with selected institution name reflects only

	And I should see the ordering of profile is done as per freelancer profile score ordered by highest to lowest


#TCM-2690: Country applied filter should show the list of selected countries profiles only sort as per profile score and ES score
Scenario: Country applied filter should show the list of selected countries profiles only sort as per profile score and ES score
	Given I am on find an expert page

	And I select India under country drop down

	When I click on apply filter button

	Then I should see the profiles with country as India only

	And I should see the ordering of profile is done as per freelancer profile score ordered by highest to lowest

#TCM-179: All subject expertise matching the filter should be shown in subject area ordered by descending profile score
#Scenario: All subject expertise matching the filter should be shown in subject area ordered by descending profile score
#	When Experts container is loaded
#	And I select subject Biophysics in search filter
#	And I select subject Crystallography in search filter
#	And I click Add filter button
#	And I select subject Bioinformatics in search filter
#	And I click Add filter button
#	And I select subject Structural Biology in search filter
#	Then I see more than 4 subject areas when all of them are matching search filter
#	And the loaded list should reflect as per the profile score from highest to lowest


#TCM-1231: Freelancer can send file in workspace message from system
Scenario: Freelancer can send file in workspace message from system
    Given I am logged into Kolabtree as freelancer
	When I clicked on 'Workspace' tab
	When I clicks on Browse file button and upload file
	Then I should see uploaded file under messages section with delete and tag icon

#TCM-2762 : Profiles appear on recommendations page as per the matching subject area of project, applied as filter
Scenario: Profiles appear on recommendations page as per the matching subject area of project, applied as filter
    Given I am on a Kolabtree home page
	And I create a project  with subject area as 'Marketing'
	When I navigate to 'recommendations' page
	Then I should see the profiles display as per 'Marketing' under filter applied

#TCM-179 :  All subject expertise matching the filter should be shown in subject area ordered by descending profile score
Scenario: All subject expertise matching the filter should be shown in subject area ordered by descending profile score
    Given  I am on a 'Expert Profiles' page
	When 'Expert's' container is loaded on
	And I select subject 'Biophysics' in search filter
	And I click 'Add filter' button
	And I select subject 'Crystallography' in search filter
	And I click 'Add filter' button
	And I select subject 'Bioinformatics' in search filter
	And I click 'Add filter' button
	And I select subject 'Structural Biology' in search filter
	And I click 'Add filter' button
	Then I see more than 4 subject areas when all of them are matching search filter
	And the loaded list should reflect as per the profile score from highest to lowest

#TCM-882 : When User clicks on confirm transfer button then freelancer should received an email with attachment (FL to client and kolabtree to FL invoices)
Scenario: When User clicks on confirm transfer button then freelancer should received an email with attachment (FL to client and kolabtree to FL invoices)
    Given I am logged into Kolabtree as a Freelancer
	And Client has performed the fee transfer
	When I navigate to the 'Billing' page
	And I should be received an email with two invoices as an attachment