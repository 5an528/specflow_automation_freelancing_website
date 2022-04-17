using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using System;
using System.Collections.Concurrent;
using SpecFlowWithSelenium.PageObjects;
using SpecFlow.Actions.Selenium;

namespace SpecFlowWithSelenium.Hooks
{
    [Binding]
    public class MainHook
    {
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;
        private string Kolabtree = "https://test.kolabtree.com/"; // https://www.kolabtree.com/ https://test.kolabtree.com/

        public MainHook(FeatureContext featureContext, ScenarioContext scenarioContext, IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }

        private static ExtentTest featureName;
        [ThreadStatic]
        private static ExtentTest scenario;
        private static ExtentReports extent;
        public static ConcurrentDictionary<string, ExtentTest> fatureDictionary = new ConcurrentDictionary<string, ExtentTest>();

        [BeforeTestRun]
        public static void TestInitalize()
        {
            //Initialize the Report
            var htmlReporter = new ExtentHtmlReporter(Common.Constants.ReportExportLocation);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlReporter.Config.ReportName = Common.Constants.ReportName;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeFeature]
        public static void initializeDriver(FeatureContext featureContext)
        {
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
            fatureDictionary.TryAdd(featureContext.FeatureInfo.Title, featureName);
        }

        [BeforeScenario]
        public void SetUpTest(FeatureContext _featureContext)
        {
            if (_browserInteractions.GetUrl() != Kolabtree)
            {
                _browserInteractions.GoToUrl(Kolabtree);
            }
            string InBSName = _featureContext.FeatureInfo.Title;
            if (fatureDictionary.ContainsKey(InBSName))
            {
                scenario = fatureDictionary[InBSName].CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
            }
        }

        [AfterStep]
        public void InsertReportingSteps()
        {
            var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (_scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
            }
            else if (_scenarioContext.TestError != null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
                }
            }
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Write the report to the report directory
            extent.Flush();
        }
    }
}
