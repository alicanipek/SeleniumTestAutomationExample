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
        [NUnit.Framework.DescriptionAttribute("GittiGidiyorTestForAccountsWithoutAddress")]
        [NUnit.Framework.CategoryAttribute("GittiGidiyorTestForAccountsWithoutAddress")]
        public virtual void GittiGidiyorTestForAccountsWithoutAddress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GittiGidiyorTestForAccountsWithoutAddress", new string[] {
                        "GittiGidiyorTestForAccountsWithoutAddress"});
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
 testRunner.And("Email alanına \'email\' şifre alanına \'şifre\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 11
 testRunner.And("Üye girişi ekranında giriş yap butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 12
 testRunner.And("Menüden Otomobil, Motosiklet üzerine gelinir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 13
 testRunner.And("Menüden eldiven seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 14
 testRunner.And("Yan filtreden kırmızı-siyah seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 15
 testRunner.And("Üst filtreden ücretsiz kargo seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 16
 testRunner.And("İlk ürün seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 17
 testRunner.And("Beden olarak \'Beden\' seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 18
 testRunner.And("Renk olarak \'Renk\' seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 19
 testRunner.And("Sepete Ekle butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 20
 testRunner.And("Alışverişi tamamla butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 21
 testRunner.And("Ad alanına \'İsim\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 22
 testRunner.And("Soyad alanına \'Soyisim\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 23
 testRunner.And("Şehir olarak \'Şehir\' seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 24
 testRunner.And("İlçe olarak \'İlçe\' seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 25
 testRunner.And("Adres alanına \'Adres\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 26
 testRunner.And("Telefon-1 alanına \'5123456789\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 27
 testRunner.And("Kaydet ve Devam Et butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 28
 testRunner.And("Ödeme yöntemi olarak BKM express seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GittiGidiyorTestForAccountsWithAddress")]
        [NUnit.Framework.CategoryAttribute("GittiGidiyorTestForAccountsWithAddress")]
        public virtual void GittiGidiyorTestForAccountsWithAddress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GittiGidiyorTestForAccountsWithAddress", new string[] {
                        "GittiGidiyorTestForAccountsWithAddress"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.And("GittiGidiyor anasayfası açılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 33
 testRunner.And("Güncel fırsatlar pop-up\'ında daha sonra butonu tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 34
 testRunner.And("Giriş yap butonu üzerine gelinir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 35
 testRunner.And("Giriş yap butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 36
 testRunner.And("Email alanına \'email\' şifre alanına \'password\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 37
 testRunner.And("Üye girişi ekranında giriş yap butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 38
 testRunner.And("Menüden Otomobil, Motosiklet üzerine gelinir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 39
 testRunner.And("Menüden eldiven seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 40
 testRunner.And("Yan filtreden kırmızı-siyah seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 41
 testRunner.And("Üst filtreden ücretsiz kargo seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 42
 testRunner.And("İlk ürün seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 43
 testRunner.And("Beden olarak \'L\' seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 44
 testRunner.And("Renk olarak \'Kırmızı-Siyah\' seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 45
 testRunner.And("Sepete Ekle butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 46
 testRunner.And("Alışverişi tamamla butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 47
 testRunner.And("Devam Et butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 48
 testRunner.And("Ödeme yöntemi olarak BKM express seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

