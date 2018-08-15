using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zu.AsyncWebDriver;
using Zu.AsyncWebDriver.Remote;
using Zu.Chrome;
using Zu.WebBrowser.AsyncInteractions;
using Zu.WebBrowser.BasicTypes;
using static Automatron.Clicker;

namespace Automatron
{
    public partial class Form1 : Form
    {
        private BindingList<AsyncChromeDriver> browsers = new BindingList<AsyncChromeDriver>();
        private WebDriver webDriver;
        Timer mainTimer = new Timer();
        DateTime clock = new DateTime();
        Proxies proxies = new Proxies();
        public Form1()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            Clicker.Run(tailURLTbox.Text, (int) instancesQtyNUD.Value);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var width = 600;
            var height = 300;
            Random random = new Random();

            for (int i = 0; i < (int) instancesQtyNUD.Value; i++)
            {
                // With Proxy// browsers.Add(new AsyncChromeDriver(new ChromeDriverConfig().SetCommandLineArgumets(Proxies.get()).SetWindowSize(width, height)));

                var browser = new AsyncChromeDriver(new ChromeDriverConfig().SetCommandLineArgumets(UserAgent.GetUA(random)).SetCommandLineArgumets(proxies.GetProxy(random)).SetWindowSize(width, height));
                
                browsers.Add(browser);
                //Console.WriteLine(UserAgent.GetUA(random));
            }

            listBox1.DataSource = browsers;

            foreach (AsyncChromeDriver browser in browsers)
            {
                try
                {
                    webDriver = new WebDriver(browser);
                    browser.Connect();

                }
                catch (Exception ex)
                {

                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            foreach (AsyncChromeDriver browser in browsers)
            {
                browser.Close();
                //browsers.Remove(browser);
            }
            browsers.Clear();
            //listBox1.Items.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            foreach (AsyncChromeDriver browser in browsers)
            {
                try
                {
                    webDriver = new WebDriver(browser);
                    await webDriver.Options().Timeouts.SetImplicitWait(TimeSpan.FromMinutes(3));

                    webDriver.GoToUrl(tailURLTbox.Text);
                    
                    //var link = await webDriver.FindElementByClassName("uk");
                    //await link.Click();

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clock = DateTime.Now;
            mainTimer.Interval = 100;  //in milliseconds

            mainTimer.Tick += new EventHandler(this.MainTimer_Tick);

            //start timer when form loads
            mainTimer.Start();  //this will use t_Tick() method

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            clock = await Ntp.GetNetworkTimeAsync();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, 100);
            clock = clock + ts;
            timerLbl.Text = clock.ToString("yyyy-MM-dd HH:mm:ss.fff",
                                            CultureInfo.InvariantCulture);
        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
             
        //    webDriver = new WebDriver((AsyncChromeDriver)listBox1.SelectedItem);
        //    //Zu.WebBrowser.AsyncInteractions.IJavaScriptExecutor js = (Zu.WebBrowser.AsyncInteractions.IJavaScriptExecutor)webDriver;
        //    webDriver.ExecuteAsyncScript("alert();");

        //}

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm:ss";
        }

        private async void clickBtn_Click(object sender, EventArgs e)
        {
            foreach (AsyncChromeDriver browser in browsers)
            {
                try
                {
                    webDriver = new WebDriver(browser);
                    await webDriver.Options().Timeouts.SetImplicitWait(TimeSpan.FromMinutes(3));

                    var link = await webDriver.FindElementByPartialLinkText(linkTextTBox.Text);
                    exeptionTBox.Text += link.ToString();
                    //await link.Click();

                    //var link = await webDriver.FindElementByClassName("uk");
                    link.Click();

                }
                catch (Exception ex)
                {
                    exeptionTBox.Text = ex.ToString();
                }
            }
            
        }
    }
}
