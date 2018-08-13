using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zu.AsyncWebDriver.Remote;
using Zu.Chrome;
using Zu.WebBrowser.BasicTypes;
using static Automatron.Clicker;

namespace Automatron
{
    public partial class Form1 : Form
    {
        private AsyncChromeDriver asyncChromeDriver;
        private List<AsyncChromeDriver> browsers = new List<AsyncChromeDriver>();
        private WebDriver webDriver;
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

            for (int i = 0; i < (int) instancesQtyNUD.Value; i++)
            {
                browsers.Add(new AsyncChromeDriver(new ChromeDriverConfig().SetWindowSize(width, height)));
            }


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
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            foreach (AsyncChromeDriver browser in browsers)
            {
                try
                {
                    webDriver = new WebDriver(browser);
                    webDriver.GoToUrl(tailURLTbox.Text);

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
