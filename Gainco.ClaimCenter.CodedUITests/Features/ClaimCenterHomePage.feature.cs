﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Gainsco.ClaimCenter.CodedUITests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Claim Center Home Page")]
    [NUnit.Framework.CategoryAttribute("ClaimCenterHomePage")]
    public partial class ClaimCenterHomePageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ClaimCenterHomePage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Claim Center Home Page", "\tAs a Gainsco Agent,\r\n\tI want to be able to view claims associated to Gainsco ins" +
                    "ured accounts to be able to manage the claims process", ProgrammingLanguage.CSharp, new string[] {
                        "ClaimCenterHomePage"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Claim Center Home Page")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void ClaimCenterHomePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Claim Center Home Page", new string[] {
                        "AllScenarios"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("I have access to home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.And("I have entered a valid username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.And("I have entered a valid password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
testRunner.When("I click on login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
testRunner.Then("I will be redirected to desktop activities screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Summary screen redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void SummaryScreenRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Summary screen redirection", new string[] {
                        "AllScenarios"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
testRunner.Given("I am on the desktop activities screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
testRunner.When("I click on the claim tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
testRunner.Then("I am redirected to claims summary screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("New claim menu display under claims tab")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void NewClaimMenuDisplayUnderClaimsTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("New claim menu display under claims tab", new string[] {
                        "AllScenarios"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
testRunner.Given("I am on the desktop activities screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
testRunner.When("I click on claim tab down arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
testRunner.Then("claim menu should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find policy screen redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void FindPolicyScreenRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find policy screen redirection", new string[] {
                        "AllScenarios"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
testRunner.Given("I am on the desktop activities screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
testRunner.When("I click on claim tab down arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
testRunner.And("I click new claim from menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
testRunner.Then("I am redirected to find policy screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search button enabled on find policy screen")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void SearchButtonEnabledOnFindPolicyScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search button enabled on find policy screen", new string[] {
                        "AllScenarios"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
testRunner.Given("I am on the find policy screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
testRunner.And("I enter policy number in the policy number text box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
testRunner.When("I click on the loss date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
testRunner.Then("search button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Policy number search results will display")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void PolicyNumberSearchResultsWillDisplay()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Policy number search results will display", new string[] {
                        "AllScenarios"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
testRunner.Given("search button is enabled on find policy screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
testRunner.Then("policy search results will display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Time of loss error message will display")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void TimeOfLossErrorMessageWillDisplay()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Time of loss error message will display", new string[] {
                        "AllScenarios"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
testRunner.Given("I am on the policy search results screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
testRunner.When("I click on next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
testRunner.Then("time of loss error message should display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Address book search screen redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void AddressBookSearchScreenRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Address book search screen redirection", new string[] {
                        "AllScenarios"});
#line 53
this.ScenarioSetup(scenarioInfo);
#line 54
testRunner.Given("I am on the desktop activities screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
testRunner.When("I click on address book tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
testRunner.Then("I am redirected to address book search screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Address book search results will display")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void AddressBookSearchResultsWillDisplay()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Address book search results will display", new string[] {
                        "AllScenarios"});
#line 59
this.ScenarioSetup(scenarioInfo);
#line 60
testRunner.Given("I am on the search address book screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
testRunner.And("I enter zipcode in the text box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
testRunner.When("I click on search button in search address book screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
testRunner.Then("search results will display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Group details screen page redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void GroupDetailsScreenPageRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Group details screen page redirection", new string[] {
                        "AllScenarios"});
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
testRunner.Given("I am on the desktop activities screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
testRunner.When("I click on administration tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
testRunner.Then("I am redirected to group detail screen page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Message queues screen redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void MessageQueuesScreenRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Message queues screen redirection", new string[] {
                        "AllScenarios"});
#line 72
this.ScenarioSetup(scenarioInfo);
#line 73
testRunner.Given("I am on the group detail screen page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
testRunner.When("I click on monitoring tab on the left hand side", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
testRunner.Then("I am redirected to message queues screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Basic information page redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void BasicInformationPageRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Basic information page redirection", new string[] {
                        "AllScenarios"});
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
testRunner.Given("search button is enabled on find policy screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
testRunner.Then("policy search results will display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
testRunner.Given("I select a time in time section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
testRunner.When("I click on next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
testRunner.Then("I am redirected to basic information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Claim Information page redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void ClaimInformationPageRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Claim Information page redirection", new string[] {
                        "AllScenarios"});
#line 87
this.ScenarioSetup(scenarioInfo);
#line 88
testRunner.Given("search button is enabled on find policy screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
testRunner.Then("policy search results will display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
testRunner.Given("I select a time in time section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
testRunner.When("I click on next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
testRunner.Then("I am redirected to basic information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
testRunner.When("I select name information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
testRunner.And("I select relation information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
testRunner.And("I select a Car", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
testRunner.When("I click on next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
testRunner.Then("I am redirected to claim information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Vehicle details page redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void VehicleDetailsPageRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Vehicle details page redirection", new string[] {
                        "AllScenarios"});
#line 101
this.ScenarioSetup(scenarioInfo);
#line 102
testRunner.Given("I am at claim information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 103
testRunner.When("I click on vehicle name button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
testRunner.Then("I am reidrected to vehicle details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Driver details page redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void DriverDetailsPageRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Driver details page redirection", new string[] {
                        "AllScenarios"});
#line 107
this.ScenarioSetup(scenarioInfo);
#line 108
testRunner.Given("I am at claim information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 109
testRunner.When("I click on vehicle name button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
testRunner.Then("I am reidrected to vehicle details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
testRunner.When("I select operable option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
testRunner.And("I click add driver button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
testRunner.Then("I am redirected to driver details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Service page redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void ServicePageRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Service page redirection", new string[] {
                        "AllScenarios"});
#line 116
this.ScenarioSetup(scenarioInfo);
#line 117
testRunner.Given("I am at driver details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 118
testRunner.When("I select a person", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
testRunner.And("relation to insured", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
testRunner.When("I click ok button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
testRunner.Then("I am reidrected to vehicle details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
testRunner.When("I click ok button on vehicle details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
testRunner.Then("I am redirected to claim information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
testRunner.When("I fill out all required fill in claim information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
testRunner.When("I click on next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
testRunner.Then("I am redirected to service screen page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save and Assign claim page redirection")]
        [NUnit.Framework.CategoryAttribute("AllScenarios")]
        public virtual void SaveAndAssignClaimPageRedirection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save and Assign claim page redirection", new string[] {
                        "AllScenarios"});
#line 129
this.ScenarioSetup(scenarioInfo);
#line 130
testRunner.Given("I am at driver details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 131
testRunner.When("I select a person", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 132
testRunner.And("relation to insured", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
testRunner.When("I click ok button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
testRunner.Then("I am reidrected to vehicle details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
testRunner.When("I click ok button on vehicle details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
testRunner.Then("I am redirected to claim information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
testRunner.When("I fill out all required fill in claim information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
testRunner.When("I click on next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
testRunner.Then("I am redirected to service screen page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
testRunner.When("I fill out all required fill in service page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
testRunner.When("I click on next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 142
testRunner.Then("I am redirected to save and assign claim page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 143
testRunner.When("I Select collision as exposure", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

