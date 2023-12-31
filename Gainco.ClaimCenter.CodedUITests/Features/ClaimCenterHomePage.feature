﻿@ClaimCenterHomePage
Feature: Claim Center Home Page
	As a Gainsco Agent,
	I want to be able to view claims associated to Gainsco insured accounts to be able to manage the claims process

@AllScenarios
Scenario: Claim Center Home Page
Given I have access to home page
And I have entered a valid username
And I have entered a valid password 
When I click on login button
Then I will be redirected to desktop activities screen

@AllScenarios
Scenario: Summary screen redirection
Given I am on the desktop activities screen
When I click on the claim tab
Then I am redirected to claims summary screen

@AllScenarios
Scenario: New claim menu display under claims tab
Given I am on the desktop activities screen
When I click on claim tab down arrow
Then claim menu should be visible

@AllScenarios
Scenario: Find policy screen redirection
Given I am on the desktop activities screen
When I click on claim tab down arrow
And I click new claim from menu
Then I am redirected to find policy screen

@AllScenarios
Scenario: Search button enabled on find policy screen
Given I am on the find policy screen
And I enter policy number in the policy number text box
When I click on the loss date
Then search button is enabled

@AllScenarios
Scenario: Policy number search results will display
Given search button is enabled on find policy screen
When I click on search button
Then policy search results will display

@AllScenarios
Scenario: Time of loss error message will display
Given I am on the policy search results screen
When I click on next button
Then time of loss error message should display

@AllScenarios
Scenario: Address book search screen redirection
Given I am on the desktop activities screen
When I click on address book tab
Then I am redirected to address book search screen

@AllScenarios
Scenario:  Address book search results will display
Given I am on the search address book screen 
And I enter zipcode in the text box
When I click on search button in search address book screen
Then search results will display

@AllScenarios
Scenario: Group details screen page redirection
Given I am on the desktop activities screen
When I click on administration tab
Then I am redirected to group detail screen page

@AllScenarios
Scenario: Message queues screen redirection
Given I am on the group detail screen page
When I click on monitoring tab on the left hand side
Then  I am redirected to message queues screen 

@AllScenarios
Scenario: Basic information page redirection
Given search button is enabled on find policy screen
When I click on search button
Then policy search results will display
Given I select a time in time section
When I click on next button
Then I am redirected to basic information page

@AllScenarios
Scenario: Claim Information page redirection
Given search button is enabled on find policy screen
When I click on search button
Then policy search results will display
Given I select a time in time section
When I click on next button
Then I am redirected to basic information page
When I select name information
And I select relation information
And I select a Car
When I click on next button
Then I am redirected to claim information page

@AllScenarios
Scenario: Vehicle details page redirection
Given I am at claim information page
When I click on vehicle name button
Then I am reidrected to vehicle details page

@AllScenarios
Scenario: Driver details page redirection
Given I am at claim information page
When I click on vehicle name button
Then I am reidrected to vehicle details page
When I select operable option
And I click add driver button
Then I am redirected to driver details page

@AllScenarios
Scenario: Back to Claim information page
Given I am at driver details page
When I select a person
And relation to insured
When I click ok button
Then I am reidrected to vehicle details page
When I click ok button on vehicle details page
Then I am redirected to claim information page






