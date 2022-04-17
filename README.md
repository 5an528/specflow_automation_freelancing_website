# Automation Test with extent report using SpecFlow and Selenium

The Automation Test demo is a way to help you all write easier and quicker test automation. 
This will solve common challenges you encounter during your work of automating an web application

Notes:

(1)System web driver version and project reference driver version need to be same.
(2)You can give customized test report tile from common setting and report export location also. 

common setting lock like below:

namespace SpecFlowWithSelenium.Common
{
    public static class Constants
    {
        public const string ReportName = @"Automation Test Report";
        public const string ReportExportLocation = @"C:\SSD Work\Test\ResultNew\";
    }
}   

For terminal run:
cmd: f:
cd F:\Kolabtreeclone\SpecFlowWithSelenium
dotnet test
copy F:\Kolabtreeclone\SpecFlowWithSelenium\Reports\index.html F:\Kolabtreeclone\SpecFlowWithSelenium\MailFolder
rename F:\Kolabtreeclone\SpecFlowWithSelenium\MailFolder\index.html report_%time:~0,2%%time:~3,2%%time:~6,2%_%date:~-10,2%%date:~-7,2%%date:~-4,4%.html


