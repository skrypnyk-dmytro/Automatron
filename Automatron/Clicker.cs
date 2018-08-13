using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static Automatron.Proxies;

namespace Automatron
{
    class Clicker
    {


        public static void run(int instances, string tailURL)
        {
            IWebDriver[] drivers; 
            ChromeOptions options = new ChromeOptions();
            string proxy = Proxies.get();
            if (proxy != null)
            {
                options.AddArgument(proxy);
            }
            
            options.AddArgument("--user-agent=Mozilla/5.0 (iPad; CPU OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5355d Safari/8536.25");
            //options.
            for (int i = 0; i == instances; i++)
            {

            }

            IWebDriver driver = new ChromeDriver(options);
            driver.Url = tailURL;
            //driver.Close();
        }

    }
}
