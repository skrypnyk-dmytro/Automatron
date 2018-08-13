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

        public void run()
        {
            driv.Navigate().GoToUrl(this.tailURL);
        }
    }

}
