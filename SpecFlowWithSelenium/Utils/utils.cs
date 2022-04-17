using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowWithSelenium.Utils
{
    public class utils
    {
        private readonly IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver _browserDriver;

        public static int timeDelay = 2000;

        public utils(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            _browserDriver = browserDriver;
        }

        public static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        public string getRandomEmailAddress()
        {
            string timeStamp = GetTimestamp(DateTime.Now);
            //Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(2000);

            return "test"+ timeStamp + "@mailinator.com";
        }

        public void scrollToElement(IWebElement element)
        {
            Actions actions = new Actions(_browserDriver.Current);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public void switchTab(int tabNum)
        {
            _browserDriver.Current.SwitchTo().Window(_browserDriver.Current.WindowHandles[tabNum]);
        }
    }
}
