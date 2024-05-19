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
    [NUnit.Framework.DescriptionAttribute("As a user, I want to receive timely updates about my itinerary and changes to it")]
    public partial class AsAUserIWantToReceiveTimelyUpdatesAboutMyItineraryAndChangesToItFeature
    {
        
        private Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "PG-282.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            Reqnroll.FeatureInfo featureInfo = new Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "As a user, I want to receive timely updates about my itinerary and changes to it", @"While the itinerary interface is useable, the user needs more feedback about the events as they're happening. Ideally, the user can set up an itinerary and throughout the day, receive reminders about what's next on the itinerary and when/where it's going to be. This ensures that the user remains aware of the current time and pacing of events, and can plan accordingly if they need to alter their schedule. The timing of these emails should be left to the user to configure in the itinerary itself.

In addition, the user should be able to send a copy of their itinerary to themselves as an email to keep a record for themselves or show others, should the user wish to.", ProgrammingLanguage.CSharp, featureTags);
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
#line 7
#line hidden
            Reqnroll.Table table6 = new Reqnroll.Table(new string[] {
                        "UserName",
                        "Email",
                        "FirstName",
                        "LastName",
                        "Password"});
            table6.AddRow(new string[] {
                        "Tristan Goucher",
                        "knott@example.com",
                        "Tristan",
                        "Goucher",
                        "FAKE PW"});
#line 8
    await testRunner.GivenAsync("the following users exist", ((string)(null)), table6, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User checks their itinerary to set a reminder time for an event")]
        public async System.Threading.Tasks.Task UserChecksTheirItineraryToSetAReminderTimeForAnEvent()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("User checks their itinerary to set a reminder time for an event", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 7
await this.FeatureBackgroundAsync();
#line hidden
#line 13
await testRunner.GivenAsync("I am a user with first name \'Tristan\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 14
await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 15
await testRunner.AndAsync("I am on the \"Itinerary\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 16
await testRunner.WhenAsync("I am viewing my first itinerary", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 17
await testRunner.AndAsync("I look at the first event", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 18
await testRunner.ThenAsync("I can configure the time to send a reminder notification", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User tries to set a reminder timer for an event that has already started")]
        public async System.Threading.Tasks.Task UserTriesToSetAReminderTimerForAnEventThatHasAlreadyStarted()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("User tries to set a reminder timer for an event that has already started", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 7
await this.FeatureBackgroundAsync();
#line hidden
#line 21
await testRunner.GivenAsync("I am a user with first name \'Tristan\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 22
await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 23
await testRunner.AndAsync("I am on the \"Itinerary\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 24
await testRunner.AndAsync("I am viewing my first itinerary", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 25
await testRunner.AndAsync("I look at the first event", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 26
await testRunner.WhenAsync("I try to configure a time past the event\'s start", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 27
await testRunner.ThenAsync("the time is not changed from what it originally was", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User sets a default reminder time for new itinerary events")]
        public async System.Threading.Tasks.Task UserSetsADefaultReminderTimeForNewItineraryEvents()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("User sets a default reminder time for new itinerary events", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 7
await this.FeatureBackgroundAsync();
#line hidden
#line 30
await testRunner.GivenAsync("I am a user with first name \'Tristan\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 31
await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 32
await testRunner.WhenAsync("I am on the \"Profile Notifications\" page", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 33
await testRunner.ThenAsync("I can see a default itinerary reminder time setting", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User wants to use a new default time for itinerary events")]
        public async System.Threading.Tasks.Task UserWantsToUseANewDefaultTimeForItineraryEvents()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("User wants to use a new default time for itinerary events", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 7
await this.FeatureBackgroundAsync();
#line hidden
#line 36
await testRunner.GivenAsync("I am a user with first name \'Tristan\'", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 37
await testRunner.AndAsync("I login", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 38
await testRunner.AndAsync("I am on the \"Profile Notifications\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 39
await testRunner.WhenAsync("I change the default itinerary reminder time", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 40
await testRunner.AndAsync("I go to the \"Explore\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 41
await testRunner.AndAsync("the events have loaded", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 42
await testRunner.AndAsync("I click on the first event card", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 43
await testRunner.AndAsync("I click the \"Add to Itinerary\" button", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 44
await testRunner.AndAsync("I click the first itinerary", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 45
await testRunner.AndAsync("I am on the \"Itinerary\" page", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 46
await testRunner.AndAsync("I am viewing my first itinerary", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
#line 47
await testRunner.ThenAsync("I can see the new reminder time on the itinerary for this event", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
