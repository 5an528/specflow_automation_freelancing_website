Feature: CreateAccount

Background: User can go to create account page
   Given User will go to Kolabtree Website
   When  User click on Login

   # TCM-1063 : Entered phone number saved on account creation
Scenario: Entered phone number saved on account creation
   Given i am on create account popup
   And   User Accept cookies
   And   i create an account
   Then  I should see on account setting page and dashboard page entered phone number is saved

   # TCM-1064 : Correct Phone number is required for account creation
Scenario Outline: Correct Phone number is required for account creation
   Given i am on create account popup
   And   User Accept cookies
   When  i enter "<PhoneNumber>" in phone number text area
   Then  I should see correct validation message "Please enter a valid contact number." except '1234asfasfa'

   Examples:
   | PhoneNumber |
   | asdfgha     |
   | 123asdf     |
   |   _         |
   | 1234asfasfa |

	# TCM-1172 : First name field is mandatory for new account creation
Scenario: First name field is mandatory for new account creation
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal except First Name
   And  I keep FirstName field as blank
   Then I should see first name validation message reflects as "What is your first name?"
   And  I should see 'Create secure account' is not created

   # TCM-1173 : Last name field is mandatory for new account creation
Scenario: Last name field is mandatory for new account creation
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal except Last Name
   And  I keep LastName field as blank
   Then I should see last name validation message reflects as "What is your last name?"
   And  I should see 'Create secure account' is not created

	# TCM-1174 : Password field is mandatory for new account creation
Scenario: Password field is mandatory for new account creation
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal
   And  I keep password field as blank
   Then I should see password validation message reflects as "Please enter a secure password. You’ll need it to log in to your account."
   And  I should see 'Create secure account' is not created

   # TCM-1175 : Valid email address should be entered to create account
Scenario: Valid email address should be entered to create account
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal except Email
   And  I enter email id as "abc@"
   And  I focus out from input field
   Then I should see email validation message reflects as "Please enter a valid email address."
   And  I should see 'Create secure account' is not created

    # TCM-1176 : Password must be at least 6 characters and contain at least one character and digit
Scenario Outline: Password must be at least 6 characters and contain at least one character and digit
   Given i am on create account popup
   And  User Accept cookies
   When I enter all mandatory fields on modal
   And  i enter "<Password>" in Password text area
   And  I focus out from input field
   Then I should see password validation message reflects as "Password must have at least 6 characters and contain at least one number and one upper case character" except 'Test123'
   And  I should see 'Create secure account' is not created
   Examples:
   | Password    |
   | 123         |
   | TestAuto    |
   | test123     |
   | Test123     |

    # TCM-1177 : New account does not become created when entered email is already used by a different account
Scenario: New account does not become created when entered email is already used by a different account
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal except Email
   And  I enter email id as "Yourmail@gmail.com"
   And  I focus out from input field
   Then I should see email validation message reflects as "This email is already in use. Try logging in instead."
   And  I should see 'Create secure account' is not created

   # TCM-1179 : Spaces should be allowed for hiring account creation
Scenario: Spaces should be allowed for hiring account creation
   Given i am on create account popup
   And   User Accept cookies
   When  I enter account information with spaces in first and last name fields
   And   I press Create account button
   And   I press Create project button
   Then  Hiring account should be created with spaces in first and last name

    # TCM-1181 : Unicode should be allowed for hiring account creation
Scenario: Unicode should be allowed for hiring account creation
   Given i am on create account popup
   And   User Accept cookies
   When  I enter account information with unicode symbols in First Name as "Ĉser-Nãme" and Last Name field as "lãst Ĉame"
   And   I press Create account button
   And   I press Create project button
   Then  Hiring account created with unicode symbols in First Name, Last Name fields

   # TCM-1182 : Create account with allowed special symbols in First name field
Scenario: Create account with allowed special symbols in First name field
   Given i am on create account popup
   And   User Accept cookies
   When  I enter firstname as ".,-'"
   And   I enter all mandatory fields on modal except First Name
   And   I press Create account button
   And   I press Create project button
   Then  Account should be created with allowed special symbols in name

    # TCM-1183 : Create account with allowed special symbols in 'Last name' field
Scenario: Create account with allowed special symbols in Last name field
   Given i am on create account popup
   And   User Accept cookies
   When  I enter lasttname as ".,-'"
   And   I enter all mandatory fields on modal except Last Name
   And   I press Create account button
   And   I press Create project button
   Then  Account should be created with allowed special symbols in name

   # TCM-1184 : Email field is mandatory for new account creation
Scenario: Email field is mandatory for new account creation
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal except Email
   And  I enter email id as ""
   And  I focus out from input field
   Then I should see email validation message reflects as "Please enter a valid email address."
   And  I should see 'Create secure account' is not created

   # TCM-1185 : Empty account creation is prohibited
Scenario: Empty account creation is prohibited
   Given i am on create account popup
   And   User Accept cookies
   When  user does not enter any valid value under all mandatory fields on form
   Then  I should see 'Create secure account' is not created

   # TCM-1186 : Special symbols are forbidden in 'Last name' field on Create Account form
Scenario Outline: Special symbols are forbidden in 'Last name' field on Create Account form
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal except Last Name
   And  I enter lasttname as "<Values>"
   And  I focus out from input field
   Then I should see last name validation message reflects as "Last name is invalid"
   And  I should see 'Create secure account' is not created

   Examples:

   | Values |
   | <      |
   | >      |
   | :      |
   | ""     |
   | /      |
   | \\     |
   |  ?     |

   # TCM-1187 : Special symbols are forbidden in 'First name' field on Create Account form
Scenario Outline: Special symbols are forbidden in 'First name' field on Create Account form
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal except First Name
   And  I enter firstname as "<Values>"
   And  I focus out from input field
   Then I should see first name validation message reflects as "First name is invalid"
   And  I should see 'Create secure account' is not created

   Examples:

   | Values |
   | <      |
   | >      |
   | :      |
   | ""     |
   | /      |
   | \\     |
   |  ?     |

   # TCM-1193 : Verify Warning message reflects when an entered email id is other than business email address
Scenario: Verify Warning message reflects when an entered email id is other than business email address
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal except Email
   And  I enter email id as "User@mailinator.com"
   And  I focus out from input field
   Then I should see business email validation message reflects as "We noticed you're using mailinator.com address. Would you like to use your work email instead?"
   And  I should see 'Create secure account' is not created

   # TCM-1197 : 'Terms & conditions' and 'privacy policy' link redirects user to respective page
Scenario: ''Terms & conditions' and 'privacy policy' link redirects user to respective page
   Given i am on create account popup
   And   User Accept cookies
   And   "Terms and Conditions" and "Privacy Policy" link is present on create account modal(in First checkbox) and in footer section
   When  user click on any link of 'Terms & condition' or 'privacy policy'
   Then  user should redirect to the "/user-agreement" or "/privacy-policy" Page respectively.


   # TCM-1206 : Validation message is shown on attempt to create a new account with email that was deactivated
Scenario: Validation message is shown on attempt to create a new account with email that was deactivated
   Given i am on create account popup
   And   User Accept cookies
   When I enter all mandatory fields on modal except Email
   And  I enter email id as "TestAutomationDeactivTedUser@mailinator.com"
   And  I focus out from input field
   Then I should see email validation message reflects as "Account with supplied email address already exists and is de-activated, please email us at contact@kolabtree.com for re-activation."
   And  I should see 'Create secure account' is not created