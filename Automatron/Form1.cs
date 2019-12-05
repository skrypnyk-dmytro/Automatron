using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Zu.AsyncWebDriver.Remote;
using Zu.Chrome;
using Zu.WebBrowser.BasicTypes;
using System.Threading.Tasks;


namespace Automatron
{
    public partial class MainForm : Form
    {
        private List<WebDriver> webDrivers = new List<WebDriver>();
        Timer mainTimer = new Timer();
        DateTime clock = new DateTime();
        Proxies proxies = new Proxies();
        public MainForm()
        {
            InitializeComponent();
        }

        private async void OpenBrowserBtn_Click(object sender, EventArgs e)
        {
            var width = 600;
            var height = 800;
            Random random = new Random();

            for (int i = 0; i < (int) instancesQtyNUD.Value; i++)
            {
                // With Proxy// browsers.Add(new AsyncChromeDriver(new ChromeDriverConfig().SetCommandLineArgumets(Proxies.get()).SetWindowSize(width, height)));

                var browser = new AsyncChromeDriver(new ChromeDriverConfig().SetCommandLineArgumets(UserAgent.GetUA(random)).SetCommandLineArgumets(proxies.GetProxy(random)).SetWindowSize(width, height));

                var wd = new WebDriver(browser);
                webDrivers.Add(wd);

                //Console.WriteLine(UserAgent.GetUA(random));
            }

            for (int i = 0; i < webDrivers.Count; i++)
            {
                try
                {
                    webDrivers[i].browserClient.Connect();
                    listView1.Items.Add(await webDrivers[i].CurrentWindowHandle(), i);
                }
                catch (Exception ex)
                {
                    exeptionTBox.Text = ex.ToString();
                }
            }
        }

        private async void CloseBrowsersBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < webDrivers.Count; i++)
            {
                webDrivers[i].browserClient.Close();
            }
            webDrivers.Clear();
            listView1.Clear();
        }

        private async void GotoBtn_Click(object sender, EventArgs e)
        {
            List<System.Threading.CancellationTokenSource> cts = new List<System.Threading.CancellationTokenSource>();
            
            for (int i = 0; i < webDrivers.Count; i++)
            {
                cts.Add(new System.Threading.CancellationTokenSource());
                cts[i].CancelAfter(TimeSpan.FromSeconds((double)proxyTimeoutNUD.Value));

                try
                {
                    await GoToUrl(webDrivers[i], cts[i]);
                }
                catch (OperationCanceledException)
                {
                    webDrivers[i].browserClient.Close();
                    webDrivers.RemoveAt(i);
                    listView1.Items.RemoveAt(i);
                }
                catch (Exception)
                {
                    exeptionTBox.Text += "\r\nOpen failed.\r\n";
                }
            }
        }

        private async Task GoToUrl(WebDriver webDriver, System.Threading.CancellationTokenSource cts)
        {
            
            //await webDriver.Options().Timeouts.SetPageLoad(TimeSpan.FromSeconds(1));
            await webDriver.GoToUrl(tailURLTbox.Text, cts.Token);
            cts.CancelAfter(TimeSpan.FromHours(1));
        }

        private async void clickBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < webDrivers.Count; i++)
            {
                try
                {
                    await webDrivers[i].Options().Timeouts.SetImplicitWait(TimeSpan.FromMinutes(3));
                    var link = await webDrivers[i].FindElementByPartialLinkText(linkTextTBox.Text);
                    exeptionTBox.Text += link.ToString();
                    await link.Click();

                }
                catch (Exception ex)
                {
                    exeptionTBox.Text = ex.ToString();
                }
            }
        }

        private async void GetTimeBtn_Click(object sender, EventArgs e)
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

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm:ss";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clock = DateTime.Now;
            mainTimer.Interval = 100;
            mainTimer.Tick += new EventHandler(this.MainTimer_Tick);
            mainTimer.Start();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
