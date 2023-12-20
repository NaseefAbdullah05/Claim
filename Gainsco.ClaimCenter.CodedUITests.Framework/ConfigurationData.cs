using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gainsco.ClaimCenter.CodedUITests.Framework
{
    public class ConfigurationData
    {
       // private static bool _allowServiceCharges;
        private static bool _IsRetryingOnlyFailedScenarioTestsInEnvironment;
        public static bool IsWebDriverUsingSauceLabs = bool.Parse(ConfigurationManager.AppSettings["IsWebDriverUsingSauceLabs"].ToString());
        public static string ClaimsHomePageUserName = ConfigurationManager.AppSettings["ClaimsHomePageUserName"].ToString();
        public static string ClaimsHomePagePassword = ConfigurationManager.AppSettings["ClaimsHomePagePassword"].ToString();
        public static string ClaimsPolicyNumber = ConfigurationManager.AppSettings["ClaimsPolicyNumber"].ToString();
        public static string ClaimsZipCode = ConfigurationManager.AppSettings["ClaimsZipCode"].ToString();
        public static long TimeSpanWaitTicks = long.Parse(ConfigurationManager.AppSettings["TimeSpanWaitTicks"].ToString());
        public static int SleepTimeInMilliseconds = int.Parse(ConfigurationManager.AppSettings["SleepTimeInMilliseconds"].ToString());
        public static string ScenarioTestEnvironment = ConfigurationManager.AppSettings["ScenarioTestEnvironment"].ToString();
        public static String TunnelIdentifier = ConfigurationManager.AppSettings["TunnelIdentifier"].ToString();

        public static bool IsRetryingOnlyFailedScenarioTestsInEnvironment
        {
            get
            {
                try
                {
                    _IsRetryingOnlyFailedScenarioTestsInEnvironment = bool.Parse(ConfigurationManager.AppSettings["IsRetryingOnlyFailedScenarioTestsInEnvironment"].ToString());
                }
                catch
                {
                    _IsRetryingOnlyFailedScenarioTestsInEnvironment = false;
                }
                return _IsRetryingOnlyFailedScenarioTestsInEnvironment;
            }
        }

        //public static string ArizonaAgentUserId = ConfigurationManager.AppSettings["ArizonaAgentUserId"].ToString();
        //public static string ArizonaAgentCode = ConfigurationManager.AppSettings["ArizonaAgentCode"].ToString();
        //public static string ArizonaAgentPassword = ConfigurationManager.AppSettings["ArizonaAgentPassword"].ToString();
        //public static string FloridaAgentUserId = ConfigurationManager.AppSettings["FloridaAgentUserId"].ToString();
        //public static string FloridaAgentCode = ConfigurationManager.AppSettings["FloridaAgentCode"].ToString();
        //public static string FloridaAgentPassword = ConfigurationManager.AppSettings["FloridaAgentPassword"].ToString();
        //public static string GeorgiaAgentUserId = ConfigurationManager.AppSettings["GeorgiaAgentUserId"].ToString();
        //public static string GeorgiaAgentCode = ConfigurationManager.AppSettings["GeorgiaAgentCode"].ToString();
        //public static string GeorgiaAgentPassword = ConfigurationManager.AppSettings["GeorgiaAgentPassword"].ToString();
        //public static string NewMexicoAgentUserId = ConfigurationManager.AppSettings["NewMexicoAgentUserId"].ToString();
        //public static string NewMexicoAgentCode = ConfigurationManager.AppSettings["NewMexicoAgentCode"].ToString();
        //public static string NewMexicoAgentPassword = ConfigurationManager.AppSettings["NewMexicoAgentPassword"].ToString();
        //public static string OklahomaAgentUserId = ConfigurationManager.AppSettings["OklahomaAgentUserId"].ToString();
        //public static string OklahomaAgentCode = ConfigurationManager.AppSettings["OklahomaAgentCode"].ToString();
        //public static string OklahomaAgentPassword = ConfigurationManager.AppSettings["OklahomaAgentPassword"].ToString();
        //public static string SouthCarolinaAgentUserId = ConfigurationManager.AppSettings["SouthCarolinaAgentUserId"].ToString();
        //public static string SouthCarolinaAgentCode = ConfigurationManager.AppSettings["SouthCarolinaAgentCode"].ToString();
        //public static string SouthCarolinaAgentPassword = ConfigurationManager.AppSettings["SouthCarolinaAgentPassword"].ToString();
        //public static string TennesseeAgentUserId = ConfigurationManager.AppSettings["TennesseeAgentUserId"].ToString();
        //public static string TennesseeAgentCode = ConfigurationManager.AppSettings["TennesseeAgentCode"].ToString();
        //public static string TennesseeAgentPassword = ConfigurationManager.AppSettings["TennesseeAgentPassword"].ToString();
        //public static string TexasAgentUserId = ConfigurationManager.AppSettings["TexasAgentUserId"].ToString();
        //public static string TexasAgentCode = ConfigurationManager.AppSettings["TexasAgentCode"].ToString();
        //public static string TexasAgentPassword = ConfigurationManager.AppSettings["TexasAgentPassword"].ToString();
        //public static string UtahAgentUserId = ConfigurationManager.AppSettings["UtahAgentUserId"].ToString();
        //public static string UtahAgentCode = ConfigurationManager.AppSettings["UtahAgentCode"].ToString();
        //public static string UtahAgentPassword = ConfigurationManager.AppSettings["UtahAgentPassword"].ToString();
        //public static string VirginiaAgentUserId = ConfigurationManager.AppSettings["VirginiaAgentUserId"].ToString();
        //public static string VirginiaAgentCode = ConfigurationManager.AppSettings["VirginiaAgentCode"].ToString();
        //public static string VirginiaAgentPassword = ConfigurationManager.AppSettings["VirginiaAgentPassword"].ToString();

        //public static string ValidFirstNameTX = ConfigurationManager.AppSettings["ValidFirstNameTX"].ToString();
        //public static string ValidLastNameTX = ConfigurationManager.AppSettings["ValidLastNameTX"].ToString();
        //public static string ValidAddressTX = ConfigurationManager.AppSettings["ValidAddressTX"].ToString();
        //public static string ValidCityTX = ConfigurationManager.AppSettings["ValidCityTX"].ToString();
        //public static string ValidZipTX = ConfigurationManager.AppSettings["ValidZipTX"].ToString();
        //public static string AccountAndRoutingNumber = ConfigurationManager.AppSettings["AccountAndRoutingNumber"].ToString();
        //public static string InvalidAccountAndRoutingNumber = ConfigurationManager.AppSettings["InvalidAccountAndRoutingNumber"].ToString();
        //public static int PDFFromRequestDBPoolingTimeSpan = int.Parse(ConfigurationManager.AppSettings["PDFFromRequestDBPoolingTimeSpan"].ToString());
        //public static int PDFFromRequestDBMaxRetry = int.Parse(ConfigurationManager.AppSettings["PDFFromRequestDBMaxRetry"].ToString());
        //public static int RequestMaxRetry = int.Parse(ConfigurationManager.AppSettings["RequestMaxRetry"].ToString());
        //public static int PDFFileExistPoolingTimeSpan = int.Parse(ConfigurationManager.AppSettings["PDFFileExistPoolingTimeSpan"].ToString());
        //public static int PDFFileExistBMaxRetry = int.Parse(ConfigurationManager.AppSettings["PDFFileExistBMaxRetry"].ToString());
        //public static string AgentEmailAddress = ConfigurationManager.AppSettings["AgentEmailAddress"].ToString();
        //public static string InsurerEmailAddress = ConfigurationManager.AppSettings["InsurerEmailAddress"].ToString();
        //public static string PolicyNumberText = ConfigurationManager.AppSettings["PolicyNumberText"].ToString();
        //public static string ArizonaPolicyNumberText = ConfigurationManager.AppSettings["ArizonaPolicyNumberText"].ToString();
        //public static string NewMexicoPolicyNumberText = ConfigurationManager.AppSettings["NewMexicoPolicyNumberText"].ToString();
        //public static string TennesseePolicyNumberText = ConfigurationManager.AppSettings["TennesseePolicyNumberText"].ToString();
        //public static string VirginiaPolicyNumberText = ConfigurationManager.AppSettings["VirginiaPolicyNumberText"].ToString();
        //public static string GeorgiaPolicyNumberText = ConfigurationManager.AppSettings["GeorgiaPolicyNumberText"].ToString();
        //public static string SouthCarolinaPolicyNumberText = ConfigurationManager.AppSettings["SouthCarolinaPolicyNumberText"].ToString();
        //public static string UtahPolicyNumberText = ConfigurationManager.AppSettings["UtahPolicyNumberText"].ToString();
        //public static string FloridaPolicyNumberText = ConfigurationManager.AppSettings["FloridaPolicyNumberText"].ToString();
        //public static int AddDriverButtonCount = int.Parse(ConfigurationManager.AppSettings["AddDriverButtonCount"].ToString());
        //public static int AddVehicleButtonCount = int.Parse(ConfigurationManager.AppSettings["AddVehicleButtonCount"].ToString());
        //public static int MaximumDriver = int.Parse(ConfigurationManager.AppSettings["MaximumDriver"].ToString());
        //public static int MaximumVehicle = int.Parse(ConfigurationManager.AppSettings["MaximumVehicle"].ToString());
        //public static string AdditionalEquipmentValue = ConfigurationManager.AppSettings["AdditionalEquipmentValue"].ToString();


        //#region Texas
        //public static string FirstNameTX
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameTX"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameTX"].ToString();
        //    }
        //}

        //public static string MiddleNameTX
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameTX"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameTX"].ToString();
        //    }
        //}

        //public static string LastNameTX
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameTX"].ToString() : ConfigurationManager.AppSettings["FakeLastNameTX"].ToString();
        //    }
        //}

        //public static string AddressTX
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressTX"].ToString() : ConfigurationManager.AppSettings["FakeAddressTX"].ToString();
        //    }
        //}

        //public static string CityTX
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityTX"].ToString() : ConfigurationManager.AppSettings["FakeCityTX"].ToString();
        //    }
        //}

        //public static string ZipTX
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipTX"].ToString() : ConfigurationManager.AppSettings["FakeZipTX"].ToString();
        //    }
        //}

        //public static string DOBTX
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBTX"].ToString() : ConfigurationManager.AppSettings["FakeDOBTX"].ToString();
        //    }
        //}

        //public static string DriverLicenseNumberTX
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDriverLicenseNumberTX"].ToString() : ConfigurationManager.AppSettings["FakeDriverLicenseNumberTX"].ToString();
        //    }
        //}

        //#endregion

        //#region Tennessee
        //public static string FirstNameTN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameTN"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameTN"].ToString();
        //    }
        //}

        //public static string MiddleNameTN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameTN"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameTN"].ToString();
        //    }
        //}

        //public static string LastNameTN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameTN"].ToString() : ConfigurationManager.AppSettings["FakeLastNameTN"].ToString();
        //    }
        //}

        //public static string AddressTN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressTN"].ToString() : ConfigurationManager.AppSettings["FakeAddressTN"].ToString();
        //    }
        //}

        //public static string CityTN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityTN"].ToString() : ConfigurationManager.AppSettings["FakeCityTN"].ToString();
        //    }
        //}

        //public static string ZipTN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipTN"].ToString() : ConfigurationManager.AppSettings["FakeZipTN"].ToString();
        //    }
        //}

        //public static string DOBTN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBTN"].ToString() : ConfigurationManager.AppSettings["FakeDOBTN"].ToString();
        //    }
        //}

        //public static string DriverLicenseNumberTN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDriverLicenseNumberTN"].ToString() : ConfigurationManager.AppSettings["FakeDriverLicenseNumberTN"].ToString();
        //    }
        //}

        //#endregion

        //#region NewMexico

        //public static string FirstNameNM
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameNM"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameNM"].ToString();
        //    }
        //}

        //public static string MiddleNameNM
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameNM"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameNM"].ToString();
        //    }
        //}

        //public static string LastNameNM
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameNM"].ToString() : ConfigurationManager.AppSettings["FakeLastNameNM"].ToString();
        //    }
        //}

        //public static string AddressNM
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressNM"].ToString() : ConfigurationManager.AppSettings["FakeAddressNM"].ToString();
        //    }
        //}

        //public static string CityNM
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityNM"].ToString() : ConfigurationManager.AppSettings["FakeCityNM"].ToString();
        //    }
        //}

        //public static string ZipNM
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipNM"].ToString() : ConfigurationManager.AppSettings["FakeZipNM"].ToString();
        //    }
        //}

        //public static string DOBNM
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBNM"].ToString() : ConfigurationManager.AppSettings["FakeDOBNM"].ToString();
        //    }
        //}

        //public static string DriverLicenseNumberNM
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDriverLicenseNumberNM"].ToString() : ConfigurationManager.AppSettings["FakeDriverLicenseNumberNM"].ToString();
        //    }
        //}

        //#endregion


        //#region Virginia
        //public static string FirstNameVA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameVA"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameVA"].ToString();
        //    }
        //}

        //public static string MiddleNameVA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameVA"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameVA"].ToString();
        //    }
        //}

        //public static string LastNameVA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameVA"].ToString() : ConfigurationManager.AppSettings["FakeLastNameVA"].ToString();
        //    }
        //}

        //public static string AddressVA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressVA"].ToString() : ConfigurationManager.AppSettings["FakeAddressVA"].ToString();
        //    }
        //}

        //public static string CityVA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityVA"].ToString() : ConfigurationManager.AppSettings["FakeCityVA"].ToString();
        //    }
        //}

        //public static string ZipVA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipVA"].ToString() : ConfigurationManager.AppSettings["FakeZipVA"].ToString();
        //    }
        //}

        //public static string DOBVA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBVA"].ToString() : ConfigurationManager.AppSettings["FakeDOBVA"].ToString();
        //    }
        //}

        //public static string DriverLicenseNumberVA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDriverLicenseNumberVA"].ToString() : ConfigurationManager.AppSettings["FakeDriverLicenseNumberVA"].ToString();
        //    }
        //}

        //#endregion

        //#region Georgia

        //public static string FirstNameGA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameGA"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameGA"].ToString();
        //    }
        //}

        //public static string MiddleNameGA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameGA"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameGA"].ToString();
        //    }
        //}

        //public static string LastNameGA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameGA"].ToString() : ConfigurationManager.AppSettings["FakeLastNameGA"].ToString();
        //    }
        //}

        //public static string AddressGA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressGA"].ToString() : ConfigurationManager.AppSettings["FakeAddressGA"].ToString();
        //    }
        //}

        //public static string CityGA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityGA"].ToString() : ConfigurationManager.AppSettings["FakeCityGA"].ToString();
        //    }
        //}

        //public static string ZipGA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipGA"].ToString() : ConfigurationManager.AppSettings["FakeZipGA"].ToString();
        //    }
        //}

        //public static string DOBGA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBGA"].ToString() : ConfigurationManager.AppSettings["FakeDOBGA"].ToString();
        //    }
        //}

        //public static string DriverLicenseNumberGA
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDriverLicenseNumberGA"].ToString() : ConfigurationManager.AppSettings["FakeDriverLicenseNumberGA"].ToString();
        //    }
        //}



        //#endregion


        //#region SouthCarolina

        //public static string FirstNameSC
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameSC"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameSC"].ToString();
        //    }
        //}

        //public static string MiddleNameSC
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameSC"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameSC"].ToString();
        //    }
        //}

        //public static string LastNameSC
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameSC"].ToString() : ConfigurationManager.AppSettings["FakeLastNameSC"].ToString();
        //    }
        //}

        //public static string AddressSC
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressSC"].ToString() : ConfigurationManager.AppSettings["FakeAddressSC"].ToString();
        //    }
        //}

        //public static string CitySC
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCitySC"].ToString() : ConfigurationManager.AppSettings["FakeCitySC"].ToString();
        //    }
        //}

        //public static string ZipSC
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipSC"].ToString() : ConfigurationManager.AppSettings["FakeZipSC"].ToString();
        //    }
        //}

        //public static string DOBSC
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBSC"].ToString() : ConfigurationManager.AppSettings["FakeDOBSC"].ToString();
        //    }
        //}

        //public static string DriverLicenseNumberSC
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDriverLicenseNumberSC"].ToString() : ConfigurationManager.AppSettings["FakeDriverLicenseNumberSC"].ToString();
        //    }
        //}


        //#endregion

        //#region Florida

        //public static string FirstNameFL
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameFL"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameFL"].ToString();
        //    }
        //}

        //public static string MiddleNameFL
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameFL"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameFL"].ToString();
        //    }
        //}

        //public static string LastNameFL
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameFL"].ToString() : ConfigurationManager.AppSettings["FakeLastNameFL"].ToString();
        //    }
        //}

        //public static string AddressFL
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressFL"].ToString() : ConfigurationManager.AppSettings["FakeAddressFL"].ToString();
        //    }
        //}

        //public static string CityFL
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityFL"].ToString() : ConfigurationManager.AppSettings["FakeCityFL"].ToString();
        //    }
        //}

        //public static string ZipFL
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipFL"].ToString() : ConfigurationManager.AppSettings["FakeZipFL"].ToString();
        //    }
        //}

        //public static string DOBFL
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBFL"].ToString() : ConfigurationManager.AppSettings["FakeDOBFL"].ToString();
        //    }
        //}

        //public static string DriverLicenseNumberFL
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDriverLicenseNumberFL"].ToString() : ConfigurationManager.AppSettings["FakeDriverLicenseNumberFL"].ToString();
        //    }
        //}

        //#endregion


        //#region Utah

        //public static string FirstNameUT
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameUT"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameUT"].ToString();
        //    }
        //}

        //public static string MiddleNameUT
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameUT"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameUT"].ToString();
        //    }
        //}

        //public static string LastNameUT
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameUT"].ToString() : ConfigurationManager.AppSettings["FakeLastNameUT"].ToString();
        //    }
        //}

        //public static string AddressUT
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressUT"].ToString() : ConfigurationManager.AppSettings["FakeAddressUT"].ToString();
        //    }
        //}

        //public static string CityUT
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityUT"].ToString() : ConfigurationManager.AppSettings["FakeCityUT"].ToString();
        //    }
        //}

        //public static string ZipUT
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipUT"].ToString() : ConfigurationManager.AppSettings["FakeZipUT"].ToString();
        //    }
        //}

        //public static string DOBUT
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBUT"].ToString() : ConfigurationManager.AppSettings["FakeDOBUT"].ToString();
        //    }
        //}

        //public static string DriverLicenseNumberUT
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDriverLicenseNumberUT"].ToString() : ConfigurationManager.AppSettings["FakeDriverLicenseNumberUT"].ToString();
        //    }
        //}


        //#endregion

        //#region Oklahoma

        //public static string FirstNameOK
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameOK"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameOK"].ToString();
        //    }
        //}

        //public static string MiddleNameOK
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameOK"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameOK"].ToString();
        //    }
        //}

        //public static string LastNameOK
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameOK"].ToString() : ConfigurationManager.AppSettings["FakeLastNameOK"].ToString();
        //    }
        //}

        //public static string AddressOK
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressOK"].ToString() : ConfigurationManager.AppSettings["FakeAddressOK"].ToString();
        //    }
        //}

        //public static string CityOK
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityOK"].ToString() : ConfigurationManager.AppSettings["FakeCityOK"].ToString();
        //    }
        //}

        //public static string ZipOK
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipOK"].ToString() : ConfigurationManager.AppSettings["FakeZipOK"].ToString();
        //    }
        //}

        //public static string DOBOK
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBOK"].ToString() : ConfigurationManager.AppSettings["FakeDOBOK"].ToString();
        //    }
        //}

        //#endregion

        //#region Arizona

        //public static string FirstNameAZ
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveFirstNameAZ"].ToString() : ConfigurationManager.AppSettings["FakeFirstNameAZ"].ToString();
        //    }
        //}

        //public static string MiddleNameAZ
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveMiddleNameAZ"].ToString() : ConfigurationManager.AppSettings["FakeMiddleNameAZ"].ToString();
        //    }
        //}

        //public static string LastNameAZ
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveLastNameAZ"].ToString() : ConfigurationManager.AppSettings["FakeLastNameAZ"].ToString();
        //    }
        //}

        //public static string DOBAZ
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOBAZ"].ToString() : ConfigurationManager.AppSettings["FakeDOBAZ"].ToString();
        //    }
        //}

        //public static string AddressAZ
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveAddressAZ"].ToString() : ConfigurationManager.AppSettings["FakeAddressAZ"].ToString();
        //    }
        //}

        //public static string CityAZ
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveCityAZ"].ToString() : ConfigurationManager.AppSettings["FakeCityAZ"].ToString();
        //    }
        //}
        //public static string ZipAZ
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveZipAZ"].ToString() : ConfigurationManager.AppSettings["FakeZipAZ"].ToString();
        //    }
        //}

        //public static string DriverLicenseNumberAZ
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDriverLicenseNumberAZ"].ToString() : ConfigurationManager.AppSettings["FakeDriverLicenseNumberAZ"].ToString();
        //    }
        //}

        //#endregion


        //public static string VIN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveVIN"].ToString() : ConfigurationManager.AppSettings["FakeVIN"].ToString();
        //    }
        //}

        //public static string SecondVIN
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveSecondVIN"].ToString() : ConfigurationManager.AppSettings["FakeSecondVIN"].ToString();
        //    }
        //}

        //public static string DOB
        //{
        //    get
        //    {
        //        return AllowServiceCharges ? ConfigurationManager.AppSettings["LiveDOB"].ToString() : ConfigurationManager.AppSettings["FakeDOB"].ToString();
        //    }
        //}        

        //public static bool AllowServiceCharges
        //{
        //    get
        //    {
        //        try
        //        {
        //            _allowServiceCharges = bool.Parse(ConfigurationManager.AppSettings["AllowServiceCharges"].ToString());
        //        }
        //        catch
        //        {
        //            _allowServiceCharges = false;
        //        }
        //        return _allowServiceCharges;
        //    }
        //}
    }
}
