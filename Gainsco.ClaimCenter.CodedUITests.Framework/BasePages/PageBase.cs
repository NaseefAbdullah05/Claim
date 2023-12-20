using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using Gainsco.ClaimCenter.CodedUITests.Framework.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using Gainsco.CodedUITests.Common.Logging;

namespace Gainsco.ClaimCenter.CodedUITests.Framework.BasePages
{
    public abstract class PageBase
    {
        private GainscoConnectSeleniumHelper _seleniumHelper;
        private ISerilogLogger _serilogLogger;

        protected ISerilogLogger SerilogLogger
        {
            get
            {
                if (_serilogLogger == null)
                {
                    _serilogLogger = new SerilogLogger<PageBase>();
                }

                return _serilogLogger;
            }
            set
            {
                _serilogLogger = value;
            }
        }

        protected GainscoConnectSeleniumHelper SeleniumHelper
        {
            get
            {
                if (_seleniumHelper == null)
                {
                    _seleniumHelper = new GainscoConnectSeleniumHelper();
                }
                return _seleniumHelper;
            }
        }

        public IWebDriver WebDriver { get; set; }
        //public ILoggingService Log { get; set; }

        protected PageBase() { }
        public PageBase(IWebDriver webDriver)
        {
            // ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Logging"];
            this.WebDriver = webDriver;
            //var logging = new LoggingService();

            //logging.ConfigureWithFile("G500_SmokeTests", false);
            ////logging.ConfigureWithFile("G500_SmokeTests", false,
            ////    new CustomFileLogConfiguration { LogFileFolder = @"C:\SeleniumTestingLogs" });
            //logging.ConfigureWithDb("G500_SmokeTests", settings.ConnectionString, false);
            //Log = logging;


            PageFactory.InitElements(WebDriver, this);
        }

        public string BaseAddress
        {
            get { return ConfigurationManager.AppSettings["BaseAddress"]; }
        }

        public abstract void GoTo();

        public abstract bool IsAt();

        //public void GoToHomePage()
        //{
        //    string url = BaseAddress;
        //    WebDriver.Navigate().GoToUrl(url);
        //}

        public bool IsAtHomePage()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[id$=btnLogin]")));

            return true;
        }

        public virtual void CloseBrowser()
        {
            if (WebDriver is InternetExplorerDriver || WebDriver is ChromeDriver || WebDriver is RemoteWebDriver)
            {
                WebDriver.Close();
                WebDriver.Quit();
            }

            if (WebDriver is FirefoxDriver)
            {
                try
                {
                    IJavaScriptExecutor js = WebDriver as IJavaScriptExecutor;
                    WebDriver.Close();
                    WebDriver.Quit();
                }
                catch
                { }
            }
        }

        public virtual void SendSauceLabsTestResults(ScenarioContext scenarioContext)
        {
            bool passed = scenarioContext.TestError == null;
            ((IJavaScriptExecutor)WebDriver).ExecuteScript("sauce:job-result=" + (passed ? "passed" : "failed"));
            //((IJavaScriptExecutor)WebDriver).ExecuteScript("sauce:job-name=" + scenarioContext.ScenarioInfo.Title);
        }

        public virtual void SetupSauceLabsTestName(ScenarioContext scenarioContext)
        {
            ((IJavaScriptExecutor)WebDriver).ExecuteScript("sauce:job-name=" + scenarioContext.ScenarioInfo.Title);
        }

        public virtual void AnnotateSauceLabsTestResults(string text)
        {
            if (ConfigurationData.IsWebDriverUsingSauceLabs)
            {
                ((IJavaScriptExecutor)WebDriver).ExecuteScript("sauce:context=" + text);
            }
        }
    }
}
