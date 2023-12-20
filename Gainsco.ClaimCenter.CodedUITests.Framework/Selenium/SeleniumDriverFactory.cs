using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gainsco.Training.CodedUITests.Framework.EnumType;
using Gainsco.ClaimCenter.CodedUITests.Framework;

namespace Gainsco.Policy.CodedUITests.Framework.Selenium
{
    public class SeleniumDriverFactory
    {
        private SeleniumDriverType _SeleniumDriverType = default(SeleniumDriverType);

        public SeleniumDriverFactory(SeleniumDriverType SeleniumDriverType)
        {
            _SeleniumDriverType = SeleniumDriverType;
        }

        public IWebDriver GetDriver()
        {
            switch (_SeleniumDriverType)
            {
                case SeleniumDriverType.InternetExplorerDriver:
                    {
                        InternetExplorerOptions options = new InternetExplorerOptions();
                        options.IgnoreZoomLevel = true;
                        InternetExplorerDriver driver = new InternetExplorerDriver(options);
                        return driver;
                    }

                case SeleniumDriverType.InternetExplorer11Driver:
                    {
                        if (ConfigurationData.IsWebDriverUsingSauceLabs)
                        {
                            IWebDriver driver;
                            DesiredCapabilities desiredCapability = new DesiredCapabilities();
                            desiredCapability.SetCapability("browserName", "Internet Explorer");
                            desiredCapability.SetCapability("platform", "Windows 10");
                            desiredCapability.SetCapability("username", "jogainsco");
                            desiredCapability.SetCapability("accessKey", "b5734581-5cf8-4c57-8a2c-a27f2196f4ea");
                            desiredCapability.SetCapability("seleniumVersion", "3.5.0");
                            desiredCapability.SetCapability("iedriverVersion", "3.4.0");

                            desiredCapability.SetCapability("version", "11");

                            if (ConfigurationData.TunnelIdentifier.Equals("claimsuat"))

                            {
                                desiredCapability.SetCapability("tunnelIdentifier", "claimsuat");

                            }
                            else if (ConfigurationData.TunnelIdentifier.Equals("claimsprod"))
                            {
                                desiredCapability.SetCapability("tunnelIdentifier", "claimsprod");
                            }

                            //"commandTimeout": 300
                            //"idleTimeout": 90
                            desiredCapability.SetCapability("commandTimeout", "600");
                            desiredCapability.SetCapability("idleTimeout", "200");
                            desiredCapability.SetCapability("ignoreZoomSetting", true);
                            desiredCapability.SetCapability(CapabilityType.HasNativeEvents, false);
                            desiredCapability.SetCapability(CapabilityType.UnexpectedAlertBehavior, InternetExplorerUnexpectedAlertBehavior.Accept);
                            desiredCapability.SetCapability("ignoreProtectedModeSettings", true);
                            desiredCapability.SetCapability("enablePersistentHover", true);

                            driver = new RemoteWebDriver(new Uri("http://josephbaggett:b5734581-5cf8-4c57-8a2c-a27f2196f4ea@ondemand.us-west-1.saucelabs.com:80/wd/hub"), desiredCapability);
                            return driver;
                        }
                        else
                        {
                            InternetExplorerOptions options = new InternetExplorerOptions();
                            options.IgnoreZoomLevel = true;
                            options.EnableNativeEvents = false;
                            options.UnexpectedAlertBehavior = InternetExplorerUnexpectedAlertBehavior.Accept;
                            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                            options.EnablePersistentHover = true;
                            InternetExplorerDriver driver = new InternetExplorerDriver(options);
                            return driver;
                        }
                    }

                case SeleniumDriverType.ChromeDriver:
                    {
                        if (ConfigurationData.IsWebDriverUsingSauceLabs)
                        {
                            IWebDriver driver;
                            DesiredCapabilities desiredCapability = new DesiredCapabilities();
                            desiredCapability.SetCapability("browserName", "GoogleChrome");
                            desiredCapability.SetCapability("platform", "Windows 10");
                            desiredCapability.SetCapability("username", "jogainsco");
                            desiredCapability.SetCapability("accessKey", "b5734581-5cf8-4c57-8a2c-a27f2196f4ea");
                            desiredCapability.SetCapability("seleniumVersion", "3.5.0");
                            desiredCapability.SetCapability("chromedriverVersion", "");

                            desiredCapability.SetCapability("version", "120.0");
                            desiredCapability.SetCapability("screenResolution", "1280x1024");
                            desiredCapability.SetCapability("commandTimeout", "600");
                            desiredCapability.SetCapability("idleTimeout", "200");
                            desiredCapability.SetCapability("ignoreZoomSetting", true);
                            desiredCapability.SetCapability(CapabilityType.HasNativeEvents, false);
                            desiredCapability.SetCapability("ignoreProtectedModeSettings", true);
                            desiredCapability.SetCapability("enablePersistentHover", true);
                            if (ConfigurationData.TunnelIdentifier.Equals("claimsQA"))

                            {
                                desiredCapability.SetCapability("tunnelIdentifier", "claimsQA");

                            }
                            else if (ConfigurationData.TunnelIdentifier.Equals("claimsprod"))
                            {
                                desiredCapability.SetCapability("tunnelIdentifier", "claimsprod");
                            }

                            driver = new RemoteWebDriver(new Uri("http://jokurra:b5734581-5cf8-4c57-8a2c-a27f2196f4ea@ondemand.us-west-1.saucelabs.com:80/wd/hub"), desiredCapability);
                            return driver;
                        }
                        else
                        {
                            ChromeOptions options = new ChromeOptions();
                            options.LeaveBrowserRunning = false;
                            ChromeDriver driver = new ChromeDriver();
                            //return driver;
                            return driver;
                        }

                    }
                case SeleniumDriverType.FirefoxDriver:
                    {
                        if (ConfigurationData.IsWebDriverUsingSauceLabs)
                        {
                            IWebDriver driver;
                            DesiredCapabilities desiredCapability = new DesiredCapabilities();
                            desiredCapability.SetCapability("browserName", "Firefox");
                            desiredCapability.SetCapability("platform", "Windows 10");
                            desiredCapability.SetCapability("username", "jogainsco");
                            desiredCapability.SetCapability("accessKey", "b5734581-5cf8-4c57-8a2c-a27f2196f4ea");
                            desiredCapability.SetCapability("seleniumVersion", "3.5.0");
                            desiredCapability.SetCapability("firefoxdriverVersion", "");

                            desiredCapability.SetCapability("version", "61.0");

                            desiredCapability.SetCapability("commandTimeout", "600");
                            desiredCapability.SetCapability("idleTimeout", "200");
                            desiredCapability.SetCapability("ignoreZoomSetting", true);
                            desiredCapability.SetCapability(CapabilityType.HasNativeEvents, false);
                            desiredCapability.SetCapability("ignoreProtectedModeSettings", true);
                            desiredCapability.SetCapability("enablePersistentHover", true);

                            driver = new RemoteWebDriver(new Uri("http://jokurra:b5734581-5cf8-4c57-8a2c-a27f2196f4ea@ondemand.us-west-1.saucelabs.com:80/wd/hub"), desiredCapability);
                            return driver;
                        }
                        {
                            FirefoxOptions options = new FirefoxOptions();
                            FirefoxDriver driver = new FirefoxDriver();
                            return driver;
                        }
                    }
                case SeleniumDriverType.EdgeDriver:
                    {
                        if (ConfigurationData.IsWebDriverUsingSauceLabs)
                        {
                            IWebDriver driver;
                            DesiredCapabilities desiredCapability = new DesiredCapabilities();
                            desiredCapability.SetCapability("browserName", "microsoftedge");
                            desiredCapability.SetCapability("platform", "Windows 10");
                            desiredCapability.SetCapability("username", "jogainsco");
                            desiredCapability.SetCapability("accessKey", "b5734581-5cf8-4c57-8a2c-a27f2196f4ea");
                            desiredCapability.SetCapability("seleniumVersion", "3.5.0");
                            desiredCapability.SetCapability("edgedriverVersion", "");

                            desiredCapability.SetCapability("version", "90.0");

                            desiredCapability.SetCapability("commandTimeout", "600");
                            desiredCapability.SetCapability("idleTimeout", "200");
                            desiredCapability.SetCapability("ignoreZoomSetting", true);
                            desiredCapability.SetCapability(CapabilityType.HasNativeEvents, false);
                            desiredCapability.SetCapability("ignoreProtectedModeSettings", true);
                            desiredCapability.SetCapability("enablePersistentHover", true);

                            driver = new RemoteWebDriver(new Uri("http://jokurra:b5734581-5cf8-4c57-8a2c-a27f2196f4ea@ondemand.us-west-1.saucelabs.com:80/wd/hub"), desiredCapability);
                            return driver;
                        }
                        {
                            EdgeOptions options = new EdgeOptions();
                            EdgeDriver driver = new EdgeDriver();
                            return driver;
                        }
                    }

                case SeleniumDriverType.SafariDriver:
                    {
                        SafariDriver driver = new SafariDriver();
                        return driver;
                    }
                case SeleniumDriverType.OperaDriver:
                    {
                        OperaDriver driver = new OperaDriver();
                        return driver;
                    }
                default:
                    {
                        InternetExplorerDriver driver = new InternetExplorerDriver();
                        return driver;
                    }
            }
        }
    }
}
