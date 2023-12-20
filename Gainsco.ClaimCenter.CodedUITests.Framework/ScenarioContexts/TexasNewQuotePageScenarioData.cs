using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Gainsco.Connect.Web.UI.SmokeTests.Framework.ScenarioContexts
{
    public class TexasNewQuotePageScenarioData
    {
        private string _quoteNumberString = "QuoteNumber";
        private string _premiumAmount = "PremiumAmount";
        private string _driverLicenseNumber = "DriverLicenseNumber";
        private string _firstName = "FirstName";
        private string _lastName = "LastName";
        private string _urlName = "UrlName";
        private string _policyNumberForPDF = "PolicyNumberForPDF";
        private string _pDFDirectory = "PDFDirectory";
        private string _pDFText = "PDFText";
        private string _originalPolicyNumber = "OriginalPolicyNumber";
        private string _latestpremiumAmount = "LatestPremiumAmount";
        private string _antiTheftTax = "AntiTheftTax";
        private string _policyFee = "PolicyFee";
        private string _vehicleOnePremium = "VehicleOnePremium";
        private string _vehicleSecondPremium = "VehicleSecondPremium";
        private string _vehiclePremium = "vehiclePremium";
        private string _downPaymentAmount = "DownPaymentAmount";
        private string _monthlyPaymentAmount = "MonthlyPaymentAmount";

        public string QuoteNumber
        {
            get
            {
                return (string)ScenarioContext.Current[_quoteNumberString];
            }
            set
            {
                ScenarioContext.Current[_quoteNumberString] = value;
            }
        }

        public string DownPaymentAmount
        {
            get
            {
                return (string)ScenarioContext.Current[_downPaymentAmount];
            }
            set
            {
                ScenarioContext.Current[_downPaymentAmount] = value;
            }
        }
        public string MonthlyPaymentAmount
        {
            get
            {
                return (string)ScenarioContext.Current[_monthlyPaymentAmount];
            }
            set
            {
                ScenarioContext.Current[_monthlyPaymentAmount] = value;
            }
        }

        public string VehicleOnePremium
        {
            get
            {
                return (string)ScenarioContext.Current[_vehicleOnePremium];
            }
            set
            {
                ScenarioContext.Current[_vehicleOnePremium] = value;
            }
        }
        public List<string> VehiclePremium
        {
            get
            {
                return (List<string>)ScenarioContext.Current[_vehiclePremium];
            }
            set
            {
                ScenarioContext.Current[_vehiclePremium] = value;
            }
        }

        public string VehicleSecondPremium
        {
            get
            {
                return (string)ScenarioContext.Current[_vehicleSecondPremium];
            }
            set
            {
                ScenarioContext.Current[_vehicleSecondPremium] = value;
            }
        }

        public string LatestPremiumAmount
        {
            get
            {
                return (string)ScenarioContext.Current[_latestpremiumAmount];
            }
            set
            {
                ScenarioContext.Current[_latestpremiumAmount] = value;
            }
        }
        public string OriginalPolicyNumber
        {
            get
            {
                return (string)ScenarioContext.Current[_originalPolicyNumber];
            }
            set
            {
                ScenarioContext.Current[_originalPolicyNumber] = value;
            }
        }
        public string PDFText
        {
            get
            {
                return (string)ScenarioContext.Current[_pDFText];
            }
            set
            {
                ScenarioContext.Current[_pDFText] = value;
            }
        }

        public string PDFDirectory
        {
            get
            {
                return (string)ScenarioContext.Current[_pDFDirectory];
            }
            set
            {
                ScenarioContext.Current[_pDFDirectory] = value;
            }
        }
        public string UrlName
        {
            get
            {
                return (string)ScenarioContext.Current[_urlName];
            }
            set
            {
                ScenarioContext.Current[_urlName] = value;
            }
        }

        public string PolicyNumberForPDF
        {
            get
            {
                return (string)ScenarioContext.Current[_policyNumberForPDF];
            }
            set
            {
                ScenarioContext.Current[_policyNumberForPDF] = value;
            }
        }

        public string FirstName
        {
            get
            {
                return (string)ScenarioContext.Current[_firstName];
            }
            set
            {
                ScenarioContext.Current[_firstName] = value;
            }
        }

        public string LastName
        {
            get
            {
                return (string)ScenarioContext.Current[_lastName];
            }
            set
            {
                ScenarioContext.Current[_lastName] = value;
            }
        }
        public double PremiumAmount
        {
            get
            {
                return (double)ScenarioContext.Current[_premiumAmount];
            }
            set
            {
                ScenarioContext.Current[_premiumAmount] = value;
            }
        }
        public double AntiTheftTax
        {
            get
            {
                return (double)ScenarioContext.Current[_antiTheftTax];
            }
            set
            {
                ScenarioContext.Current[_antiTheftTax] = value;
            }
        }
        public double PolicyFee
        {
            get
            {
                return (double)ScenarioContext.Current[_policyFee];
            }
            set
            {
                ScenarioContext.Current[_policyFee] = value;
            }
        }

        public double DriverLiceseNumber
        {
            get
            {
                return (double)ScenarioContext.Current[_driverLicenseNumber];
            }
            set
            {
                ScenarioContext.Current[_driverLicenseNumber] = value;
            }
        }

    }
}
