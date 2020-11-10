using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebSideRequestH2
{
    public class UrlFetcher : DataFetcher
    {
        public UrlFetcher(string name) : base(name)
        {
        }

        public override string FetchData()
        {
            WebRequest request = GetWebRequest(Path);
            SetDefaultCredentials(request);
            WebResponse response = GetWebResponse(request);
            using (Stream datastream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(datastream);
                // Read the content
                // Display the content.
                return reader.ReadToEnd();
            }
        }

        public string FetchData(WebResponse response)
        {
            return ((HttpWebResponse)response).StatusDescription;
        }

        public WebRequest GetWebRequest(string path)
        {
            return WebRequest.Create(path);
        }

        public WebResponse GetWebResponse(WebRequest request)
        {
            return request.GetResponse();
        }

        public void SetDefaultCredentials(WebRequest webRequest)
        {
            webRequest.Credentials = CredentialCache.DefaultCredentials;
        }
    }
}
