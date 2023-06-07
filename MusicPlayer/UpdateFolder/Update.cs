using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;

namespace MusicPlayer.UpdateFolder
{
    public class Update
    {
        public static string getUpdateFile(string url)
        {
            using (var wc = new WebClient())
            {
                return wc.DownloadString(url);
            }
        }

        public static JsonProperties getJson(string data)
        {
            return JsonConvert.DeserializeObject<JsonProperties>(data);
        }

        public static void downloadUpdateFile(string url, string pathSave)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(new Uri(url), pathSave);
            }
        }
    }

    public class JsonProperties
    {
        public string name;
        public string version;
        public string datePublisher;
        public string downloadAddress;
    }
}
