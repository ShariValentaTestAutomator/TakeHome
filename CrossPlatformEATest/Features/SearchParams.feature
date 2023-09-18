Feature: SearchParams

Check if search parameter functionality works as expected

@Search
Scenario: Check if clicking on Search button on Home page navigates to Search Results page as unlogged in user
	When I navigate to Home page
	Then I click Search button
	Then I should see Campgrounds text

@Search
Scenario: Check if 2 Adults is default for Guests field on Home page as unlogged in user 
	When I navigate to Home page
	Then I should see TwoAdults text

# TESTS BELOW - IN PROGRESS: Update framework to work with Angular
@Search
Scenario: Check if Location field not required when searching on Home page as unlogged in user
	When I navigate to Home page
	Then I select the following for Check In field: 1 week from current date

@Search
Scenario: Check if current and next month names display when clicking on Check In field on Home page as unlogged in user
	When I navigate to Home page
	Then I click CheckIn button
	Then I should see this month text on left calendar 

@Search
Scenario: Check if expected Location State displays on Search Results page 
	When I navigate to Home page
	Then I enter Location value
	| Location            |
	| Parkville, Maryland |
	Then I click Search button

@Search
Scenario: Check if Guests can be added to Home page query for unlogged user
	When I navigate to Home page
	Then I click Guests dropdown
	Then I click AdultsPlus button

@Search
Scenario: Check if Where do you want to go text displays in Location field after clearing Location field text on Home page as unlogged in user
	When I navigate to Home page
	Then I clear location field text
	Then I should see WhereDoYouWantToGo value 

