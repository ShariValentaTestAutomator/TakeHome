Test Cases:

Check if “Where do you want to go?” text displays in Location field after clearing Location field text on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I clear Location field text
Then I should see the following value:
Where do you want to go?

Check if Location field not required when searching on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I leave Location field value null
And I select the following for Check In field: 1 week from current date
And I select the following for Check Out field: 12 days from current date
And I select the following value for Guests field: 2 Adults 
And I click Search button
Then I should see no validation error for Location field
And I should see the following text on the Search Results page:
Sorted by

Check if current City and State displays for Location field on Search Results page when leaving Location field null and clicking Search button on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I leave Location field value null
And I select the following for Check In field: 1 week from current date
And I select the following for Check Out field: 12 days from current date
And I select the following value for Guests field: 2 Adults 
And I click Search button
Then I should see my current City and State separated by a comma in the Location field

Check if Check in and Check Out fields not required when searching on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I leave Location field value null
And I leave Check In field null
And I leave Checkout field null
And I select the following value for Guests field: 2 Adults 
And I click Search button
Then I should see no validation error for Check In field
And I should see no validation error for Checkout field
And I should see the following text on the Search Results page:
Sorted by

 
Check if current and next month names display when clicking on Check In field on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I click on Check In field
And I should see following values for text:
Month name for current date
Month name for 30 days from current date

Check if current and next month names display when clicking on Check Out field on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I click on Check Out field
And I should see following values for text:
Month name for current date
Month name for 30 days from current date

Check if next month and month 60 days from now display when clicking on Check In field and clicking pagination forward arrow on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I click on Check In field
And I click pagination forward arrow
And I should see following values for text:
Month name for 30 days from current date
Month name for 60 days from current date

Check if next month and month 60 days from now display when clicking on Check Out field and clicking pagination forward arrow on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I click on Check Out field
And I click pagination forward arrow
And I should see following values for text:
Month name for 30 days from current date
Month name for 60 days from current date

Bug?: Shouldn’t it display month name for 30 days and 60 days prior to current date?
Check if current month and previous month display when clicking on Check In field and clicking pagination backward arrow on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I click on Check In field
And I click pagination backward arrow
And I should see following values for text:
Month name for current date
Month name for 30 days prior to current date
Bug?: Shouldn’t it display month name for 30 days and 60 days prior to current date?
Check if current month and previous month display when clicking on Check Out field and clicking pagination backward arrow on Home page as unlogged in user

Given I am not logged on to Campspot
When I navigate to Home page
And I click on Check Out field
And I click on pagination backward arrow
And I should see following values for text:
Month name for current date
Month name for 30 days previous to current date

Check if dates from Check In and Check Out fields on Home page are displayed in Dates field on Search Results page as unlogged in user
Given I am not logged on to Campspot
When I navigate to Home page
And I click on Check Out field
And I select the following for Check In field: 1 week from current date
And I select the following for Check Out field: 12 days from current date
And I select the following value for Guests field: 2 Adults 
And I click Search button
Then I should see Dates field contains the following values:
1 week from current date
12 days from current date

Check if “2 Adults” is default for Guests field on Home page as unlogged in user
Given I am not logged on to Campspot
When I navigate to Home page
And I refresh page
Then I should see the following value in Guests field:
2 Adults


Check if Guests can be added to Home page query for unlogged user
Given I am not logged on to Campspot
When I navigate to Home page
And I click Guests field
And I click plus button for Adults
And I click plus button for Children 
And I click plus button for Pets
And I click Tab button on keyboard
Then I should see the following value in Guests field:
3 Adults, 1 Child, 1 Pet


 
Check if Guests can be removed from Home page query for unlogged user
Given I am not logged on to Campspot
When I navigate to Home page
And I click Guests field
And I click plus button for Adults
And I click plus button for Children 
And I click plus button for Pets
And I click Tab button on keyboard
Then I should see the following value in Guests field:
3 Adults, 1 Child, 1 Pet
And I click Guests field
And I click minus button for Adults
And I click minus button for Children
And I click minus button for Pets
And I click Tab button on keyboard
Then I should see the following value in Guests field:
2 Adults

Check if clicking on Search button on Home page navigates to Search Results page as unlogged in user
Given I am not logged on to Campspot
When I navigate to Home page
And I click Guests field
And I click Search button
And I should see the following text on the Search Results page:
Sorted by

Check if expected Location State displays on Search Results page 
Given I am not logged on to Campspot
When I navigate to Home page
And I enter the following value for Location field:
Parkville, Maryland
And I click Search button
Then I should see the following value displays on the Search Results page:
MD

Check if expected Location State not display on Search Results page 
Given I am not logged on to Campspot
When I navigate to Home page
And I enter the following value for Location field:
Parkville, Maryland
And I click Search button
Then I should see the following value does not display on the Search Results page:
CO

NOTE: Results redirect to home page so can’t check other parameters (i.e. Dates field)

////////////////////////////////////////////////////////////////////////////////////// 

TEST STRATEGY

