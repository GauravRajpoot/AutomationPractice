﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Assignmnet.FeatureFile
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Check the Login functionality of AutomationPractice.com", Description="\tWE have to check the for each and every case of login", SourceFile="FeatureFile\\AutomationPractice.feature", SourceLine=0)]
    public partial class CheckTheLoginFunctionalityOfAutomationPractice_ComFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AutomationPractice.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Check the Login functionality of AutomationPractice.com", "\tWE have to check the for each and every case of login", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("For Empty email and vaid Password", SourceLine=5)]
        public virtual void ForEmptyEmailAndVaidPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Empty email and vaid Password", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("I have navigated to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("click on login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("Pass the parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("Message is Displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("Close th Browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("For Empty Password and valid email", SourceLine=12)]
        public virtual void ForEmptyPasswordAndValidEmail()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Empty Password and valid email", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Given("I have navigated to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.And("click on login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("Pass the parameters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("Unsucessfull Message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.And("Close th Browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("For Invalid Email and Invalid Password", SourceLine=20)]
        public virtual void ForInvalidEmailAndInvalidPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Invalid Email and Invalid Password", null, ((string[])(null)));
#line 21
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 22
 testRunner.Given("I have navigated to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("click on login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("Pass the Arguments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("Unsucessfull Message is shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.And("Close th Browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("For Empty Email and Empty Password", SourceLine=28)]
        public virtual void ForEmptyEmailAndEmptyPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Empty Email and Empty Password", null, ((string[])(null)));
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 30
 testRunner.Given("I have navigated to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.And("click on login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When("No Argument is passed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("Message is displayed accordingly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.And("Close th Browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion

