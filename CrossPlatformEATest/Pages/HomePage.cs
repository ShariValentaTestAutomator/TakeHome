using System;
using System.Collections.Generic;
using System.Threading;
using CrossPlatformEATest.Pages;
using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace EAEmployeeTest.Pages
{
    internal class HomePage : BasePage
    {
        public HomePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        IWebElement btnCheckIn => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Check In')]");

        IWebElement btnSearch => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Search')]");

        IWebElement txtLeftCalendarMonth => _parallelConfig.Driver.FindByXpath("//*[contains(@class,'mod-show-2-months')]/section[2]/div[2]/h3[1]");

        IWebElement txtTwoAdultsGuests => _parallelConfig.Driver.FindByXpath("//*[@class='guests-picker-input-text app-guest-categories-label']");

        IWebElement drpdnGuests => _parallelConfig.Driver.FindByXpath("//*[@class='guests-picker-input']");

        IWebElement btnAdultsPlus => _parallelConfig.Driver.FindByXpath("//*[@class='guests-picker-input']");

        IWebElement frameGuests => _parallelConfig.Driver.FindById("__JSBridgeIframe_1.0__");

        IWebElement drpdnLocationOptionOne => _parallelConfig.Driver.FindById("//*[contains(@class,'location-search-results-location-0')]");

        By byFldLocation = By.XPath("//*[@name='search-location']");

        IWebElement fldLocation => (IWebElement)byFldLocation;        

        public static string currentMonth = DateTime.Now.ToString("MM");

        public HomePage CheckIfWhereWantToGoTextDisplays()
        {
            var expectedLocationValue = "Where do you want to go?";
            var actualLocationValue = fldLocation.GetAttribute("value").ToString();
            //var actualLocationValue = fldLocation.Text.ToString();
            if (actualLocationValue != expectedLocationValue)
            {
                Assert.Fail($"Location value was actualLocationValue but was supposed to be expectedLocationValue");
            }

            return new HomePage(_parallelConfig);
        }

        public HomePage SelectCheckInDate()
        {
            btnCheckIn.Click();
            // TODO: Interact with calendar

            return new HomePage(_parallelConfig);
        }

        public SearchResultsPage ClickSearchButton()
        {
            btnSearch.Click();

            return new SearchResultsPage(_parallelConfig);
        }

        public HomePage ClickCheckInButton()
        {
            btnCheckIn.Click();

            return new HomePage(_parallelConfig);
        }

        public HomePage ClickAdultsPlusButton()
        {
            _parallelConfig.Driver.SwitchTo().Frame(frameGuests);
            Thread.Sleep(1500);
            btnAdultsPlus.Click();

            _parallelConfig.Driver.SwitchTo().DefaultContent();

            return new HomePage(_parallelConfig);
        }

        public HomePage ClickGuestsDropdown()
        {
            drpdnGuests.Click();

            return new HomePage(_parallelConfig);
        }

        public HomePage CheckTwoAdultsTextDisplays()
        {
            _parallelConfig.Driver.Navigate().Refresh();

            var actualText = "2 Adults";
            var expectedText = txtTwoAdultsGuests.Text.ToString();

            if (actualText != expectedText)
            {
                Assert.Fail($"Guests field was expected to be " + expectedText + " but was " + actualText);
            }

            return new HomePage(_parallelConfig);
        }

        public HomePage CheckIfThisMonthOnLeftCalendarDisplays()
        {
            String leftMonthValue = txtLeftCalendarMonth.GetAttribute("value");

            if (leftMonthValue != currentMonth)
            {
                Assert.Fail($"Left Calendar month was supposed to be currentMonth but was leftMonthValue");
            }

            return new HomePage(_parallelConfig);
        }

        public HomePage EnterLocationValue(string Location)
        {
            //_parallelConfig.Driver.FindElement(By.XPath("//*[@name='search-location']")).SendKeys(Location);
            //String option = Location;

            //IWebElement customOption = _parallelConfig.Driver.FindElement(By.XPath("//*[@name='search-location']/a[contains(text(), '" + option + "')]"));

            //customOption.Click();

            //fldLocation.Click();
            //Actions action = new Actions(_parallelConfig.Driver);
            //do
            //{
            //    action.SendKeys(Keys.ArrowDown).Perform();
            //} while (!fldLocation.Displayed);
            fldLocation.Click();

            fldLocation.SendKeys(Location);
            //drpdnLocationOptionOne.SendKeys(Keys.Control + Location); //it puts in fldLocation 

            //fldLocation.SendKeys("MD", Keys.Down, Keys.Enter);

            //fldLocation.SelectDropDownList(fldLocation, Location);
            //fldLocation.SelectDropDownList(drpdnLocationOptionOne, Location);
            fldLocation.SendKeys(Keys.Down);
            fldLocation.SendKeys(Keys.Return);

            return new HomePage(_parallelConfig);
        }
    }
}
