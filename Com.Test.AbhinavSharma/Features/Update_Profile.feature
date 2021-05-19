Feature: Update_Profile
	Update personal information such as first name in My Account section

#Credentials will be picked from appSettings when "xxx"
Background: common login steps
	Given mark has a valid account with "xxx"
	And performs login with user-name as "xxx" and password as "xxx"

#A random First Name will be used from Faker() API call when xxx
@sanity
Scenario: Update users first name in the My Account section with any random name
	Given mark wants to update his first name
	When clicks on My personal information 
	And updates First name as "xxx"
	Then mark should see updated first name in the profile section

@sanity
Scenario: Update users first name in the My Account section with a specific name
	Given mark wants to update his first name
	When clicks on My personal information 
	And updates First name as "TestFirstName"
	Then mark should see updated first name in the profile section