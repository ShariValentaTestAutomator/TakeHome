using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace EAAutoFramework.Base
{
    public class TestInitializeHook : Steps
    {
        private readonly ParallelConfig _parallelConfig;
        private readonly ScenarioContext _scenarioContext;

        public TestInitializeHook(ParallelConfig parallelConfig, ScenarioContext scenarioContext)
        {
            _parallelConfig = parallelConfig;
            _scenarioContext = scenarioContext;
        }

        public void InitializeSettings()
        {
            //Set all the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Set Log
            LogHelpers.CreateLogFile();

            //Open Browser
            OpenBrowser(GetBrowserOption(Settings.BrowserType));

            LogHelpers.Write("Initialized framework");

        }

        private void OpenBrowser(DriverOptions driverOptions)
        {
            switch (driverOptions)
            {
                //case InternetExplorerOptions internetExplorerOptions:
                //    // TODO: IE not working
                //    _parallelConfig.Driver = new InternetExplorerDriver();
                //    break;
                //case FirefoxOptions firefoxOptions:
                //    _parallelConfig.Driver = new FirefoxDriver();
                //    break;
                case ChromeOptions chromeOptions:
                    chromeOptions.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);
                    break;
                    //case EdgeOptions edgeOptions:
                    //    var msedgedriverDir = @"C:\Users\svalenta\";
                    //    var msedgedriverExe = @"msedgedriver.exe";
                    //    //var service = EdgeDriverService.CreateDefaultServiceFromOptions(msedgedriverDir, msedgedriverExe, edgeOptions);
                    //    _parallelConfig.Driver = new EdgeDriver(service);
                    //    break;
            }
            _parallelConfig.Driver = new RemoteWebDriver(new Uri("http://<ipaddress>/wd/hub"), driverOptions.ToCapabilities()); 
        }

        public virtual void NaviateSite()
        {
            //DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Opened the browser !!!");
        }

        public DriverOptions GetBrowserOption(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    return new InternetExplorerOptions();
                case BrowserType.FireFox:
                    return new FirefoxOptions();
                case BrowserType.Chrome:
                    return new ChromeOptions();
                //case BrowserType.Edge:
                //    return new EdgeOptions();
                default:
                    return new ChromeOptions();
            }
        }
    }
}

