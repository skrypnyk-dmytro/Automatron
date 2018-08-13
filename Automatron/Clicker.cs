using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace Automatron
{
    public static partial class Clicker
    {
        public static void run(string tailURL, int instances)
        {
            var browsers = new List<ChromeDriver>();

            for (int i = 0; i < instances; i++)
            {
                if (!String.IsNullOrEmpty(tailURL))
                {
                    Runner runner = new Runner(tailURL);
                    Thread t = new Thread(new ThreadStart(runner.run));
                    t.Start();
                }
            }

        }
    }
}
