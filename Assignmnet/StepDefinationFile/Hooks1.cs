using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Assignmnet.StepDefinationFile
{
    [Binding]
    public sealed class Hooks1
    {
        public static ExtentTest featureName;

        public static ExtentTest scenerio;

        public static ExtentReports extent;

        [BeforeTestRun]

        public static void BeforeTest()

        {

            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\gauravrajpoot\source\repos\RestSharpAndExpedia\Assignmnet\Reports\Report.html");

            extent = new ExtentReports();

            extent.AttachReporter(htmlReporter);

        }


        [BeforeFeature]

        public static void beforeFeature()

        {

            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

        }

        [BeforeScenario]

        public static void BeforeScenario()

        {

            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }
        [AfterStep]
        public static void AfterSteps()

        {

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError != null)
            {
                switch (stepType)

                {
                    case "Given":
                        scenerio.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                        break;
                    case "When":
                        scenerio.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message); ;
                        break;
                    case "Then":
                        scenerio.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message); ;
                        break;
                    case "And":
                        scenerio.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message); ;
                        break;
                }

            }
            else if (ScenarioContext.Current.TestError == null)
            {
                switch (stepType)
                {
                    case "Given":
                        scenerio.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                        break;
                    case "When":
                        scenerio.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                        break;
                    case "Then":
                        scenerio.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                        break;
                    case "And":
                       scenerio.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                        break;

                }

            }

        }


        [AfterTestRun]

        public static void AfterTest()

        {

            extent.Flush();

        }
    }
}
