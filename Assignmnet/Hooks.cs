

using Assignmnet.Utilities;
using TechTalk.SpecFlow;





[Binding]

public sealed class Hooks : BasePage

{

    [BeforeTestRun]

    public static void BeforeTestRun()

    {

        //InvokeDriver();

        // driver.Navigate().GoToUrl("google.com");

        ExtentReport.ExtentReportInitiating();



    }

    [AfterTestRun]

    public static void AfterTestRun()

    { 
            ExtentReport.extent.Flush();
    }

}