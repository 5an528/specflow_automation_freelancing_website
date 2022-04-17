using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Example.PageObjects;
using SpecFlow.Actions.Selenium;
using System;
using System.Reflection;
using System.Threading;
using TechTalk.SpecFlow;

namespace Example.Hooks
{
    /// <summary>
    /// Calculator related hooks
    /// </summary>
    [Binding]
    public class CalculatorHooks
    {
        //private static ExtentTest featureName;
        //private static ExtentTest scenario;
        //private static ExtentReports extent;

        private readonly IBrowserInteractions _browserInteractions;
        public CalculatorHooks(IBrowserInteractions browserInteractions)
        {
            _browserInteractions = browserInteractions;
        }

        ///<summary>
        ///  Reset the calculator before each scenario tagged with "Calculator"
        /// </summary>
        [BeforeScenario("Calculator")]
        [Obsolete]
        //[System.Obsolete]
        public void BeforeScenario()
        {
            var calculatorPageObject = new CalculatorPageObject(_browserInteractions);
            calculatorPageObject.EnsureCalculatorIsOpenAndReset();
            //scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        //[BeforeTestRun]
        //public static void InitializeReport()
        //{
        //    var htmlReporter = new ExtentHtmlReporter(@"C:\SSD Work\Test\ResultNew\");
        //    extent = new ExtentReports();
        //    extent.AttachReporter(htmlReporter);
        //}

        //[AfterTestRun]
        //public static void TearDownReport()
        //{
        //    extent.Flush();
        //}

        //[AfterStep]
        //public static void InsertReportingSteps(ScenarioContext _scenarioContext)
        //{
        //    var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
        //    PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("ScenarioExecutionStatus", BindingFlags.Instance | BindingFlags.Public);
        //    MethodInfo getter = pInfo?.GetGetMethod(nonPublic: true);
        //    object TestResult = getter.Invoke(_scenarioContext, null);

        //    Thread.Sleep(1000);

        //    if (_scenarioContext.TestError == null)
        //    {
        //        if (stepType == "Given")
        //            _extentTest.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
        //        else if (stepType == "When")
        //            _extentTest.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
        //        else if (stepType == "Then")
        //            _extentTest.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
        //        else if (stepType == "And")
        //            _extentTest.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
        //    }
        //    if (_scenarioContext.TestError != null)
        //    {
        //        if (stepType == "Given")
        //            _extentTest.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
        //        if (stepType == "When")
        //            _extentTest.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
        //        if (stepType == "Then")
        //            _extentTest.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
        //        if (stepType == "And")
        //            _extentTest.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
        //    }
        //}
        //[BeforeFeature]
        //public static void BeforeFeature(FeatureContext featurecontext)
        //{
        //    featureName = extent.CreateTest(featurecontext.FeatureInfo.Title);
        //}
    }
}