using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;

namespace Automatron
{
    class Proxies
    {
        class Prox
        {
            public String ip { get; set; }
            public String port { get; set; }
            public String protocol { get; set; }

            public String getReady()
            {
                return "--proxy-server=" + protocol + "://" + this.ip + ':' + this.port;
            }
        }


        public static string get()
        {
            String result = null;
            String proxy = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.getproxylist.com/proxy?lastTested=600");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
                var prox = new JavaScriptSerializer().Deserialize<Prox>(result);
                proxy = prox.getReady();
                return proxy;
            }
        }
    }
}
