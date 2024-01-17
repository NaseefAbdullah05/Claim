using Gainsco.ClaimCenter.CodedUITests.Framework.BasePages;
using Gainsco.Training.CodedUITests.Framework.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gainsco.ClaimCenter.CodedUITests.Framework.Pages
{
    public class ClaimCenterHomePage : PageBase
    {
        public ClaimCenterHomePage(IWebDriver webDriver) : base(webDriver) { }

        [FindsBy(How = How.XPath, Using = ".//*[@name='Login-LoginScreen-LoginDV-username']")]
        public IWebElement ClaimsHomePageUserNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='Login-LoginScreen-LoginDV-password']")]
        public IWebElement ClaimsHomePagePasswordTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='Login-LoginScreen-LoginDV-submit']")]
        public IWebElement ClaimsHomePageLoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='DesktopActivities:DesktopActivitiesScreen:0']")]
        public IWebElement DesktopActivitiesScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='gw-TitleBar--title']")]
        public IWebElement ActivitiesText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Search or Create Policy')]")]
        public IWebElement SearchOrCreatePolicyText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-FNOLWizard_FindPolicyScreen-ttlBar']")]
        public IWebElement SearchOrCreatePolicyScreenTitleBarText { get; set; }        

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-FNOLWizard_FindPolicyScreen-FNOLWizardFindPolicyPanelSet-policyNumber']")]
        public IWebElement PolicyNumberTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-FNOLWizard_FindPolicyScreen-FNOLWizardFindPolicyPanelSet-date1']")]
        public IWebElement LossDateTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard:FNOLWizard_FindPolicyScreen:FNOLWizardFindPolicyPanelSet:vin-inputEl']")]
        public IWebElement VinTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-FNOLWizard_FindPolicyScreen-FNOLWizardFindPolicyPanelSet-Search']")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='TabBar-ClaimTab']")]
        public IWebElement ClaimTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='TabBar-ClaimTab']/div[3]/div")]
        public IWebElement ClaimTabDownArrow { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='TabBar-ClaimTab-ClaimTab_FNOLWizard']")]
        public IWebElement NewClaimText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ClaimSummary-ClaimSummaryScreen-ttlBar']")]
        public IWebElement SummaryScreenTitleBarText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Claim #')]")]
        public IWebElement ClaimNumberText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-FNOLWizard_FindPolicyScreen-FNOLWizardFindPolicyPanelSet-11']")]
        public IWebElement ClaimHistoryText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-FNOLWizard_FindPolicyScreen-FNOLWizardFindPolicyPanelSet-PolicyResultLV-0-unselectButton']")]
        public IWebElement UnselectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-Next']")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Time : Time of Loss must be entered manually!!')]")]
        public IWebElement TimeOfLossMessageText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard:FNOLWizard_FindPolicyScreen:FNOLWizardFindPolicyPanelSet:Claim_lossTime-inputEl']")]
        public IWebElement ClaimLossTimeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='TabBar-AddressBookTab']")]
        public IWebElement AddressBookTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='TabBar-AdminTab']")]
        public IWebElement AdministrationTab { get; set; }        

        [FindsBy(How = How.XPath, Using = ".//*[@id='AddressBookSearch-AddressBookSearchScreen-ttlBar']")]
        public IWebElement AddressBookSearchScreenTitleBarText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='AddressBookSearch-AddressBookSearchScreen-AddressBookSearchDV-CCAddressBookSearchLocationInputSet-CCAddressBookAddressInputSet-globalAddressContainer-globalAddress-GlobalAddressBookAddressInputSet-PostalCode']")]
        public IWebElement ZipCodeTextBox { get; set; }      

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'AddressBookSearch-AddressBookSearchScreen-AddressBookSearchLV-0-DisplayName_button')]")]
        public IWebElement ActionCollisionRepairDisplayName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'ClaimSearchScreen_PrintButton')]")]
        public IWebElement PrintOrExportButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='AddressBookSearch-AddressBookSearchScreen-AddressBookSearchDV-SearchAndResetInputSet-SearchLinksInputSet-Search']")]
        public IWebElement SearchAddressBookSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='GroupDetailPage-GroupDetailScreen-ttlBar']")]
        public IWebElement GroupDetailScreenTitleBarText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='Admin-MenuLinks-Admin_Monitoring']")]
        public IWebElement MonitoringTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='MessagingDestinationControlList-MessagingDestinationControlListScreen-ttlBar']")]
        public IWebElement MessagingDestinationControlListScreenTitleBarText { get; set; }

        [FindsBy(How = How.XPath,Using = ".//*[@id='MessagingDestinationControlList-MessagingDestinationControlListScreen-MessagingDestinationControlList_RestartMessagingEngineButton']")]
        public IWebElement RestartMessagingEngineButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'Messaging DestinationsControlLV-body')]/div/div/table[1]/tbody/tr[1]/td[4]")]
        public IWebElement FinancialsStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[2]/tbody/tr[1]/td[4]")]
        public IWebElement MitchellClaimSaveTransportStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[3]/tbody/tr[1]/td[4]")]
        public IWebElement MitchellPaymentDecisionTransportStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[4]/tbody/tr[1]/td[4]")]
        public IWebElement ContactMessagePluginStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[5]/tbody/tr[1]/td[4]")]
        public IWebElement AppraisalsStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[6]/tbody/tr[1]/td[4]")]
        public IWebElement LexisNexisPoliceReportTransportStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[7]/tbody/tr[1]/td[4]")]
        public IWebElement MSPOutboundTransportStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[8]/tbody/tr[1]/td[4]")]
        public IWebElement EmailStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[9]/tbody/tr[1]/td[4]")]
        public IWebElement ISOStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[10]/tbody/tr[1]/td[4]")]
        public IWebElement ContactAutoSyncFailureStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[11]/tbody/tr[1]/td[4]")]
        public IWebElement HistorylogStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[12]/tbody/tr[1]/td[4]")]
        public IWebElement ContactMessageTransportStatusText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@class, 'gw-DateValueWidget--ampm-button')]")]
        public IWebElement AmPmButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_BasicInfoScreen-ttlBar']")]
        public IWebElement BasicInformationTitleText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_BasicInfoScreen-PanelRow-BasicInfoDetailViewPanelDV-ReportedBy_Name']")]
        public IWebElement SelectNameInBasicInformation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_BasicInfoScreen-PanelRow-BasicInfoDetailViewPanelDV-Claim_ReportedByType']")]
        public IWebElement SelectRelationInBasicInformation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_BasicInfoScreen-PanelRow-RightPanel-FNOLWizard_BasicInfoRightPanelSet-0-InsuredVehicleDV-InsuredVehicleInputGroup-_checkbox']")]
        public IWebElement CarCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-ttlBar']")]
        public IWebElement ClaimInformationTitleText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-VehicleIncidentIterator-0-VehicleIncidentDV-VehicleName_button']")]
        public IWebElement VehicleNameButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLVehicleIncidentPopup-FNOLVehicleIncidentScreen-0']")]
        public IWebElement VehicleDetailsTitleText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLVehicleIncidentPopup-FNOLVehicleIncidentScreen-Operable']")]
        public IWebElement SelectOperable { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLVehicleIncidentPopup-FNOLVehicleIncidentScreen-OccupantLV_tb-AddDriverButton']")]
        public IWebElement AddDriverButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLContactPopup-FNOLContactScreen-ttlBar']")]
        public IWebElement DriverDetailsTitleText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLContactPopup-FNOLContactScreen-ContactDV-Driver_Picker']")]
        public IWebElement SelectContractDriver { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLContactPopup-FNOLContactScreen-ContactDV-FNOLContactInputSet-RelationToInsured']")]
        public IWebElement SelectRelationToInsured { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLContactPopup-FNOLContactScreen-ContactDV-Driver_Picker']")]
        public IWebElement SelectPerson { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLContactPopup-FNOLContactScreen-ContactDV-FNOLContactInputSet-RelationToInsured']")]
        public IWebElement SelectRelationToInsuredAtDriverPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLContactPopup-FNOLContactScreen-Update']")]
        public IWebElement OkButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLVehicleIncidentPopup-FNOLVehicleIncidentScreen-Update']")]
        public IWebElement OkButtonOnVehicleDetails { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-Claim_LossCause']")]
        public IWebElement SelectLossCause { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-LossCause1']")]
        public IWebElement SelectLossCauseSubType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-Claim_Locationtype']")]
        public IWebElement SelectLocationType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-Description']")]
        public IWebElement DescreptionTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-Claim_EmploymentCourse_0']")]
        public IWebElement YesInsuredVehicleDriverEmployment { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-Claim_CommercialVehicle_1']")]
        public IWebElement NoCommercialVehicle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-Claim_ReparFacilityLoss_1']")]
        public IWebElement NoLossOccured { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-DriveratLoss_0']")]
        public IWebElement YesDriverLoss { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-AddressDetailInputSetRef-CCLossDetailsAddressInputSet-globalAddressContainer-Address_Picker']")]
        public IWebElement SelectLocation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-Notification_FirstNoticeSuit_1']")]
        public IWebElement NoFirstNotice { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_NewLossDetailsScreen-LossDetailsAddressDV-Status_PoliceResponse_1']")]
        public IWebElement NoPoliceResponse { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-ttlBar']")]
        public IWebElement ServiceScreenTitleText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-RentalServiceDV-RentalServiceInputSet-RentalServiceInputSet-RentalInputGroup-_checkbox']")]
        public IWebElement RentalCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-VehicleIncidentTowingDV-TowingInputGroup-_checkbox']")]
        public IWebElement TowingCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-AppraisalServiceDV-AppraisalServiceInputSet-AppraisalServiceInputSet-AppraisalServiceInputGroup-_checkbox']")]
        public IWebElement AppraisalCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-VehicleIncidentAutoBodyDV-AutobodyInputGroup-_checkbox']")]
        public IWebElement AutoBodyCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-RentalServiceDV-RentalServiceInputSet-RentalServiceInputSet-RentalInputGroup-RentalBeginDate']")]
        public IWebElement RentalBeginDateBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@class, 'gw-datePicker--today gw-button-secondary')]")]
        public IWebElement TodayButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-RentalServiceDV-RentalServiceInputSet-RentalServiceInputSet-RentalInputGroup-RentalEndDate']")]
        public IWebElement RentalEndDateBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-RentalServiceDV-RentalServiceInputSet-RentalServiceInputSet-RentalInputGroup-RentalRate']")]
        public IWebElement RentalDailyRateBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-RentalServiceDV-RentalServiceInputSet-RentalServiceInputSet-RentalInputGroup-RentalAgency']")]
        public IWebElement SelectRentalAgency { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-AppraisalServiceDV-AppraisalServiceInputSet-AppraisalServiceInputSet-AppraisalServiceInputGroup-Assessor_Picker']")]
        public IWebElement SelectInitialAssessor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-AppraisalServiceDV-AppraisalServiceInputSet-AppraisalServiceInputSet-AppraisalServiceInputGroup-OtherServiceRequestInfo-NewServiceRequestInstructionInputSet-ServiceAddressPicker']")]
        public IWebElement SelectAppraisalLocation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@name='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_ServicesScreen-0-VehicleIncidentPanelSet-RentalServiceDV-RentalServiceInputSet-RentalServiceInputSet-RentalInputGroup-OtherServiceRequestInfo-NewServiceRequestInstructionInputSet-ServiceAddressPicker']")]
        public IWebElement SelectPickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_AssignSaveScreen-ttlBar']")]
        public IWebElement SaveAndAssignTitleText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_AssignSaveScreen-ttlBar']")]
        public IWebElement SaveAndAssignScreenTitleText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_AssignSaveScreen-NewExposureLV_tb-AddExposure']")]
        public IWebElement NewExposureButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='FNOLWizard-AutoWorkersCompWizardStepSet-FNOLWizard_AssignSaveScreen-NewExposureLV_tb-AddExposure-0-item']")]
        public IWebElement FirstItemInNewExposure { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Comprehensive']/parent::div")]
        public IList <IWebElement> CollisionId { get; set; }

        public override void GoTo()
        {
            string url = BaseAddress;
            WebDriver.Navigate().GoToUrl(url);
        }

     

        public void KeyDownOnTheElement(IWebElement Element)
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                     By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                     (x => x.SummaryScreenTitleBarText)), WebDriver);
            Element.SendKeys(Keys.Down);
            
        }

        public void PressEnterOnTheElement(IWebElement Element)
        {            
            Element.SendKeys(Keys.Enter);
        }

        public virtual bool IsAtNewClaimMenu()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
             By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
            (x => x.NewClaimText)), WebDriver);

            return (NewClaimText.Text == "New Claim" & ClaimNumberText.Text == "Claim #:") ? true : false;

        }

        public virtual bool IsAtClaimSummaryScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                     By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                     (x => x.SummaryScreenTitleBarText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(SummaryScreenTitleBarText, WebDriver, ClaimsConstants.SummaryText);
        }

        public virtual bool IsAtFindPolicyScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                     By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                     (x => x.SearchOrCreatePolicyScreenTitleBarText)), WebDriver);
            return SearchOrCreatePolicyScreenTitleBarText.Text == ClaimsConstants.SearchOrCreatePolicyText;
        }

        public virtual bool IsAtDesktopActivitiesScreen()
        {  
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.ActivitiesText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(ActivitiesText, WebDriver, ClaimsConstants.ActivitiesText);           

        }

        public virtual bool IsSearchButtonEnabled()
        {
            SeleniumHelper.WaitUntilElementIsVisible(By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>(x => x.SearchButton)), WebDriver);
            return (SeleniumHelper.IsElementEnabled(By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>(x => x.SearchButton)), WebDriver));
        }

        public virtual bool IsPolicySearchResultsDisplayed()
        {
            SeleniumHelper.WaitUntilElementIsClickable(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.UnselectButton)), WebDriver);
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.ClaimHistoryText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(ClaimHistoryText, WebDriver, ClaimsConstants.ClaimHistoryText);

        }

        public virtual bool IsTimeOfLossErrorMessageTextDisplayed()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.TimeOfLossMessageText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(TimeOfLossMessageText, WebDriver, ClaimsConstants.TimeOfLossErrorMessageText);

        }

        public virtual void SelectClaimLossTime()
        {
            SeleniumHelper.WaitUntilElementIsVisible(By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>(x => x.ClaimLossTimeDropdown)), WebDriver);
            SeleniumHelper.SetDropDownListSelectedTextByIndex(ClaimLossTimeDropdown, 1);
        }

        public virtual bool IsAtAddressBookSearchScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.AddressBookSearchScreenTitleBarText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(AddressBookSearchScreenTitleBarText, WebDriver, ClaimsConstants.SearchAddressBookText);

        }

        public virtual bool IsSearchAddressBookSearchButtonClickable()
        {
            IWebElement element = SeleniumHelper.WaitUntilElementIsClickable(By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>(x => x.SearchAddressBookSearchButton)), WebDriver);
            return element != null ? true : false;
        }

        public virtual bool IsSearchAddressBookResultsDisplayed()
        {
            SeleniumHelper.WaitUntilElementIsClickable(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.PrintOrExportButton)), WebDriver);
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.ActionCollisionRepairDisplayName)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(ActionCollisionRepairDisplayName, WebDriver, ClaimsConstants.ActionCollisionRepairText);

        }

        public virtual bool IsAtGroupDetailScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.GroupDetailScreenTitleBarText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(GroupDetailScreenTitleBarText, WebDriver, ClaimsConstants.GainscoText);

        }

        public virtual bool IsAtMessageQueuesScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.MessagingDestinationControlListScreenTitleBarText)), WebDriver);
            SeleniumHelper.WaitUntilElementIsClickable(
                   By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                   (x => x.RestartMessagingEngineButton)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(MessagingDestinationControlListScreenTitleBarText, WebDriver, ClaimsConstants.MessageQueuesText);

        }

        public virtual bool IsStatusStarted()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.FinancialsStatusText)), WebDriver);
            if (FinancialsStatusText.Text == ClaimsConstants.StartedText
                && MitchellClaimSaveTransportStatusText.Text == ClaimsConstants.StartedText
                && MitchellPaymentDecisionTransportStatusText.Text == ClaimsConstants.StartedText
                && ContactMessagePluginStatusText.Text == ClaimsConstants.StartedText
                && AppraisalsStatusText.Text == ClaimsConstants.StartedText
                && LexisNexisPoliceReportTransportStatusText.Text == ClaimsConstants.StartedText
                && MSPOutboundTransportStatusText.Text == ClaimsConstants.StartedText
                && EmailStatusText.Text == ClaimsConstants.StartedText
                && ISOStatusText.Text == ClaimsConstants.StartedText
                && ContactAutoSyncFailureStatusText.Text == ClaimsConstants.StartedText
                && HistorylogStatusText.Text == ClaimsConstants.StartedText
                && ContactMessageTransportStatusText.Text == ClaimsConstants.StartedText)               
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public virtual bool IsAtBasicInformationScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.BasicInformationTitleText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(BasicInformationTitleText, WebDriver, ClaimsConstants.BasicInformationText);
        }

    
        public virtual void SelectBasicInformation(IWebElement element, int index)
        {
            SeleniumHelper.SetDropDownListSelectedTextByIndex(element, index);
        }

        public virtual bool IsAtClaimInformationScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.ClaimInformationTitleText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(ClaimInformationTitleText, WebDriver, ClaimsConstants.ClaimInformationText);
        }
        public virtual bool IsAtVehicleDetailsScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.VehicleDetailsTitleText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(VehicleDetailsTitleText, WebDriver, ClaimsConstants.VehicleDetailsText);
        }

        public virtual bool IsAtDriverDetailsScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.DriverDetailsTitleText)), WebDriver);
            var a = DriverDetailsTitleText.Text;
            return SeleniumHelper.WaitUntilTextToBePresentInElement(DriverDetailsTitleText, WebDriver, ClaimsConstants.DriverDetailsText);
        }

        public virtual bool IsAtServiceScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.ServiceScreenTitleText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(ServiceScreenTitleText, WebDriver, ClaimsConstants.ServiceScreenText);
        }

        public virtual bool IsAtSaveAndAssignScreen()
        {
            SeleniumHelper.WaitUntilElementIsVisible(
                    By.XPath(SeleniumHelper.GetLocator<ClaimCenterHomePage>
                    (x => x.SaveAndAssignScreenTitleText)), WebDriver);
            return SeleniumHelper.WaitUntilTextToBePresentInElement(SaveAndAssignScreenTitleText, WebDriver, ClaimsConstants.SaveAndAssignScreenText);
        }

        public void JavaScriptClick(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)WebDriver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public void HoverAndClick(IWebElement element1, IWebElement element2)
        {
            SeleniumHelper.HoverAndClick(WebDriver, element1, element2);
        }

        public override bool IsAt()
        {
            throw new NotImplementedException();
        }
    }
}

