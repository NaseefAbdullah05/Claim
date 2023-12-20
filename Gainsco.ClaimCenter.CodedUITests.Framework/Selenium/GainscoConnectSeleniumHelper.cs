using Gainsco.CodedUITests.Common.EnumType;
using Gainsco.CodedUITests.Common.Selenium;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Gainsco.ClaimCenter.CodedUITests.Framework.Selenium
{
    public class GainscoConnectSeleniumHelper : SeleniumHelper
    {
        public void WriteOnElementByIndex(By by, IWebDriver driver, DriverInformationStringTypes driverInformationStringTypes)
        {

            switch (driverInformationStringTypes)
            {
                case DriverInformationStringTypes.RandomString:
                    {
                        IList<IWebElement> elements = driver.FindElements(by);

                        for (int i = 0; i < elements.Count; i++)
                        {
                            IWebElement element = elements[i];
                            element.Clear();
                            element.SendKeys(GetRandomString());
                        }
                        break;
                    }
                case DriverInformationStringTypes.RandomDateOfBirth:
                    {
                        IList<IWebElement> elements = driver.FindElements(by);

                        for (int i = 0; i < elements.Count; i++)
                        {
                            IWebElement element = elements[i];
                            element.Clear();
                            element.SendKeys(GetRandomDOB());
                        }
                        break;
                    }
                case DriverInformationStringTypes.DriverLicenseNumber:
                    {
                        IList<IWebElement> elements = driver.FindElements(by);

                        for (int i = 0; i < elements.Count; i++)
                        {
                            IWebElement element = elements[i];
                            element.Clear();
                            element.SendKeys(GenerateDriverLicense().ToString());
                        }
                        break;
                    }
            }
        }


        public void WriteOnElementFromIndexOne(By by, IWebDriver driver, DriverInformationStringTypes driverInformationStringTypes)
        {

            switch (driverInformationStringTypes)
            {
                case DriverInformationStringTypes.RandomString:
                    {
                        IList<IWebElement> elements = driver.FindElements(by);

                        for (int i = 1; i < elements.Count; i++)
                        {
                            IWebElement element = elements[i];
                            element.Clear();
                            element.SendKeys(GetRandomString());
                        }
                        break;
                    }
                case DriverInformationStringTypes.RandomDateOfBirth:
                    {
                        IList<IWebElement> elements = driver.FindElements(by);

                        for (int i = 1; i < elements.Count; i++)
                        {
                            IWebElement element = elements[i];
                            element.Clear();
                            element.SendKeys(GetRandomDOB());
                        }
                        break;
                    }
                case DriverInformationStringTypes.DriverLicenseNumber:
                    {
                        IList<IWebElement> elements = driver.FindElements(by);

                        for (int i = 1; i < elements.Count; i++)
                        {
                            IWebElement element = elements[i];
                            element.Clear();
                            element.SendKeys(GenerateDriverLicense().ToString());
                        }
                        break;
                    }
            }
        }
    }
}
