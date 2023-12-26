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

        [FindsBy(How = How.XPath, Using = ".//*[@id='TabBar:AddressBookTab-btnWrap']")]
        public IWebElement AddressBookTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='TabBar:AdminTab-btnInnerEl']")]
        public IWebElement AdministrationTab { get; set; }        

        [FindsBy(How = How.XPath, Using = ".//*[@id='AddressBookSearch:AddressBookSearchScreen:ttlBar']")]
        public IWebElement AddressBookSearchScreenTitleBarText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='AddressBookSearch:AddressBookSearchScreen:AddressBookSearchDV:CCAddressBookSearchLocationInputSet:CCAddressBookAddressInputSet:globalAddressContainer:globalAddress:GlobalAddressBookAddressInputSet:PostalCode-inputEl']")]
        public IWebElement ZipCodeTextBox { get; set; }      

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'AddressBookSearchLV:0:DisplayName')]")]
        public IWebElement ActionCollisionRepairDisplayName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'ClaimSearchScreen_PrintButton-btnInnerEl')]")]
        public IWebElement PrintOrExportButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='AddressBookSearch:AddressBookSearchScreen:AddressBookSearchDV:SearchAndResetInputSet:SearchLinksInputSet:Search']")]
        public IWebElement SearchAddressBookSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='GroupDetailPage:GroupDetailScreen:ttlBar']")]
        public IWebElement GroupDetailScreenTitleBarText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='Admin:MenuLinks:Admin_Monitoring']/div/span")]
        public IWebElement MonitoringTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='MessagingDestinationControlList:MessagingDestinationControlListScreen:ttlBar']")]
        public IWebElement MessagingDestinationControlListScreenTitleBarText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='MessagingDestinationControlList:MessagingDestinationControlListScreen:MessagingDestinationControlList_RestartMessagingEngineButton-btnInnerEl']")]
        public IWebElement RestartMessagingEngineButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@id, 'MessagingDestinationsControlLV-body')]/div/div/table[1]/tbody/tr[1]/td[4]")]
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

        public override bool IsAt()
        {
            throw new NotImplementedException();
        }
    }
}

