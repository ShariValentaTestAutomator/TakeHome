using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using EAAutoFramework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace EAAutoFramework.Base
{
    public abstract class BasePage : Base
    {
        public BasePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public IWebElement WaitUntillElementVisable(By elementLocator, int timeout = 30)
        {
            try
            {
                var wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(OpenQA.Selenium.Support.UI.ExpectedConditions.ElementIsVisible(elementLocator));
            }
            catch (System.Exception)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }

        public IWebElement WaitUntillElementClickable(By elementLocator, int timeout = 30)
        {
            try
            {
                var wait = new WebDriverWait(_parallelConfig.Driver, TimeSpan.FromSeconds(timeout));
                var element = wait.Until(OpenQA.Selenium.Support.UI.ExpectedConditions.ElementToBeClickable(elementLocator));
                Thread.Sleep(1000);
                return element;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
    }
}