Run automation on what's automated on Chrome and Firefox (until framework fixed to work with Angular)
Manually test what's not automated
Manually test Edge (until framework fixed to work with Edge)
Manually test on iPhone/iPad/Android Phone/Android tablet emulators (until mobile testing added to framework)

////////////////////////////////////////////////////////////////////////////////////// 

Things you need to know to run automation

•	Where automation lives: https://github.com/ShariValentaTestAutomator/CSBook

•	Things you need:

	o	Microsoft Visual Studio Community 2022 Version Version 17.7.0

	o	.NET Version 4.8.0484

	o	Java jre1.8.0_333

	o	SpecFlow for Visual Studio 2022 2022.1.75.53377 (Add this in Manage Extensions next to Help drop down in Visual Studio).

	o	Selenium Standalone server: selenium-server-4.9.1.jar Make a folder in C:/Users/<username> called AutomationTools and put it there. Download here: https://www.selenium.dev/downloads/ It’s called Selenium WebDriver Grid	

	o	Chromedriver.exe (for the version of Chrome you’re on) (I put in C:/Users/<username>/AutomationTools) Scroll down to browsers on https://www.selenium.dev/downloads/

	o	msedgedriver.exe (for the version on Edge you’re on) (I put in C:/Users/<username>/AutomationTools) Scroll down to browsers on https://www.selenium.dev/downloads/

	o	Create empty folders to store results: C:\extentreport2\SeleniumWithSpecflow\SpecflowParallelTest. This will be mapped in the code in file called HookInitialize.cs:
		var htmlReporter = new ExtentHtmlReporter(@"C:\extentreport2\SeleniumWithSpecflow\SpecflowParallelTest\ExtentReport.html");

	o	Environment Variables:
		Type env in windows search bar and click Edit System Environment Variables
		Click Environment Variables button
		Create System Variables for the following:
			Variable: JAVA_HOME, Value: %JAVA_HOME%\bin
			Variable: Path, Values:
				C:\Program Files (x86)\Java\jre1.8.0_271\bin
				C:\Program Files\dotnet\
				C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe
				C:\Users\svalenta\msedgedriver.exe
				C:\workspace\hemasource-automation-framework\sselenium-server-4.9.1.jar
				C:\Program Files (x86)\dotnet\

	o	Git: https://git-scm.com/downloads

	o	Git identity:
		In command prompt:
		git config --global user.name "Your Name"
		git config --global user.email "youremail@yourdomain.com"

	o   SSH Key in Gitlab: 
		In command prompt:
			Navigate to :\Users\User Name
			Enter: ssh-keygen
			Click enter again (if you want to bypass creating a password)
			Copy in notepad your public key (file will be hidden in \Users\User Name)
			Paste public key here: https://gitlab.hemasource.com/-/profile/keys

	o   Clone repo:
		Make a folder called workspace on your C drive
		Navigate to C:\workspace in Gitbash (you can do this by going to C:\workspace\, right click the hemasource-test-automation folder and select GitBash here).
		Enter: git clone git@gitlab.hemasource.com:qa/hemasource-test-automation.git
		Ignore the following message: The authenticity of host 'github.com (IP ADDRESS)' can't be established.
		Enter Yes for "Are you sure you want to continue connecting"

	o   Open project in Visual Studio: File menu, Open, Project/Solution, navigate to C:\workspace\CSBookProject, click EADotNetCoreProject.sln, click Open button

•	Set up to run tests:

	o   Open command prompt, navigate to C:/Users/<username>/AutomationTools, Enter: java -jar selenium-server-4.9.1.jar standalone, copy the IP Address from the output and put it in a file called TestInitializeHook.cs (you have to leave /wd/hub after the address):
	_parallelConfig.Driver = new RemoteWebDriver(new Uri("http://<ip address>/wd/hub"), driverOptions.ToCapabilities()); 
	
	o   Uncomment appsettings.json uncomment out browser and environment (for now – TODO: Make separate json files for each environment or do this in a better way)(Edge won’t close windows). (To do: User secrets needs to be coded.

•	Run in Visual Studio:

	o	 Pick a simple test to run (such as anything in the ERP_NaviationFeature). Open Test Explorer in Visual Studio, by clicking View. Right click on Test (in Test Explorer) and click Run. TODO: Make it so run in headless mode). Results are in C:\extentreport2\SeleniumWithSpecflow\SpecflowParallelTest
	
•	Run in Command line:

	o	Can run by attribute in command line (a separate command prompt window): (I navigate to C:/workspace/hemasource-test-automation)(make sure you save all and build): 
	o	dotnet test (to run all). Be careful not to run tests on Prod that will write to Prod - it will say if it's OK in the attribute name: @ symbol in the feature files.
	o	dotnet test --filter Category=smoke
	o	dotnet test --filter Category=smoke 
	o	There’s more attributes and some tests we don’t want to run because are in progress or may not be good candidates for Prod 
	Can run by environment and attribute in command line:
	dotnet test --filter Category=smoke --environment "staging"