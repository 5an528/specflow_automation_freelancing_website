Feature: CreateProject

Background: User can login and go to home page
   Given User will go to Kolabtree Website
   When  User click on Login
   And   User fill username
   And   User fill password
   Then  User can click on login and go to home page

	# TCM-1609 : Verify the validation when user enters wrong coupon code
Scenario: Verify the validation when user enters wrong coupon code
	Given User can switch to Project Owner
	And   User click on Create Project
	And   User reaches to promotion code step
	When  User enter promotion code "asddfg"
	And   User Click on Apply Button
	Then  User should get promo code invalid messaage

#	# TCM-1626 : Show the Terms and conditions after successful adding of discount coupon
#Scenario: Show the Terms and conditions after successful adding of discount coupon
#	Given User can switch to Project Owner
#	And   User click on Create Project
#	And   User reaches to promotion code step
#	When  User enter promotion code "KOLAB100"
#	And   User Click on Apply Button
#	Then  user should see promo code should get applied
#	And   user should see T&C link should be visible for user

#	# TCM-1875 : Verify create project functionality for fixed fee with all valid data
#Scenario: Verify create project functionality for fixed fee with all valid data
#    Given User can switch to Project Owner
#	And   User click on Create Project
#	And   User is on fee step
#	And   User selects fee type as fixed fee
#	When  User successfully post project
#	Then  User should see on proposal page , fee type should be saved as fixed fee
#	And   User should see all entered data should get saved correctly

#	# TCM-1876 : Verify create project functionality for hourly fee on per week basis with all valid data
#Scenario: Verify create project functionality for hourly fee on per week basis with all valid data
#    Given User can switch to Project Owner
#	And   User click on Create Project
#	And   User is on fee step
#	And   User selects fee type as Hourly fee
#	And   User selects Per Week as fee
#	When  User successfully post project
#	Then  User should see on proposal page, fee type should be saved as hourly fee with Per week basis
#	And   User should see all entered data should get saved correctly

#	# TCM-1877 : Verify create project functionality for hourly fee on per month basis with all valid data
#Scenario: Verify create project functionality for hourly fee on per month basis with all valid data
#    Given User can switch to Project Owner
#	And   User click on Create Project
#	And   User is on fee step
#	And   User selects fee type as Hourly fee
#	And   User selects Per Month as fee
#	When  User successfully post project
#	Then  User should see on proposal page, fee type should be saved as hourly fee with Per Month basis
#	And   User should see all entered data should get saved correctly


#Scenario: Validation message when user tries to upload a blacklisted file
#    Given User can switch to Project Owner
#	And   User click on Create Project
#	And   User is on Upload file step
#	When  When user upload a blacklisted file with extension as
#	Then  User should verify validation message

	# TCM-2203 : Verify all languages are allowed in project title
#Scenario: Verify all languages are allowed in project title
#    Given User can switch to Project Owner
#	And   User Accept cookies
#	And   User click on Create Project
#	When  User go to Project title page
#	And   User enter Other languages
#	And   User can create project successfully
#	Then  User should verify project title

#	# TCM-2204 : Verify applied coupon code can be removed
#Scenario: Verify applied coupon code can be removed
#   Given User can switch to Project Owner
#	And   User click on Create Project
#	And   User reaches to promotion code step
#	When  User enter promotion code "KOLAB100"
#	And   User Click on Apply Button
#	And   User can click on remove coupon
#	Then  User should verify coupon remove

	# TCM-2355 : Verify the error message should display when project visibility is not selected
Scenario: Verify the error message should display when project visibility is not selected
	Given User can switch to Project Owner
	And   User Accept cookies
	And   User click on Create Project
	When  User click on Next
	Then  User should verify "Please select at least one option." error message

	# TCM-2360 : Verify error message should display when less than 10 characters are entered in 'Project title'
Scenario: Verify error message should display when less than 10 characters are entered in 'Project title'
   Given User can switch to Project Owner
   And   User Accept cookies
   And   User click on Create Project
   When  User go to Project title page
   And   User enter "Failed" as project title
   And   User click on Next
   Then  User should verify Please enter at least 10 characters error in title field

   # TCM-2361 : Verify maximum 100 characters are allowed under 'Project title'
Scenario: Verify maximum 100 characters are allowed under 'Project title'
   Given User can switch to Project Owner
   And   User Accept cookies
   And   User click on Create Project
   When  User go to Project title page
   And   User enter "asdfghjklaasdfghjklaasdfghjklaasdfghjklaasdfghjklaasdfghjklaasdfghjklaasdfghjklaasdfghjklaasdfghjkla" as project title
   Then  User should see remaining characters should show as '0'

   # TCM-2441 : Verify promotion code text area should be visible only once promotion code checkbox is selected
