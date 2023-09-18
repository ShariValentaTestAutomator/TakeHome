using AventStack.ExtentReports.Gherkin.Model;
using CrossPlatformEATest.Pages;
using EAAutoFramework.Base;
using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using EAEmployeeTest.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.Steps
{
    [Binding]
    internal class HomePageSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        public HomePageSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        public void NaviateSite()
        {
            _parallelConfig.Driver.Navigate().GoToUrl(Settings.AUT);
        }

        [When(@"I navigate to Home page")]
        public void GivenIHaveNavigatedToHomePage()
        {
            NaviateSite();
            _parallelConfig.CurrentPage = new HomePage(_parallelConfig);
        }

        [Then(@"I click (.*) button")]
        public void ThenIClickButton(string button)
        {
            if (button == "Search")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickSearchButton();
            else if (button == "CheckIn")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickCheckInButton();
            else if (button == "AdultsPlus")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickAdultsPlusButton();
        }

        [Then(@"I click (.*) dropdown")]
        public void ThenIClickDropDown(string button)
        {
            if (button == "Guests")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickGuestsDropdown();
        }

        [Then(@"I clear (.*) field text")]
        public void ThenIClearFieldText(string text)
        {
            if (text == "Location")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<SearchResultsPage>().ClearLocationField();           
        }
       
        [Then(@"I should see (.*) value")]
        public void ThenIShouldSeeValue(string fieldValue)
        {
            if (fieldValue == "WhereDoYouWantToGo")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().CheckIfWhereWantToGoTextDisplays();
        }

        [Then(@"I should see (.*) text")]
        public void ThenIShouldSeeText(string text)
        {
            if (text == "Campgrounds")
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<SearchResultsPage>().CheckIfCampgroundsTextDisplays();
            else if (text == "TwoAdults")
                    _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().CheckTwoAdultsTextDisplays();
        }

        [Then(@"I should see this month text on left calendar")]
        public void IShouldSeeThisMonthTextOnLeftCalendar()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().CheckIfThisMonthOnLeftCalendarDisplays();
        }

        [Then(@"I select the following for Check In field: 1 week from current date")]
        public void ThenISelectTheFollowingForCheckInField1WeekFromCurrentDate()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().SelectCheckInDate();
        }

        [Then(@"I enter Location value")]
        public void ThenIEnterLocationValue(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().EnterLocationValue(data.Location);
        }
    }
}
