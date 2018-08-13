using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automatron
{
    public static class Clicker
    {
        public static void Run(string tailURL, int instances)
        {
            var browsers = new List<ChromeDriver>();

            for (int i = 0; i < instances; i++)
            {
                browsers.Add(new ChromeDriver());
            }

            GoTo(browsers, tailURL);
            Click(browsers);

        }
        public static void GoTo(List<ChromeDriver> browsers, string tailURL)
        {
            foreach (ChromeDriver driv in browsers)
            {
                driv.Navigate().GoToUrl(tailURL);
            }
        }

        public static void Click(List<ChromeDriver> browsers)
        {
            foreach (ChromeDriver driv in browsers)
            {
                IWebElement link = driv.FindElementByClassName("uk");
                link.Click();
            }
        }

    }
}
