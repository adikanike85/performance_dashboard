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
namespace kCura.PDB.Automated.UI.Testing.Gherkin.PageNavigation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NavigateToPDBScoringPages")]
    public partial class NavigateToPDBScoringPagesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NavigateToScoringPages.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NavigateToPDBScoringPages", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigation to the scoring pages.")]
        [NUnit.Framework.CategoryAttribute("GoldenFlow")]
        [NUnit.Framework.CategoryAttribute("Navigation")]
        [NUnit.Framework.CategoryAttribute("UserExperiencePage")]
        [NUnit.Framework.CategoryAttribute("InfrastructurePerformancePage")]
        [NUnit.Framework.CategoryAttribute("Recoverability/IntegrityPage")]
        [NUnit.Framework.CategoryAttribute("UptimePage")]
        [NUnit.Framework.TestCaseAttribute("User Experience", "User Experience Report", null)]
        [NUnit.Framework.TestCaseAttribute("Infrastructure Performance", "Infrastructure Performance Report", null)]
        [NUnit.Framework.TestCaseAttribute("Recoverability/Integrity", "Recoverability/Integrity Report", null)]
        [NUnit.Framework.TestCaseAttribute("Uptime", "Uptime Report", null)]
        public virtual void NavigationToTheScoringPages_(string targetPage, string scoringPage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GoldenFlow",
                    "Navigation",
                    "UserExperiencePage",
                    "InfrastructurePerformancePage",
                    "Recoverability/IntegrityPage",
                    "UptimePage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigation to the scoring pages.", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.When(string.Format("I navigate to the \'{0}\' page.", targetPage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.Then(string.Format("the \'{0}\' Page with the score loads.", scoringPage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
