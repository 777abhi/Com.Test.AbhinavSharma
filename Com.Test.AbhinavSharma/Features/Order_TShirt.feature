Feature: Order_TShirt
	Order T Shirt from website

Background: common login steps
	Given mark has a valid account with "xxx"
	And performs login with user-name as "xxx" and password as "xxx"

@sanity
Scenario: Order T-Shirt and verify in order history
	Given mark wants order a T-Shirt for his wife
	When mark selects & completes the purchase
	Then mark should see purchased T-Shirt in order history