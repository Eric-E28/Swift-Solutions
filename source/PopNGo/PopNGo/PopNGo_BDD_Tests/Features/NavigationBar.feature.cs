<<<<<<< HEAD
﻿
=======
﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:1.0.0.0
//      Reqnroll Generator Version:1.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PopNGo_BDD_Tests.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "1.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Navigation Bar")]
    [NUnit.Framework.CategoryAttribute("Cameron")]
    public partial class NavigationBarFeature
    {
        
        private Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "Cameron"};
        
#line 1 "NavigationBar.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            Reqnroll.FeatureInfo featureInfo = new Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Navigation Bar", @"As a visitor, I'd like to be able to more intuitively be able to switch pages so I can get to the page I want.

This story involves creating a new navigation bar with buttons on the bar that represent what the pages give accessibility to. There should be a logo for each page and each logo should represent its functionality. When a logo is clicked on the navigation bar, it should direct to that page, and change color denoting what page the user is currently on. The login/logout and profile/register buttons will remain on the top navigation bar.", ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("See the navigation bar")]
        [NUnit.Framework.CategoryAttribute("navigation")]
        public async System.Threading.Tasks.Task SeeTheNavigationBar()
        {
            string[] tagsOfScenario = new string[] {
                    "navigation"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("See the navigation bar", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 10
    await testRunner.GivenAsync("the user is on the home page", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 11
    await testRunner.ThenAsync("the user should see the navigation bar", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Click on the logo")]
        [NUnit.Framework.CategoryAttribute("navigation")]
        public async System.Threading.Tasks.Task ClickOnTheLogo()
        {
            string[] tagsOfScenario = new string[] {
                    "navigation"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Click on the logo", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 15
    await testRunner.GivenAsync("the user is on the home page", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 16
    await testRunner.WhenAsync("the user clicks on the home logo", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 17
    await testRunner.ThenAsync("the user should be directed to the home page", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigation styling change")]
        [NUnit.Framework.CategoryAttribute("navigation")]
        public async System.Threading.Tasks.Task NavigationStylingChange()
        {
            string[] tagsOfScenario = new string[] {
                    "navigation"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Navigation styling change", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 21
    await testRunner.GivenAsync("the user is on the home page", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 22
    await testRunner.WhenAsync("the user clicks on the home logo", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 23
    await testRunner.ThenAsync("the color of the home logo should not be white", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigation styling change on hover")]
        [NUnit.Framework.CategoryAttribute("navigation")]
        public async System.Threading.Tasks.Task NavigationStylingChangeOnHover()
        {
            string[] tagsOfScenario = new string[] {
                    "navigation"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Navigation styling change on hover", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 27
    await testRunner.GivenAsync("the user is on the home page", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 28
    await testRunner.WhenAsync("the user hovers over the home logo", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 29
    await testRunner.ThenAsync("the color of the home logo should not be white", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
>>>>>>> 38cbe6f2e35377718afec52d456aebcf81f5045e
