using Gainsco.ClaimCenter.CodedUITests.Framework;
using Gainsco.ClaimCenter.CodedUITests.Framework.Pages;
using Gainsco.ClaimCenter.CodedUITests.ScenarioContexts;
using Gainsco.CodedUITests.Common.EnumType;
using Gainsco.CodedUITests.Common.Logging;
using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace Gainsco.ClaimCenter.CodedUITests.Steps
{
    [Binding]
    [Category("ClaimCenterHomePage")]
    [Scope(Feature = "Claim Center Home Page")]
    public class ClaimCenterHomePageSteps : StepBase
    {
        private readonly ClaimCenterHomePageScenarioData claimCenterHomePageScenarioData;
        private readonly ScenarioContext _scenarioContext;

        public ClaimCenterHomePageSteps(ClaimCenterHomePageScenarioData ClaimCenterHomePageScenarioData, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            ScenarioContextData.ClaimCenterHomePageScenarioData = claimCenterHomePageScenarioData;
            ScenarioContextData.ClaimCenterHomePageScenarioData.ScenarioContext = _scenarioContext;
            _serilogLogger = new SerilogLogger<ClaimCenterHomePageSteps>();
        }

        #region Specflow Event Hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            RetryOnlyScenarioTestsThatHaveFailed(_scenarioContext);

            ScenarioExecutionLevel scenarioExecutionLevel = (ScenarioExecutionLevel)Enum.Parse(typeof(ScenarioExecutionLevel), ScenarioExecutionLevel);

            if (!_scenarioContext.ScenarioInfo.Tags.Contains(scenarioExecutionLevel.ToString()))
            {
                Assert.Ignore();
            }
            else
            {
                if (ConfigurationData.IsWebDriverUsingSauceLabs)
                {
                    Pages.ClaimCenterHomePage.SetupSauceLabsTestName(_scenarioContext);
                    
                }
            }
        }

        [AfterScenario]
        public void CleanUp()
        {
            if (!SkipThisTest)
            {
                string configValue = ScenarioExecutionLevel;
                ScenarioExecutionLevel scenarioExecutionLevel = (ScenarioExecutionLevel)Enum.Parse(typeof(ScenarioExecutionLevel), ScenarioExecutionLevel);

                if (_scenarioContext.ScenarioInfo.Tags.Contains(scenarioExecutionLevel.ToString()))
                {
                    if (ConfigurationData.IsWebDriverUsingSauceLabs)
                    {
                        Pages.ClaimCenterHomePage.SetupSauceLabsTestName(_scenarioContext);
                        Pages.ClaimCenterHomePage.SendSauceLabsTestResults(_scenarioContext);
                    }

                    Pages.ClaimCenterHomePage.CloseBrowser();
                    Pages.ClaimCenterHomePage = null;
                }

                SavePassedTestScenarioThatWasRetried(_scenarioContext);
            }
        }
        #endregion

        #region Given 

        [Given(@"I have access to home page")]
        public void GivenIHaveAccessToHomePage()
        {
            try
            {
                Pages.ClaimCenterHomePage.GoTo();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }
        
        [Given(@"I have entered a valid username")]
        public void GivenIHaveEnteredAValidUsername()
        {
            try
            {
                Pages.ClaimCenterHomePage.ClaimsHomePageUserNameTextBox.Clear();
                Pages.ClaimCenterHomePage.ClaimsHomePageUserNameTextBox.SendKeys(ConfigurationData.ClaimsHomePageUserName);
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"I have entered a valid password")]
        public void GivenIHaveEnteredAValidPassword()
        {
            try
            {
                Pages.ClaimCenterHomePage.ClaimsHomePagePasswordTextBox.Clear();
                Pages.ClaimCenterHomePage.ClaimsHomePagePasswordTextBox.SendKeys(ConfigurationData.ClaimsHomePagePassword);
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"I am on the desktop activities screen")]
        public void GivenIAmOnTheDesktopActivitiesScreen()
        {
            try
            {
                RunscenarioDesktopActivitiesscreen();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"I am on the claims summary screen")]
        public void GivenIAmOnTheClaimsSummaryScreen()
        {
            try
            {
                RunscenarioSummaryScreenRedirection();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"I am at the claim menu")]
        public void GivenIAmAtTheClaimMenu()
        {
            try
            {
                RunscenarioNewClaimMenudisplay();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"I am on the find policy screen")]
        public void GivenIAmOnTheFindPolicyScreen()
        {
            try
            {
                RunScenarioFindPolicyScreen();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"I enter policy number in the policy number text box")]
        public void GivenIEnterPolicyNumberInThePolicyNumberTextBox()
        {
            try
            {
                Pages.ClaimCenterHomePage.PolicyNumberTextBox.Clear();
                Pages.ClaimCenterHomePage.PolicyNumberTextBox.SendKeys(ConfigurationData.ClaimsPolicyNumber);
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"search button is enabled on find policy screen")]
        public void GivenSearchButtonIsEnabledOnFindPolicyScreen()
        {
            try
            {
                RunScenarioSearchButtonEnabledOnFindPolicyScreen();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"I am on the policy search results screen")]
        public void GivenIAmOnThePolicySearchResultsScreen()
        {
            try
            {
                RunScenarioPolicySearchResultsScreen();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"I am on the search address book screen")]
        public void GivenIAmOnTheSearchAddressBookScreen()
        {
            try
            {
                RunScenarioSearchAddressBookScreen();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }

        }
       

        [Given(@"I enter zipcode in the text box")]
        public void GivenIEnterZipcodeInTheTextBox()
        {
            try
            {
                Pages.ClaimCenterHomePage.ZipCodeTextBox.Clear();
                Pages.ClaimCenterHomePage.ZipCodeTextBox.SendKeys(ConfigurationData.ClaimsZipCode);
            }

            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Given(@"I am on the group detail screen page")]
        public void GivenIAmOnTheGroupDetailScreenPage()
        {
            try
            {
                RunScenarioGroupDetailScreen();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }



        #endregion


        #region When

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            try
            {
                Pages.ClaimCenterHomePage.ClaimsHomePageLoginButton.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [When(@"I click on the claim tab")]
        public void WhenIClickOnClaimsTab()
        {
            try
            {
                Pages.ClaimCenterHomePage.ClaimTab.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }
        [When(@"I click new claim from menu")]
        public void WhenIClickNewClaimFromMenu()
        {
            try
            {
                Pages.ClaimCenterHomePage.NewClaimText.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }


        [When(@"I keydown on the claim tab")]
        public void WhenIKeydownOnTheClaimTab()
        {
            try
            {
                Pages.ClaimCenterHomePage.KeyDownOnTheElement(Pages.ClaimCenterHomePage.ClaimTab);
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [When(@"I click on claim tab down arrow")]
        public void WhenIClickOnClaimTabDownArrow()
        {
            try
            {
                Pages.ClaimCenterHomePage.ClaimTabDownArrow.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }


        [When(@"I press enter on the new claim")]
        public void WhenIPressEnterOnTheNewClaim()
        {
            try
            {
                Pages.ClaimCenterHomePage.PressEnterOnTheElement(Pages.ClaimCenterHomePage.NewClaimText);
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [When(@"I click on the loss date")]
        public void WhenIClickOnTheLossDate()
        {
            try
            {
                Pages.ClaimCenterHomePage.LossDateTextBox.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            try
            {
                Pages.ClaimCenterHomePage.SearchButton.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [When(@"I click on next button")]
        public void WhenIClickOnNextButton()
        {
            try
            {
                Pages.ClaimCenterHomePage.NextButton.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [When(@"I click on address book tab")]
        public void WhenIClickOnAddressBookTab()
        {
            try
            {
                Pages.ClaimCenterHomePage.AddressBookTab.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [When(@"I click on search button in search address book screen")]
        public void WhenIClickOnSearchButtonInSearchAddressBookScreen()
        {
            try
            {
                Pages.ClaimCenterHomePage.IsSearchAddressBookSearchButtonClickable();
                Pages.ClaimCenterHomePage.SearchAddressBookSearchButton.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [When(@"I click on administration tab")]
        public void WhenIClickOnAdministrationTab()
        {
            try
            {
                Pages.ClaimCenterHomePage.AdministrationTab.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [When(@"I click on monitoring tab on the left hand side")]
        public void WhenIClickOnMonitoringTabOnTheLeftHandSide()
        {
            try
            {
                Pages.ClaimCenterHomePage.MonitoringTab.Click();
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }



        #endregion

        #region Then

        [Then(@"I will be redirected to desktop activities screen")]
        public void ThenIWillBeRedirectedToDesktopActivitiesScreen()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsAtDesktopActivitiesScreen());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Then(@"I am redirected to claims summary screen")]
        public void ThenIAmRedirectedToClaimsSummaryScreen()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsAtClaimSummaryScreen());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Then(@"claim menu should be visible")]
        public void ThenClaimMenuShouldBeVisible()
        {
            Assert.IsTrue(Pages.ClaimCenterHomePage.IsAtNewClaimMenu());
        }

        [Then(@"I am redirected to find policy screen")]
        public void ThenIAmRedirectedToFindPolicyScreen()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsAtFindPolicyScreen());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Then(@"search button is enabled")]
        public void ThenSearchButtonIsEnabled()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsSearchButtonEnabled());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }        

        [Then(@"policy search results will display")]
        public void ThenPolicySearchResultsWillDisplay()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsPolicySearchResultsDisplayed());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Then(@"time of loss error message should display")]
        public void ThenTimeOfLossErrorMessageShouldDisplay()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsTimeOfLossErrorMessageTextDisplayed());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Then(@"I am redirected to address book search screen")]
        public void ThenIAmRedirectedToAddressBookSearchScreen()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsAtAddressBookSearchScreen());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Then(@"search results will display")]
        public void ThenSearchResultsWillDisplay()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsSearchAddressBookResultsDisplayed());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Then(@"I am redirected to group detail screen page")]
        public void ThenIAmRedirectedToGroupDetailScreenPage()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsAtGroupDetailScreen());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Then(@"I am redirected to message queues screen")]
        public void ThenIAmRedirectedToMessageQueuesScreen()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsAtMessageQueuesScreen());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }

        [Then(@"I am verifying the status")]
        public void ThenIAmVerifyingTheStatus()
        {
            try
            {
                Assert.IsTrue(Pages.ClaimCenterHomePage.IsStatusStarted());
            }
            catch (Exception ex)
            {
                HandleStepException(_scenarioContext, ex);
            }
        }




        #endregion

        #region Methods

        /// <summary>
        /// Scenario: Claim Center Home Page
        /// Given I have access to home page
        /// And I have entered a valid username
        /// And I have entered a valid password
        /// When I click on login button
        /// Then I will be redirected to desktop activities screen
        /// </summary>
        private void RunscenarioDesktopActivitiesscreen()
        {
            GivenIHaveAccessToHomePage();
            GivenIHaveEnteredAValidUsername();
            GivenIHaveEnteredAValidPassword();
            WhenIClickOnLoginButton();
            ThenIWillBeRedirectedToDesktopActivitiesScreen();
        }

        /// <summary>
        /// Scenario: Summary screen redirection
        /// Given I am on the desktop activities screen
        /// When I click on the claim tab
        /// Then I am redirected to claims summary screen
        /// </summary>
        
        private void RunscenarioSummaryScreenRedirection()
        {
            GivenIAmOnTheDesktopActivitiesScreen();
            WhenIClickOnClaimsTab();
            ThenIAmRedirectedToClaimsSummaryScreen();
        }

        /// <summary>
        /// Scenario: New Claim Menu display under claims tab
        /// Given I am on the claims summary screen
        /// When I keydown on the claim tab
        /// Then claim menu should be visible
        /// </summary>
        
        private void RunscenarioNewClaimMenudisplay()
        {
            GivenIAmOnTheClaimsSummaryScreen();
            WhenIKeydownOnTheClaimTab();
            ThenClaimMenuShouldBeVisible();
        }

        /// <summary>
        /// Scenario: Find policy screen redirection
        /// Given I am at the claim menu
        /// When I click on claim tab down arrow
        /// When I click new claim from menu
        /// Then I am redirected to find policy screen
        /// </summary>
        private void RunScenarioFindPolicyScreen()
        {
            GivenIAmOnTheDesktopActivitiesScreen();
            WhenIClickOnClaimTabDownArrow();
            WhenIClickNewClaimFromMenu();
            ThenIAmRedirectedToFindPolicyScreen();
        }

        /// <summary>
        /// Scenario: Search button enabled on find policy screen
        /// Given I am on the find policy screen
        /// And I enter policy number in the policy number text box
        /// When I click on the loss date
        /// Then search button is enabled
        /// </summary>
        private void RunScenarioSearchButtonEnabledOnFindPolicyScreen()
        {
            GivenIAmOnTheFindPolicyScreen();
            GivenIEnterPolicyNumberInThePolicyNumberTextBox();
            WhenIClickOnTheLossDate();
            ThenSearchButtonIsEnabled();
        }

        /// <summary>
        /// Scenario: Policy number search results will display
        /// Given search button is enabled on find policy screen
        /// When I click on search button
        /// Then policy search results will display
        /// </summary>
        private void RunScenarioPolicySearchResultsScreen()
        {
            GivenSearchButtonIsEnabledOnFindPolicyScreen();
            WhenIClickOnSearchButton();
            ThenPolicySearchResultsWillDisplay();
        }

        /// <summary>
        /// Scenario: Address book search screen redirection
        /// Given I am on the desktop activities screen
        /// When I click on address book tab
        /// Then I am redirected to address book search screen
        /// </summary>
        private void RunScenarioSearchAddressBookScreen()
        {
            GivenIAmOnTheDesktopActivitiesScreen();
            WhenIClickOnAddressBookTab();
            ThenIAmRedirectedToAddressBookSearchScreen();
        }

        /// <summary>
        /// Scenario: Group details screen page redirection
        /// Given I am on the desktop activities screen
        /// When I click on Administration tab
        /// Then I am redirected to group detail screen page
        /// </summary>
        private void RunScenarioGroupDetailScreen()
        {
            GivenIAmOnTheDesktopActivitiesScreen();
            WhenIClickOnAdministrationTab();
            ThenIAmRedirectedToGroupDetailScreenPage();
        }


        #endregion


    }
}
