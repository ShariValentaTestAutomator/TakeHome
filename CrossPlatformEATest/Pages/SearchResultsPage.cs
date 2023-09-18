using Dynamitey;
using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using EAEmployeeTest.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatformEATest.Pages
{
    internal class SearchResultsPage : BasePage
    {
        public SearchResultsPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        IWebElement txtCampGrounds => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Campgrounds')]");

        IWebElement fldLocation => _parallelConfig.Driver.FindByXpath("//*[@name='search-location']");

        IWebElement txtLocationPlaceHolder => _parallelConfig.Driver.FindById("placeholder");

        public HomePage CheckIfCampgroundsTextDisplays()
        {
            txtCampGrounds.AssertElementPresent();

            return new HomePage(_parallelConfig);
        }
       
        public HomePage ClearLocationField()
        {
            fldLocation.Clear();

            return new HomePage(_parallelConfig);
        }
    }
}