Scenario: Verify promotion code text area should be visible only once promotion code checkbox is selected
	Given User can switch to Project Owner
	And   User click on Create Project
	And   User reaches to promotion code step
	And   User should not see promotion code text area
	When  User selects promo code check box
	Then  User should see promotion code text area to enter promo code

	# TCM-2444 : Verify promotion code check box is added on create project page
Scenario: Verify promotion code check box is added on create project page
	Given User can switch to Project Owner
	And   User click on Create Project
	And   User reaches to promotion code step
	When  User  navigate to promotion code step in CP form
	Then  User should see promo code check box is displayed

	# TCM-3207 : Verify project description should contain minimum 100 characters
Scenario: Verify project description should contain minimum 100 characters
	Given User can switch to Project Owner
	And   User click on Create Project
	And   User reaches to Project description step
	When  User enter less than 100 characters in project description field
	Then user should see validation message reflects as "Please enter at least 100 characters."

	# TCM-3208 : Subject area expertise should be mandatory field
Scenario: Subject area expertise should be mandatory field
	Given User can switch to Project Owner
	And   User click on Create Project
	And   User reaches to subject area expertise step
	When  User clicks on next step button without selecting
	Then  User should see subject area validation message reflects as "Please add at least one subject matter expertise."

	# TCM-3220 : 'By when do you need to hire a freelancer?' question is mandatory
Scenario: ''By when do you need to hire a freelancer?' question is mandatory
	Given User can switch to Project Owner
	And   User click on Create Project
	And   User reaches By when do you need to hire a freelancer? step
	When  User clicks post project button without selecting
	Then  User should verify validation message reflects as "Please select at least one option."

	# TCM-3248 : When user is loggedin and click on continuous previous project option , then system error message should not reflect
Scenario: When user is loggedin and click on continuous previous project option , then system error message should not reflect
	Given User can switch to Project Owner
	And   User navigate to new CP form url /create-project
	And   User Accept cookies
	And   User see two options display as 'start new project'and 'continue previous project' on modal
	When  User clicks on 'continue previous project' option
	Then  User should not see system error message alert and user should be able to continue previous project

	# TCM-3282 : No text box/text area should accept script tags
#Scenario Outline: No text box/text area should accept script tags
#    Given User can switch to Project Owner
#	And   User Accept cookies
#	And   User click on Create Project
#	When  User go to Project title page
#	When  User enter "i know 3<5 but 7 > 6 <a href="https://staging.kolabtree.com" target="_blank:">test for a tag</a> <b>test for b tag</b>" as project title
#	Then  User should see on focus out of text area, field gets blanked and no script tag should get injected
#	And   User go to description page
#	And   User enter "My name is khan  <script>alert("Hello XSS")</script> I like coding "><svg/onload=alert(document.cookie) i would like to submit proposal <br>UserId:<br><input type="text" value=""><br>Password:<br><input type="text" value=""><br><br><input type="submit" value="Submit"> With proposed fee of 500$ "><iframe src="https:%2f%2fwww.anonymous global.org%2fimages %2fcells %2fAnonymous Andorra.jpg"><%2fiframe><" but i have few question before submitting my proposal </input><a href ="https://www.flipkart.com">Click</a><input value="" I like kolabtree application." as project description

#	Examples:
#
#	| Text                                                                                                                   |
#	| i know 3<5 but 7 > 6 <a href="https://staging.kolabtree.com" target="_blank:">test for a tag</a> <b>test for b tag</b> |
#	| My name is khan  <script>alert("Hello XSS")</script> I like coding "><svg/onload=alert(document.cookie) i would like to submit proposal <br>UserId:<br><input type="text" value=""><br>Password:<br><input type="text" value=""><br><br><input type="submit" value="Submit"> With proposed fee of 500$ "><iframe src="https:%2f%2fwww.anonymous global.org%2fimages %2fcells %2fAnonymous Andorra.jpg"><%2fiframe><" but i have few question before submitting my proposal </input><a href ="https://www.flipkart.com">Click</a><input value="" I like kolabtree application. |

	# TCM-3219 : Service Category is mandatory field
Scenario: Service Category is mandatory field
	Given User can switch to Project Owner
	And   User click on Create Project
	And   User reaches service catagory step
	When  User clicks post project button without selecting One Task
	Then  User should verify Please select at least on task

