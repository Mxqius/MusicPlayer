using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
namespace MusicPlayer
{
    public class Updater
    {
        private string UrlAddress;
        private string VersionApp;
        private string jOsText;
        public string DirectoryAddress()
        {
            var directoryadr = System.Environment.CurrentDirectory;
            string DirectoryCurrnet = Directory.GetParent(directoryadr).Parent.FullName;
            return DirectoryCurrnet;
        }
        public void UpdateFile(string Url,string SaveFileUrl)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(Url,"FileUpdate.zip");
            ZipFile.ExtractToDirectory(SaveFileUrl, "UpdateApp");
            File.Delete("FileUpdate.zip");
        }
        public string LoadJson(string Address, string Key)
        {
            using (StreamReader sr = new StreamReader(Address))
            {
                this.jOsText = sr.ReadToEnd();

            }
            var jObj = JObject.Parse(JsonText);
            var Value = jObj[Key];
            return Value.ToString();
        }
        public string GetVersionApp()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        public bool CheckVersion(string version)
        {
            string NowVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (version == NowVersion)
                return true;
            else 
                return false;
        }
        public string DownloadDataJson(string Url)
        {
            try
            {
                this.UrlAddress = Url;
                WebClient Web = new WebClient();
                string Data = Web.DownloadData(Url).ToString();
                return Data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string Version
        {
            get { return VersionApp; }
            set { VersionApp = value; }
        }
        public string JsonText
        {
            get { return jOsText; }
        }

    }
}
