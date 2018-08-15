using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using Zu.AsyncWebDriver.Remote;
using Zu.Chrome;
using Zu.WebBrowser.BasicTypes;

namespace Automatron
{
    public partial class MainForm : Form
    {
        private BindingList<AsyncChromeDriver> browsers = new BindingList<AsyncChromeDriver>();
        private WebDriver webDriver;
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
                browsers.Add(browser);
                //Console.WriteLine(UserAgent.GetUA(random));
            }
            var source = new BindingSource(browsers, null);
            dataGridView1.DataSource = source;

            foreach (AsyncChromeDriver browser in browsers)
            {
                try
                {
                    browser.Connect();
                }
                catch (Exception ex)
                {
                    exeptionTBox.Text = ex.ToString();
                }
            }
        }

        private async void CloseBrowsersBtn_Click(object sender, EventArgs e)
        {
            foreach (AsyncChromeDriver browser in browsers)
            {
                browser.Close();
                //browsers.Remove(browser);
            }
            browsers.Clear();
            //listBox1.Items.Clear();
        }

        private async void GotoBtn_Click(object sender, EventArgs e)
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
                    await link.Click();

                }
                catch (Exception ex)
                {
                    exeptionTBox.Text = ex.ToString();
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

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
