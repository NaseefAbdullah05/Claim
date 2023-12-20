using Gainsco.CodedUITests.Common.Selenium;
using Gainsco.Policy.CodedUITests.Framework.Selenium;
using Gainsco.Training.CodedUITests.Framework.EnumType;
using OpenQA.Selenium;

namespace Gainsco.ClaimCenter.CodedUITests.Framework.Pages
{
    public static partial class Pages
    {
        private static ClaimCenterHomePage _claimCenterHomePage = null;

        public static ClaimCenterHomePage ClaimCenterHomePage
        {
            get
            {
                if (_claimCenterHomePage == null)
                {
                    IWebDriver driver = new SeleniumDriverFactory(SeleniumDriverType).GetDriver();

                    _claimCenterHomePage = new ClaimCenterHomePage(driver);
                }
                return _claimCenterHomePage;
            }
            set
            {
                _claimCenterHomePage = value;
            }
        }
    }
}
