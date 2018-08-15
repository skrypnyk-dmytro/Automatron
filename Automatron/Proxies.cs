using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Automatron
{
    class Proxies
    {
        List<String> proxies;

        public Proxies()
        {
            proxies = new List<String>();
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://proxy.l337.tech/txt");
            StreamReader reader = new StreamReader(stream);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // 4
                // Insert logic here.
                // ...
                // The "line" value is a line in the file.
                // Add it to our List.
                proxies.Add("--proxy-server=" + line);
            }
            //String resultw = null;
            //String proxy = null;
            //resultw = "{\"data\":[{\"ipPort\":\"203.104.204.222:3128\",\"ip\":\"203.104.204.222\",\"port\":\"3128\",\"country\":\"JP\",\"last_checked\":\"2018-08-15 01:14:06\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"117.52.74.179:80\",\"ip\":\"117.52.74.179\",\"port\":\"80\",\"country\":\"KR\",\"last_checked\":\"2018-08-15 03:12:21\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"203.104.203.62:3128\",\"ip\":\"203.104.203.62\",\"port\":\"3128\",\"country\":\"JP\",\"last_checked\":\"2018-08-15 03:29:47\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"218.241.196.237:80\",\"ip\":\"218.241.196.237\",\"port\":\"80\",\"country\":\"CN\",\"last_checked\":\"2018-08-15 00:40:10\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"199.96.227.197:3128\",\"ip\":\"199.96.227.197\",\"port\":\"3128\",\"country\":\"US\",\"last_checked\":\"2018-08-15 02:50:31\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"107.182.236.129:80\",\"ip\":\"107.182.236.129\",\"port\":\"80\",\"country\":\"US\",\"last_checked\":\"2018-08-15 01:05:28\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"27.100.36.234:80\",\"ip\":\"27.100.36.234\",\"port\":\"80\",\"country\":\"AU\",\"last_checked\":\"2018-08-15 03:32:05\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"50.59.162.78:8088\",\"ip\":\"50.59.162.78\",\"port\":\"8088\",\"country\":\"US\",\"last_checked\":\"2018-08-15 01:07:53\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"218.254.1.14:80\",\"ip\":\"218.254.1.14\",\"port\":\"80\",\"country\":\"HK\",\"last_checked\":\"2018-08-14 18:13:33\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"191.222.17.98:3128\",\"ip\":\"191.222.17.98\",\"port\":\"3128\",\"country\":\"BR\",\"last_checked\":\"2018-08-15 00:57:32\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"200.149.24.194:8080\",\"ip\":\"200.149.24.194\",\"port\":\"8080\",\"country\":\"BR\",\"last_checked\":\"2018-08-15 02:59:33\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":1,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"144.217.243.149:80\",\"ip\":\"144.217.243.149\",\"port\":\"80\",\"country\":\"CA\",\"last_checked\":\"2018-08-15 03:08:05\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"209.51.163.23:80\",\"ip\":\"209.51.163.23\",\"port\":\"80\",\"country\":\"US\",\"last_checked\":\"2018-08-15 03:00:54\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"159.203.90.247:80\",\"ip\":\"159.203.90.247\",\"port\":\"80\",\"country\":\"US\",\"last_checked\":\"2018-08-15 03:25:48\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"34.213.110.154:80\",\"ip\":\"34.213.110.154\",\"port\":\"80\",\"country\":\"US\",\"last_checked\":\"2018-08-15 00:40:14\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"91.121.30.82:80\",\"ip\":\"91.121.30.82\",\"port\":\"80\",\"country\":\"FR\",\"last_checked\":\"2018-08-15 02:52:44\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"35.194.65.211:80\",\"ip\":\"35.194.65.211\",\"port\":\"80\",\"country\":\"US\",\"last_checked\":\"2018-08-15 00:32:36\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"200.249.176.7:80\",\"ip\":\"200.249.176.7\",\"port\":\"80\",\"country\":\"BR\",\"last_checked\":\"2018-08-15 02:59:21\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"45.32.255.224:80\",\"ip\":\"45.32.255.224\",\"port\":\"80\",\"country\":\"US\",\"last_checked\":\"2018-08-15 02:30:27\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":null,\"user_agent\":1,\"google\":0}},{\"ipPort\":\"203.104.204.199:3128\",\"ip\":\"203.104.204.199\",\"port\":\"3128\",\"country\":\"JP\",\"last_checked\":\"2018-08-15 00:34:53\",\"proxy_level\":\"elite\",\"type\":\"socks5\",\"speed\":\"1\",\"support\":{\"https\":0,\"get\":1,\"post\":1,\"cookies\":1,\"referer\":1,\"user_agent\":1,\"google\":0}}],\"count\":20}";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://pubproxy.com/api/proxy?type=socks5&last_check=60&limit=1");
            //request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //using (Stream stream = response.GetResponseStream())
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    resultw = reader.ReadToEnd();
            //JObject results = JObject.Parse(resultw);
            //foreach (var result in results["data"])
            //{
            //    // this can be a string or null
            //    string ip = (string)result["ip"];
            //    string port = (string)result["port"];
            //    string type = (string)result["type"];

            //    this.proxies.Add("--proxy-server=" + type + "://" + ip + ':' + port);
            //}

            // }
        }

        //public String getReady()
        //{
        //    return "--proxy-server=" + this.type + "://" + this.ip + ':' + this.port;
        //}
        public string GetProxy(Random random)
        {
            int index = random.Next(0, proxies.Count);
            return proxies[index];
        }

    }
}
