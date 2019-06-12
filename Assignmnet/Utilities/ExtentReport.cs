using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet.Utilities
{
 
 class ExtentReport
    {
        public static ExtentReports extent;
        public static void ExtentReportInitiating()
        {

            ExtentHtmlReporter reporter = new ExtentHtmlReporter(
                    "C:\\Users\\gauravrajpoot\\source\\repos\\RestSharpAndExpedia\\Assignmnet\\Report\\extent.html");
            extent = new ExtentReports();
            extent.AttachReporter(reporter);
        }
    }
} 
 


