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
    [NUnit.Framework.DescriptionAttribute("Bookmark Lists Name Editing")]
    public partial class BookmarkListsNameEditingFeature
    {
        
        private Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "PG-174.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            Reqnroll.FeatureInfo featureInfo = new Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Bookmark Lists Name Editing", null, ProgrammingLanguage.CSharp, featureTags);
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
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 3
#line hidden
            Reqnroll.Table table2 = new Reqnroll.Table(new string[] {
                        "UserName",
                        "Email",
                        "FirstName",
                        "LastName",
                        "Password"});
            table2.AddRow(new string[] {
                        "Joshua Weiss",
                        "knott@example.com",
                        "Joshua",
                        "Weiss",
                        "FAKE PW"});
#line 4
 await testRunner.GivenAsync("the following users exist", ((string)(null)), table2, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I see an edit button on the bookmark lists")]
        public async System.Threading.Tasks.Task ISeeAnEditButtonOnTheBookmarkLists()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("I see an edit button on the bookmark lists", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 9
 await testRunner.GivenAsync("I am a user with first name \'Joshua\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 10
    await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 11
    await testRunner.AndAsync("I am on the \"Favorites\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 12
  await testRunner.WhenAsync("I have created a new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 13
  await testRunner.ThenAsync("I should see a button to edit the bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can see a way to edit the bookmark list name")]
        public async System.Threading.Tasks.Task ICanSeeAWayToEditTheBookmarkListName()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("I can see a way to edit the bookmark list name", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 16
  await testRunner.GivenAsync("I am a user with first name \'Joshua\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 17
    await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 18
    await testRunner.AndAsync("I am on the \"Favorites\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 19
    await testRunner.AndAsync("I have created a new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 20
  await testRunner.WhenAsync("I click the edit button on the new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 21
  await testRunner.ThenAsync("I should see a form to edit the bookmark list name", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can edit the bookmark list name")]
        public async System.Threading.Tasks.Task ICanEditTheBookmarkListName()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("I can edit the bookmark list name", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 24
  await testRunner.GivenAsync("I am a user with first name \'Joshua\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 25
    await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 26
    await testRunner.AndAsync("I am on the \"Favorites\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 27
    await testRunner.AndAsync("I have created a new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 28
    await testRunner.AndAsync("I click the edit button on the new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 29
  await testRunner.WhenAsync("I fill in the form with a new name", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 30
    await testRunner.AndAsync("I click the save button in the edit bookmark list form", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 31
  await testRunner.ThenAsync("I should see the new name on the bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I cant edit the bookmark list name to be blank")]
        public async System.Threading.Tasks.Task ICantEditTheBookmarkListNameToBeBlank()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("I cant edit the bookmark list name to be blank", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 34
  await testRunner.GivenAsync("I am a user with first name \'Joshua\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 35
    await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 36
    await testRunner.AndAsync("I am on the \"Favorites\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 37
    await testRunner.AndAsync("I have created a new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 38
    await testRunner.AndAsync("I click the edit button on the new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 39
  await testRunner.WhenAsync("I fill in the update bookmark list name form with a blank name", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 40
  await testRunner.ThenAsync("The save edit button should be disabled", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I cant edit the bookmark list name to be a duplicate")]
        public async System.Threading.Tasks.Task ICantEditTheBookmarkListNameToBeADuplicate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("I cant edit the bookmark list name to be a duplicate", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 43
  await testRunner.GivenAsync("I am a user with first name \'Joshua\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 44
    await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 45
    await testRunner.AndAsync("I am on the \"Favorites\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 46
    await testRunner.AndAsync("I have created a new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 47
    await testRunner.AndAsync("I click the edit button on the new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 48
  await testRunner.WhenAsync("I fill in the update bookmark list name form with the same name", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 49
  await testRunner.ThenAsync("The save edit button should be disabled", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can cancel editing the bookmark list name")]
        public async System.Threading.Tasks.Task ICanCancelEditingTheBookmarkListName()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("I can cancel editing the bookmark list name", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
await this.FeatureBackgroundAsync();
#line hidden
#line 52
  await testRunner.GivenAsync("I am a user with first name \'Joshua\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 53
    await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 54
    await testRunner.AndAsync("I am on the \"Favorites\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 55
    await testRunner.AndAsync("I have created a new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 56
    await testRunner.AndAsync("I click the edit button on the new bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 57
  await testRunner.WhenAsync("I click the cancel button in the edit bookmark list form", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 58
  await testRunner.ThenAsync("I should see the original name on the bookmark list", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
#line 59
    await testRunner.AndAsync("I should not see the edit bookmark list form", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
