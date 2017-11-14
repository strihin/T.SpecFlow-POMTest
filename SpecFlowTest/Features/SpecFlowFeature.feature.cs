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
namespace SpecFlowTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SpecFlowFeature")]
    public partial class SpecFlowFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlowFeature", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Add two numbers")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AddTwoNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers", new string[] {
                        "mytag"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I have entered 50 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I have entered 70 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("the result should be 120 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create new employees with mandatory details")]
        [NUnit.Framework.CategoryAttribute("mytag7")]
        [NUnit.Framework.CategoryAttribute("mytag11")]
        public virtual void CreateNewEmployeesWithMandatoryDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create new employees with mandatory details", new string[] {
                        "mytag7",
                        "mytag11"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I have entered 50 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.And("I have entered 70 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Phone",
                        "Email"});
            table1.AddRow(new string[] {
                        "name1",
                        "12",
                        "+380504894389",
                        "1@yahoo.com"});
            table1.AddRow(new string[] {
                        "name2",
                        "63",
                        "+38050487899",
                        "2@yahoo.com"});
            table1.AddRow(new string[] {
                        "name3",
                        "42",
                        "+38050487904389",
                        "3@yahoo.com"});
            table1.AddRow(new string[] {
                        "name4",
                        "22",
                        "+380504000009",
                        "4@yahoo.com"});
#line 16
 testRunner.When("I fill form <Email> <Name> <Phone>", ((string)(null)), table1, "When ");
#line 22
 testRunner.Then("the result should be on the screens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add two numbers with separate data")]
        [NUnit.Framework.CategoryAttribute("mytag8")]
        [NUnit.Framework.TestCaseAttribute("nam1", "12", "+380504894389", "1@yahoo.com", null)]
        [NUnit.Framework.TestCaseAttribute("nam2", "63", "+38050487899", "2@yahoo.com", null)]
        [NUnit.Framework.TestCaseAttribute("nam3", "42", "+38050487904389", "3@yahoo.com", null)]
        public virtual void AddTwoNumbersWithSeparateData(string name, string age, string phone, string email, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag8"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers with separate data", @__tags);
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.When(string.Format("I add data like {0}, {1}, {2}, {3}", name, age, phone, email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create new employees through code")]
        [NUnit.Framework.CategoryAttribute("mytag9")]
        public virtual void CreateNewEmployeesThroughCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create new employees through code", new string[] {
                        "mytag9"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
testRunner.When("I add data like next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add  data through Assist")]
        [NUnit.Framework.CategoryAttribute("mytag10")]
        public virtual void AddDataThroughAssist()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add  data through Assist", new string[] {
                        "mytag10"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Phone",
                        "Email"});
            table2.AddRow(new string[] {
                        "nam1",
                        "12",
                        "+380504894389",
                        "1@yahoo.com"});
            table2.AddRow(new string[] {
                        "nam2",
                        "63",
                        "+38050487899",
                        "2@yahoo.com"});
            table2.AddRow(new string[] {
                        "nam3",
                        "42",
                        "+38050487904389",
                        "3@yahoo.com"});
#line 39
 testRunner.When("I add data through Assist", ((string)(null)), table2, "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
