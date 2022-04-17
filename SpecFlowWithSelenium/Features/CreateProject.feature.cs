﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowWithSelenium.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CreateProjectFeature : object, Xunit.IClassFixture<CreateProjectFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CreateProject.feature"
#line hidden
        
        public CreateProjectFeature(CreateProjectFeature.FixtureData fixtureData, SpecFlowWithSelenium_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CreateProject", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
#line 4
   testRunner.Given("User will go to Kolabtree Website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
   testRunner.When("User click on Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 6
   testRunner.And("User fill username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
   testRunner.And("User fill password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
   testRunner.Then("User can click on login and go to home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Verify the validation when user enters wrong coupon code")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "Verify the validation when user enters wrong coupon code")]
        public void VerifyTheValidationWhenUserEntersWrongCouponCode()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the validation when user enters wrong coupon code", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 12
 testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
 testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("User reaches to promotion code step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.When("User enter promotion code \"asddfg\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.And("User Click on Apply Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.Then("User should get promo code invalid messaage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Verify the error message should display when project visibility is not selected")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "Verify the error message should display when project visibility is not selected")]
        public void VerifyTheErrorMessageShouldDisplayWhenProjectVisibilityIsNotSelected()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the error message should display when project visibility is not selected", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 90
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 91
 testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 92
 testRunner.And("User Accept cookies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.When("User click on Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("User should verify \"Please select at least one option.\" error message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Verify error message should display when less than 10 characters are entered in \'" +
            "Project title\'")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "Verify error message should display when less than 10 characters are entered in \'" +
            "Project title\'")]
        public void VerifyErrorMessageShouldDisplayWhenLessThan10CharactersAreEnteredInProjectTitle()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify error message should display when less than 10 characters are entered in \'" +
                    "Project title\'", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 98
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 99
   testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 100
   testRunner.And("User Accept cookies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
   testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
   testRunner.When("User go to Project title page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 103
   testRunner.And("User enter \"Failed\" as project title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
   testRunner.And("User click on Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
   testRunner.Then("User should verify Please enter at least 10 characters error in title field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Verify maximum 100 characters are allowed under \'Project title\'")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "Verify maximum 100 characters are allowed under \'Project title\'")]
        public void VerifyMaximum100CharactersAreAllowedUnderProjectTitle()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify maximum 100 characters are allowed under \'Project title\'", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 108
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 109
   testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 110
   testRunner.And("User Accept cookies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
   testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 112
   testRunner.When("User go to Project title page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 113
   testRunner.And("User enter \"asdfghjklaasdfghjklaasdfghjklaasdfghjklaasdfghjklaasdfghjklaasdfghjkl" +
                        "aasdfghjklaasdfghjklaasdfghjkla\" as project title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
   testRunner.Then("User should see remaining characters should show as \'0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Verify promotion code text area should be visible only once promotion code checkb" +
            "ox is selected")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "Verify promotion code text area should be visible only once promotion code checkb" +
            "ox is selected")]
        public void VerifyPromotionCodeTextAreaShouldBeVisibleOnlyOncePromotionCodeCheckboxIsSelected()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify promotion code text area should be visible only once promotion code checkb" +
                    "ox is selected", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 117
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 118
 testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 119
 testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
 testRunner.And("User reaches to promotion code step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 121
 testRunner.And("User should not see promotion code text area", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.When("User selects promo code check box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 123
 testRunner.Then("User should see promotion code text area to enter promo code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Verify promotion code check box is added on create project page")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "Verify promotion code check box is added on create project page")]
        public void VerifyPromotionCodeCheckBoxIsAddedOnCreateProjectPage()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify promotion code check box is added on create project page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 126
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 127
 testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 128
 testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
 testRunner.And("User reaches to promotion code step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.When("User  navigate to promotion code step in CP form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 131
 testRunner.Then("User should see promo code check box is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Verify project description should contain minimum 100 characters")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "Verify project description should contain minimum 100 characters")]
        public void VerifyProjectDescriptionShouldContainMinimum100Characters()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify project description should contain minimum 100 characters", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 134
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 135
 testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 136
 testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
 testRunner.And("User reaches to Project description step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 138
 testRunner.When("User enter less than 100 characters in project description field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 139
 testRunner.Then("user should see validation message reflects as \"Please enter at least 100 charact" +
                        "ers.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Subject area expertise should be mandatory field")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "Subject area expertise should be mandatory field")]
        public void SubjectAreaExpertiseShouldBeMandatoryField()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subject area expertise should be mandatory field", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 142
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 143
 testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 144
 testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
 testRunner.And("User reaches to subject area expertise step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 146
 testRunner.When("User clicks on next step button without selecting", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 147
 testRunner.Then("User should see subject area validation message reflects as \"Please add at least " +
                        "one subject matter expertise.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="\'\'By when do you need to hire a freelancer?\' question is mandatory")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "\'\'By when do you need to hire a freelancer?\' question is mandatory")]
        public void ByWhenDoYouNeedToHireAFreelancerQuestionIsMandatory()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\'\'By when do you need to hire a freelancer?\' question is mandatory", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 150
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 151
 testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 152
 testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 153
 testRunner.And("User reaches By when do you need to hire a freelancer? step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 154
 testRunner.When("User clicks post project button without selecting", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 155
 testRunner.Then("User should verify validation message reflects as \"Please select at least one opt" +
                        "ion.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="When user is loggedin and click on continuous previous project option , then syst" +
            "em error message should not reflect")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "When user is loggedin and click on continuous previous project option , then syst" +
            "em error message should not reflect")]
        public void WhenUserIsLoggedinAndClickOnContinuousPreviousProjectOptionThenSystemErrorMessageShouldNotReflect()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When user is loggedin and click on continuous previous project option , then syst" +
                    "em error message should not reflect", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 158
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 159
 testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 160
 testRunner.And("User navigate to new CP form url /create-project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 161
 testRunner.And("User Accept cookies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 162
 testRunner.And("User see two options display as \'start new project\'and \'continue previous project" +
                        "\' on modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 163
 testRunner.When("User clicks on \'continue previous project\' option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 164
 testRunner.Then("User should not see system error message alert and user should be able to continu" +
                        "e previous project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Service Category is mandatory field")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateProject")]
        [Xunit.TraitAttribute("Description", "Service Category is mandatory field")]
        public void ServiceCategoryIsMandatoryField()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Service Category is mandatory field", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 184
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 185
 testRunner.Given("User can switch to Project Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 186
 testRunner.And("User click on Create Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 187
 testRunner.And("User reaches service catagory step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 188
 testRunner.When("User clicks post project button without selecting One Task", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 189
 testRunner.Then("User should verify Please select at least on task", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CreateProjectFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CreateProjectFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion