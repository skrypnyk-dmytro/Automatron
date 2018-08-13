using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automatron
{
    public class Runner
    {
        private ChromeDriver driv;
        private string tailURL;

        public Runner(string tailURL)
        {
            driv = new ChromeDriver();
            this.tailURL = tailURL;
        }

        public void Run()
        {
            driv.Navigate().GoToUrl(this.tailURL);
            IWebElement link = driv.FindElementByClassName("uk");
            link.Click();
        }
    }

}
