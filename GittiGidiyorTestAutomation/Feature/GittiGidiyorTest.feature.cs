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
namespace GittiGidiyorTestAutomation.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GittiGidiyorTest")]
    public partial class GittiGidiyorTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GittiGidiyorTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GittiGidiyorTest", "\tGittiGidiyor Purchase Process Test", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("GittiGidiyorTest")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void GittiGidiyorTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GittiGidiyorTest", new string[] {
                        "mytag"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.And("GittiGidiyor anasayfası açılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 7
 testRunner.And("Güncel fırsatlar pop-up\'ında daha sonra butonu tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 8
 testRunner.And("Giriş yap butonu üzerine gelinir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 9
 testRunner.And("Giriş yap butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 10
 testRunner.And("Email alanına \'email\' şifre alanına \'password\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 11
 testRunner.And("Üye girişi ekranında giriş yap butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

