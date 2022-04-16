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
        public string Download()
        {
            AppSettingsReader appSettings = new AppSettingsReader();
            StringBuilder theCatText = new StringBuilder();
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += (s, eArgs) => 
            {
                theCatText.Append(eArgs.Result);
            };
            string webURL = (string)appSettings.GetValue("EndPoint", typeof(string));
            webClient.DownloadStringAsync(new Uri(webURL));
            return theCatText.ToString();
        }
    }
}
