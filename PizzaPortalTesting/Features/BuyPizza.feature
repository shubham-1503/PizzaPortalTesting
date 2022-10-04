Feature: BuyPizza

A short summary of the feature

@tag1
Scenario: Buying one pizza,Updating its quantity, adding another pizza and redirecting to checkout page 
	Given I have navigated to Website
	When I click on Buy Now Button  
	Then I am redirected to cart page with that specific pizza
	When I click on continue shopping
	Then Home page gets opened (for extra pizza)
	When I click on Buy Now Button for different pizza
	Then I am redirected to cart page with that new pizza added
	When I click on Checkout 
	Then Checkout page gets opened
