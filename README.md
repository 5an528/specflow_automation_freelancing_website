# Automation Test with extent report using SpecFlow and Selenium
<br>
<br>
The Automation Test demo is a way to help you all write easier and quicker test automation. <br>
This will solve common challenges you encounter during your work of automating an web application
<br>
<br>
Notes:
<br>
<br>
(1)System web driver version and project reference driver version need to be same.<br>
(2)You can give customized test report tile from common setting and report export location also. <br>
<br>
common setting lock like below:<br>
<br>
namespace SpecFlowWithSelenium.Common<br>
{<br>
    public static class Constants<br>
    {<br>
        public const string ReportName = @"Automation Test Report";<br>
        public const string ReportExportLocation = @"C:\SSD Work\Test\ResultNew\";<br>
    }<br>
}   <br>
<br>
For terminal run:<br>
cmd: f:<br>
cd F:\Kolabtreeclone\SpecFlowWithSelenium<br>
dotnet test<br>
copy F:\Kolabtreeclone\SpecFlowWithSelenium\Reports\index.html F:\Kolabtreeclone\SpecFlowWithSelenium\MailFolder<br>
rename F:\Kolabtreeclone\SpecFlowWithSelenium\MailFolder\index.html report_%time:~0,2%%time:~3,2%%time:~6,2%_%date:~-10,2%%date:~-7,2%%date:~-4,4%.html<br>


