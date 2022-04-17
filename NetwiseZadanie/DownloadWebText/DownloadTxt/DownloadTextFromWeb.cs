using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;
namespace DownloadWebText
{
    public class DownloadTextFromWeb:IDownload
    {
        public string theCatText = null;
        public string Download()
        {
            try
            {
                AppSettingsReader appSettings = new AppSettingsReader();
                WebClient webClient = new WebClient();
                string webURL = (string)appSettings.GetValue("EndPoint", typeof(string));
                return webClient.DownloadString(new Uri(webURL));
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }
    }
}
