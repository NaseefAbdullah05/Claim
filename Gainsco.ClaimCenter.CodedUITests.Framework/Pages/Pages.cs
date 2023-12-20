using Gainsco.CodedUITests.Common.EnumType;
using Gainsco.Training.CodedUITests.Framework.EnumType;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gainsco.ClaimCenter.CodedUITests.Framework.Pages
{
    public static partial class Pages
    {
        private static SeleniumDriverType _SeleniumDriverType = default(SeleniumDriverType);
        private static string Browser = ConfigurationManager.AppSettings["Browser"].ToString(); 
        public static SeleniumDriverType SeleniumDriverType
        {
            get {
                if (Browser == "Chrome")
                {
                    _SeleniumDriverType = SeleniumDriverType.ChromeDriver;
                }
                else if (Browser == "Internet Explorer")
                {
                    _SeleniumDriverType = SeleniumDriverType.InternetExplorerDriver;
                }
                else if (Browser == "Internet Explorer 11")
                {
                    _SeleniumDriverType = SeleniumDriverType.InternetExplorer11Driver;
                }
                else if (Browser == "Firefox")
                {
                    _SeleniumDriverType = SeleniumDriverType.FirefoxDriver;
                }
                else
                {
                    _SeleniumDriverType = SeleniumDriverType.InternetExplorerDriver;
                }

                return _SeleniumDriverType;
            
            }
            set
            {
                _SeleniumDriverType = value;
            }
        }
    }
}
